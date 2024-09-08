namespace URLParser
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.btnInputFile = new System.Windows.Forms.Button();
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.btnOutputFile = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnChangeTheme = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInputFile
            // 
            this.txtInputFile.Location = new System.Drawing.Point(12, 12);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.Size = new System.Drawing.Size(379, 20);
            this.txtInputFile.TabIndex = 0;
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(433, 7);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(100, 23);
            this.btnInputFile.TabIndex = 1;
            this.btnInputFile.Text = "Выбрать файл";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // txtOutputFilePath
            // 
            this.txtOutputFilePath.Location = new System.Drawing.Point(12, 38);
            this.txtOutputFilePath.Name = "txtOutputFilePath";
            this.txtOutputFilePath.Size = new System.Drawing.Size(379, 20);
            this.txtOutputFilePath.TabIndex = 2;
            // 
            // btnOutputFile
            // 
            this.btnOutputFile.Location = new System.Drawing.Point(433, 33);
            this.btnOutputFile.Name = "btnOutputFile";
            this.btnOutputFile.Size = new System.Drawing.Size(100, 23);
            this.btnOutputFile.TabIndex = 3;
            this.btnOutputFile.Text = "Выбрать файл";
            this.btnOutputFile.UseVisualStyleBackColor = true;
            this.btnOutputFile.Click += new System.EventHandler(this.btnOutputFile_Click);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(12, 64);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(379, 20);
            this.txtLink.TabIndex = 4;
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(433, 61);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(100, 23);
            this.btnParse.TabIndex = 5;
            this.btnParse.Text = "Ввести";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 90);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(521, 150);
            this.txtResult.TabIndex = 6;
            this.txtResult.Text = "";
            // 
            // btnChangeTheme
            // 
            this.btnChangeTheme.Location = new System.Drawing.Point(12, 246);
            this.btnChangeTheme.Name = "btnChangeTheme";
            this.btnChangeTheme.Size = new System.Drawing.Size(100, 23);
            this.btnChangeTheme.TabIndex = 7;
            this.btnChangeTheme.Text = "Сменить тему";
            this.btnChangeTheme.UseVisualStyleBackColor = true;
            this.btnChangeTheme.Click += new System.EventHandler(this.btnChangeTheme_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(433, 246);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 23);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Справка";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(545, 281);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnChangeTheme);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnOutputFile);
            this.Controls.Add(this.txtOutputFilePath);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.btnInputFile);
            this.Name = "Form1";
            this.Text = "URL Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.Button btnOutputFile;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnChangeTheme;
        private System.Windows.Forms.Button btnHelp;
    }
}
