using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;

namespace FindChangedSignatureInGit
{
    public partial class MainForm : Form
    {
        private int gridRowCounter = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void gitCkeckBtn_Click(object sender, EventArgs e)
        {

            string repoAddress = "";
            int commitCounter = 0;
            int fileCounter = 0;
            List<string> plusList = new List<string>();
            List<string> minusList = new List<string>();
            string fileName = "";
            Regex javaFunctionsRegex = new Regex(@"^\+[ \t]*[a-zA-Z]*[ \t]*[a-zA-Z]+[ \t]+[a-zA-Z_][a-zA_Z0-9_]+[ \t]*\([a-zA-Z0-9_, ]*\)[a-zA-Z0-9_ \t]*{?}?$");
            Regex javaFunctionsRegex2 = new Regex(@"^-[ \t]*[a-zA-Z]*[ \t]*[a-zA-Z]+[ \t]+[a-zA-Z_][a-zA_Z0-9_]+[ \t]*\([a-zA-Z0-9_, ]*\)[a-zA-Z0-9_ \t]*{?}?$");



            FolderBrowserDialog directorySelectionDialog = new FolderBrowserDialog();
            directorySelectionDialog.Description = "Please select the directory address of your repository:";

            if (directorySelectionDialog.ShowDialog() == DialogResult.OK)
            {

                string sSelectedPath = directorySelectionDialog.SelectedPath;
                repoAddrTxt.Text = sSelectedPath;
                repoAddress = sSelectedPath;
                repoAddress.Replace("\\", "\\\\");
                this.gitCkeckBtn.Enabled = false;
                messageLbl.Text = "Processing ...";
                messageLbl.ForeColor = Color.Black;

                resultGrid.Rows.Clear();
                Application.DoEvents();

                //Finding all commits and writting them in a file (commits.txt)
                #region AllcommitFinder

                //string mycommand = "git -C \"D:\\Git repo\\testGity\" log --pretty=%H > commits.txt";
                string mycommand = "git -C \"" + repoAddress + "\" log --pretty=%H > commits.txt";

                executeGitCommand(mycommand);
                processStatusLbl.Text = "All commits have been found.";


                //check if commits.txt writting is finished;
                continueIfFileGetUnlocked("commits.txt");
                System.Threading.Thread.Sleep(3000);

                #endregion


                //Finding all changed files for all commits and writting them in a file (files.txt)
                #region AllFileFinder

                try
                {
                    System.IO.File.WriteAllText(@"files.txt", ""); // create an empty file
                    foreach (string line in File.ReadLines(@"commits.txt", Encoding.UTF8))
                    {
                        //string mycommand = "git -C \"D:\\Git repo\\testGity\" diff-tree --no-commit-id --name-only -r " + line + " >> files.txt";
                        mycommand = "git -C \"" + repoAddress + "\" diff-tree --no-commit-id --name-only -r " + line + " >> files.txt";
                        executeGitCommand(mycommand);

                    }
                    processStatusLbl.Text = "All files have been found.";


                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    // instructionLbl.Text = ex.Message + "2222";
                }

                continueIfFileGetUnlocked("files.txt");//check if files.txt writting is finished
                System.Threading.Thread.Sleep(2000);
                #endregion


                //find all modified functions' signatures
                #region AllChangedSignatureFinder

                try
                {
                    System.IO.File.WriteAllText(@"result.csv", ""); // create an empty file


                    foreach (string line in File.ReadLines(@"commits.txt", Encoding.UTF8))
                    {
                        commitCounter++;
                        System.IO.File.WriteAllText(@"eachCommitResult.txt", ""); // create an empty file                    

                        //string mycommand = "git -C \"D:\\Git repo\\testGity\" diff " + line + "~ " + line + " >> eachCommitResult.txt";
                        mycommand = "git -C \"" + repoAddress + "\"   diff " + line + "~ " + line + " >> eachCommitResult.txt";
                        executeGitCommand(mycommand);

                        continueIfFileGetUnlocked("eachCommitResult.txt");
                        System.Threading.Thread.Sleep(2000);

                        foreach (string line2 in File.ReadLines(@"eachCommitResult.txt", Encoding.UTF8))
                        {
                            //Console.WriteLine("2");

                            if (line2.StartsWith("+++")) //introduce the changed file
                            {
                                fileName = line2.Substring(6);
                                fileCounter++;
                                processStatusLbl.Text = commitCounter.ToString() + " Commit(s) and " + fileCounter.ToString() + " file(s) have been processed. ";
                                Application.DoEvents();
                            }
                            if (line2.StartsWith("@@")) // introduce new hunk
                            {
                                if (fileName != "" && plusList.Count > 0)//we should write the result of previous hunk first and start the new hunk's processing
                                {
                                    reportPreviousHunkResults(plusList, minusList, line, fileName);
                                }
                                plusList.Clear();
                                minusList.Clear();

                            }//if @@

                            if (line2.StartsWith("+") && !line2.StartsWith("+++") && javaFunctionsRegex.IsMatch(line2))
                            {
                                plusList.Add(line2);
                            }
                            if (line2.StartsWith("-") && !line2.StartsWith("---") && javaFunctionsRegex2.IsMatch(line2))
                            {
                                minusList.Add(line2);
                            }

                        }//eachcommit result

                        if (fileName != "" && plusList.Count > 0)
                        {
                            reportPreviousHunkResults(plusList, minusList, line, fileName);
                        }//if commit result is finished before checking the next commit
                        plusList.Clear();
                        minusList.Clear();

                    }//each readed Commit line

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    instructionLbl.Text = ex.Message + "111";
                }

                #endregion


                this.gitCkeckBtn.Enabled = true;

                messageLbl.Text = "The process is finished!";
                messageLbl.ForeColor = Color.Green;

                resultPnl.Visible = true;
                openResultBtn.Click += new EventHandler(this.OpenCSVevent);


            }

        }


