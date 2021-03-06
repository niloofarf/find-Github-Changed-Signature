﻿namespace FindChangedSignatureInGit
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gitCkeckBtn = new System.Windows.Forms.Button();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.CommitGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instructionLbl = new System.Windows.Forms.Label();
            this.repoAddrTxt = new System.Windows.Forms.TextBox();
            this.processStatusLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.finalFileLbl = new System.Windows.Forms.Label();
            this.openResultBtn = new System.Windows.Forms.Button();
            this.resultPnl = new System.Windows.Forms.Panel();
            this.MainPnl = new System.Windows.Forms.SplitContainer();
            this.TopSpliter = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.resultPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPnl)).BeginInit();
            this.MainPnl.Panel1.SuspendLayout();
            this.MainPnl.Panel2.SuspendLayout();
            this.MainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopSpliter)).BeginInit();
            this.TopSpliter.Panel1.SuspendLayout();
            this.TopSpliter.Panel2.SuspendLayout();
            this.TopSpliter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gitCkeckBtn
            // 
            this.gitCkeckBtn.Location = new System.Drawing.Point(433, 47);
            this.gitCkeckBtn.Name = "gitCkeckBtn";
            this.gitCkeckBtn.Size = new System.Drawing.Size(75, 23);
            this.gitCkeckBtn.TabIndex = 0;
            this.gitCkeckBtn.Text = "git Checker";
            this.gitCkeckBtn.UseVisualStyleBackColor = true;
            this.gitCkeckBtn.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // resultGrid
            // 
            this.resultGrid.AllowUserToAddRows = false;
            this.resultGrid.AllowUserToDeleteRows = false;
            this.resultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CommitGridColumn,
            this.fileGridColumn,
            this.beforeGridColumn,
            this.afterGridColumn});
            this.resultGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultGrid.Location = new System.Drawing.Point(20, 0);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.Size = new System.Drawing.Size(865, 238);
            this.resultGrid.TabIndex = 1;
            this.resultGrid.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // CommitGridColumn
            // 
            this.CommitGridColumn.HeaderText = "Commit SHA";
            this.CommitGridColumn.Name = "CommitGridColumn";
            this.CommitGridColumn.ReadOnly = true;
            this.CommitGridColumn.Width = 250;
            // 
            // fileGridColumn
            // 
            this.fileGridColumn.HeaderText = "Java File";
            this.fileGridColumn.Name = "fileGridColumn";
            this.fileGridColumn.ReadOnly = true;
            this.fileGridColumn.Width = 150;
            // 
            // beforeGridColumn
            // 
            this.beforeGridColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.beforeGridColumn.HeaderText = "Old Function Signature";
            this.beforeGridColumn.Name = "beforeGridColumn";
            this.beforeGridColumn.ReadOnly = true;
            // 
            // afterGridColumn
            // 
            this.afterGridColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.afterGridColumn.HeaderText = "New Function Signature";
            this.afterGridColumn.Name = "afterGridColumn";
            this.afterGridColumn.ReadOnly = true;
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(24, 20);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(296, 13);
            this.instructionLbl.TabIndex = 7;
            this.instructionLbl.Text = "Please click on git Checker button below to start the process:";
            this.instructionLbl.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // repoAddrTxt
            // 
            this.repoAddrTxt.Enabled = false;
            this.repoAddrTxt.Location = new System.Drawing.Point(27, 50);
            this.repoAddrTxt.Name = "repoAddrTxt";
            this.repoAddrTxt.Size = new System.Drawing.Size(397, 20);
            this.repoAddrTxt.TabIndex = 6;
            this.repoAddrTxt.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // processStatusLbl
            // 
            this.processStatusLbl.AutoSize = true;
            this.processStatusLbl.ForeColor = System.Drawing.Color.Gray;
            this.processStatusLbl.Location = new System.Drawing.Point(24, 133);
            this.processStatusLbl.Name = "processStatusLbl";
            this.processStatusLbl.Size = new System.Drawing.Size(16, 13);
            this.processStatusLbl.TabIndex = 5;
            this.processStatusLbl.Text = "...";
            this.processStatusLbl.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.Location = new System.Drawing.Point(24, 94);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(20, 17);
            this.messageLbl.TabIndex = 2;
            this.messageLbl.Text = "...";
            this.messageLbl.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // finalFileLbl
            // 
            this.finalFileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalFileLbl.Location = new System.Drawing.Point(26, 29);
            this.finalFileLbl.Name = "finalFileLbl";
            this.finalFileLbl.Size = new System.Drawing.Size(220, 34);
            this.finalFileLbl.TabIndex = 8;
            this.finalFileLbl.Text = "The final result is in result.csv file. click on the button below to open it:";
            // 
            // openResultBtn
            // 
            this.openResultBtn.Location = new System.Drawing.Point(49, 74);
            this.openResultBtn.Name = "openResultBtn";
            this.openResultBtn.Size = new System.Drawing.Size(175, 23);
            this.openResultBtn.TabIndex = 9;
            this.openResultBtn.Text = "Open result.csv";
            this.openResultBtn.UseVisualStyleBackColor = true;
            // 
            // resultPnl
            // 
            this.resultPnl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resultPnl.Controls.Add(this.finalFileLbl);
            this.resultPnl.Controls.Add(this.openResultBtn);
            this.resultPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultPnl.Location = new System.Drawing.Point(20, 20);
            this.resultPnl.Name = "resultPnl";
            this.resultPnl.Padding = new System.Windows.Forms.Padding(10);
            this.resultPnl.Size = new System.Drawing.Size(266, 136);
            this.resultPnl.TabIndex = 10;
            this.resultPnl.Visible = false;
            this.resultPnl.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // MainPnl
            // 
            this.MainPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPnl.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainPnl.Location = new System.Drawing.Point(0, 0);
            this.MainPnl.Name = "MainPnl";
            this.MainPnl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainPnl.Panel1
            // 
            this.MainPnl.Panel1.Controls.Add(this.TopSpliter);
            // 
            // MainPnl.Panel2
            // 
            this.MainPnl.Panel2.Controls.Add(this.resultGrid);
            this.MainPnl.Panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.MainPnl.Size = new System.Drawing.Size(905, 438);
            this.MainPnl.SplitterDistance = 176;
            this.MainPnl.TabIndex = 12;
            this.MainPnl.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // TopSpliter
            // 
            this.TopSpliter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopSpliter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.TopSpliter.Location = new System.Drawing.Point(0, 0);
            this.TopSpliter.Name = "TopSpliter";
            // 
            // TopSpliter.Panel1
            // 
            this.TopSpliter.Panel1.Controls.Add(this.instructionLbl);
            this.TopSpliter.Panel1.Controls.Add(this.gitCkeckBtn);
            this.TopSpliter.Panel1.Controls.Add(this.repoAddrTxt);
            this.TopSpliter.Panel1.Controls.Add(this.processStatusLbl);
            this.TopSpliter.Panel1.Controls.Add(this.messageLbl);
            this.TopSpliter.Panel1.Padding = new System.Windows.Forms.Padding(20);
            // 
            // TopSpliter.Panel2
            // 
            this.TopSpliter.Panel2.Controls.Add(this.resultPnl);
            this.TopSpliter.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.TopSpliter.Size = new System.Drawing.Size(905, 176);
            this.TopSpliter.SplitterDistance = 595;
            this.TopSpliter.TabIndex = 11;
            this.TopSpliter.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 438);
            this.Controls.Add(this.MainPnl);
            this.Name = "MainForm";
            this.Text = "Find Changed Function\'s Signature in Github";
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.resultPnl.ResumeLayout(false);
            this.MainPnl.Panel1.ResumeLayout(false);
            this.MainPnl.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPnl)).EndInit();
            this.MainPnl.ResumeLayout(false);
            this.TopSpliter.Panel1.ResumeLayout(false);
            this.TopSpliter.Panel1.PerformLayout();
            this.TopSpliter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopSpliter)).EndInit();
            this.TopSpliter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gitCkeckBtn;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommitGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afterGridColumn;
        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.TextBox repoAddrTxt;
        private System.Windows.Forms.Label processStatusLbl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Label finalFileLbl;
        private System.Windows.Forms.Button openResultBtn;
        private System.Windows.Forms.Panel resultPnl;
        private System.Windows.Forms.SplitContainer MainPnl;
        private System.Windows.Forms.SplitContainer TopSpliter;
    }
}