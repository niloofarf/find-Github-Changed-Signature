namespace FindChangedSignatureInGit
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
            this.instructionLbl = new System.Windows.Forms.Label();
            this.gitCkeckBtn = new System.Windows.Forms.Button();
            this.repoAddrTxt = new System.Windows.Forms.TextBox();
            this.processStatusLbl = new System.Windows.Forms.Label();
            this.messageLbl = new System.Windows.Forms.Label();
            this.resultGrid = new System.Windows.Forms.DataGridView();
            this.CommitGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beforeGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afterGridColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLbl
            // 
            this.instructionLbl.AutoSize = true;
            this.instructionLbl.Location = new System.Drawing.Point(23, 20);
            this.instructionLbl.Name = "instructionLbl";
            this.instructionLbl.Size = new System.Drawing.Size(296, 13);
            this.instructionLbl.TabIndex = 12;
            this.instructionLbl.Text = "Please click on git Checker button below to start the process:";
            // 
            // gitCkeckBtn
            // 
            this.gitCkeckBtn.Location = new System.Drawing.Point(432, 47);
            this.gitCkeckBtn.Name = "gitCkeckBtn";
            this.gitCkeckBtn.Size = new System.Drawing.Size(75, 23);
            this.gitCkeckBtn.TabIndex = 8;
            this.gitCkeckBtn.Text = "git Checker";
            this.gitCkeckBtn.UseVisualStyleBackColor = true;
            this.gitCkeckBtn.Click += new System.EventHandler(this.gitCkeckBtn_Click);
            // 
            // repoAddrTxt
            // 
            this.repoAddrTxt.Enabled = false;
            this.repoAddrTxt.Location = new System.Drawing.Point(26, 50);
            this.repoAddrTxt.Name = "repoAddrTxt";
            this.repoAddrTxt.Size = new System.Drawing.Size(397, 20);
            this.repoAddrTxt.TabIndex = 11;
            // 
            // processStatusLbl
            // 
            this.processStatusLbl.AutoSize = true;
            this.processStatusLbl.ForeColor = System.Drawing.Color.Gray;
            this.processStatusLbl.Location = new System.Drawing.Point(23, 133);
            this.processStatusLbl.Name = "processStatusLbl";
            this.processStatusLbl.Size = new System.Drawing.Size(16, 13);
            this.processStatusLbl.TabIndex = 10;
            this.processStatusLbl.Text = "...";
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLbl.Location = new System.Drawing.Point(23, 94);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(20, 17);
            this.messageLbl.TabIndex = 9;
            this.messageLbl.Text = "...";
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
            this.resultGrid.Location = new System.Drawing.Point(12, 170);
            this.resultGrid.Name = "resultGrid";
            this.resultGrid.ReadOnly = true;
            this.resultGrid.Size = new System.Drawing.Size(870, 241);
            this.resultGrid.TabIndex = 13;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 438);
            this.Controls.Add(this.resultGrid);
            this.Controls.Add(this.instructionLbl);
            this.Controls.Add(this.gitCkeckBtn);
            this.Controls.Add(this.repoAddrTxt);
            this.Controls.Add(this.processStatusLbl);
            this.Controls.Add(this.messageLbl);
            this.Name = "MainForm";
            this.Text = "Find Changed Function\'s Signature in Github";
            ((System.ComponentModel.ISupportInitialize)(this.resultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label instructionLbl;
        private System.Windows.Forms.Button gitCkeckBtn;
        private System.Windows.Forms.TextBox repoAddrTxt;
        private System.Windows.Forms.Label processStatusLbl;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.DataGridView resultGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommitGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn beforeGridColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afterGridColumn;
    }
}