        public void OpenCSVevent(Object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("result.csv"))
                {
                    System.Diagnostics.Process.Start("result.csv");
                }
                else
                {
                    MessageBox.Show("There is a problem, the file cannot be found!");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        public void executeGitCommand(string mycommand)
        {
            try
            {
                ProcessStartInfo ProcessInfo;
                Process Process;

                ProcessInfo = new ProcessStartInfo("cmd.exe", "/C " + mycommand);// /C means close commandline after finishing the executed code
                ProcessInfo.WindowStyle = ProcessWindowStyle.Hidden;
                ProcessInfo.CreateNoWindow = true;
                ProcessInfo.UseShellExecute = true;

                Process = Process.Start(ProcessInfo);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
        }



        public void reportPreviousHunkResults(List<string> myPlusList, List<string> myMinusList, string MyLine, string myFileName)
        {
            try
            {
                string resultLine = "";
                for (int i = 0; i < myPlusList.Count; i++)
                {
                    for (int j = 0; j < myMinusList.Count; j++)
                    {
                        int k = myPlusList[i].IndexOf('(');
                        string plusFuncName = myPlusList[i].Substring(1, k - 1).Trim();
                        k = plusFuncName.LastIndexOf(' ');
                        plusFuncName = plusFuncName.Substring(k + 1); //name of function

                        k = myMinusList[j].IndexOf('(');
                        string minusFuncName = myMinusList[j].Substring(1, k - 1).Trim();
                        k = minusFuncName.LastIndexOf(' ');
                        minusFuncName = minusFuncName.Substring(k + 1); //name of function

                        if (plusFuncName == minusFuncName)
                        {
                            string[] splitedplus = myPlusList[i].Split(',');
                            string[] splitedminus = myMinusList[j].Split(',');
                            if (splitedplus.Count() > splitedminus.Count())
                            {
                                resultGrid.Rows.Add();
                                resultGrid[0, gridRowCounter].Value = MyLine;
                                resultGrid[1, gridRowCounter].Value = myFileName;
                                int k1 = myMinusList[j].IndexOf(')');
                                resultGrid[2, gridRowCounter].Value = myMinusList[j].Substring(1, k1).Trim();
                                int k2 = myPlusList[i].IndexOf(')');
                                resultGrid[3, gridRowCounter].Value = myPlusList[i].Substring(1, k2).Trim();
                                gridRowCounter++;
                                resultLine = MyLine.Replace(',', ';') + "," + myFileName.Replace(',', ';') + "," + myMinusList[j].Substring(1, k1).Trim().Replace(',', ';') + "," + myPlusList[i].Substring(1, k2).Trim().Replace(',', ';');
                                File.AppendAllText("result.csv", resultLine + "\n");
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //instructionLbl.Text = ex.Message + "2222";
            }
        }

        public bool IsFileLocked(string filename)
        {
            bool Locked = false;
            try
            {
                FileStream fs =
                    File.Open(filename, FileMode.OpenOrCreate,
                    FileAccess.ReadWrite, FileShare.None);
                fs.Close();
            }
            catch (IOException ex)
            {
                Locked = true;
            }
            return Locked;
        }

        public void continueIfFileGetUnlocked(string fileName)
        {
            while (true)
            {
                if (!IsFileLocked(fileName))
                {
                    break;
                }
            }
        }



    }
}
