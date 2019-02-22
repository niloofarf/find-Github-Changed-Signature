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
        public MainForm()
        {
            InitializeComponent();
        }

        private void gitCkeckBtn_Click(object sender, EventArgs e)
        {

            string repoAddress = "";

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


                #endregion

                this.gitCkeckBtn.Enabled = true;

                messageLbl.Text = "The process is finished!";
                messageLbl.ForeColor = Color.Green;


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





    }
}
