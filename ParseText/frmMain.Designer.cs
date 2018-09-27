namespace ParseText
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cmdParseFile = new System.Windows.Forms.Button();
            this.cmdSelectFile = new System.Windows.Forms.Button();
            this.dlgFilePicker = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gutenberg Text File";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(27, 25);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(159, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // cmdParseFile
            // 
            this.cmdParseFile.Enabled = false;
            this.cmdParseFile.Location = new System.Drawing.Point(111, 80);
            this.cmdParseFile.Name = "cmdParseFile";
            this.cmdParseFile.Size = new System.Drawing.Size(75, 23);
            this.cmdParseFile.TabIndex = 2;
            this.cmdParseFile.Text = "Parse File";
            this.cmdParseFile.UseVisualStyleBackColor = true;
            // 
            // cmdSelectFile
            // 
            this.cmdSelectFile.Location = new System.Drawing.Point(111, 51);
            this.cmdSelectFile.Name = "cmdSelectFile";
            this.cmdSelectFile.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectFile.TabIndex = 3;
            this.cmdSelectFile.Text = "Select File...";
            this.cmdSelectFile.UseVisualStyleBackColor = true;
            this.cmdSelectFile.Click += new System.EventHandler(this.cmdSelectFile_Click);
            // 
            // dlgFilePicker
            // 
            this.dlgFilePicker.FileName = "openFileDialog1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSelectFile);
            this.Controls.Add(this.cmdParseFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button cmdParseFile;
        private System.Windows.Forms.Button cmdSelectFile;
        private System.Windows.Forms.OpenFileDialog dlgFilePicker;
    }
}

