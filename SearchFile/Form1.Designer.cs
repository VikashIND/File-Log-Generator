namespace SearchFile
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnInputPath = new System.Windows.Forms.Button();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbOutputFileExcel = new System.Windows.Forms.RadioButton();
            this.rbOutputFileText = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastModifiedDays = new System.Windows.Forms.TextBox();
            this.txtMaxRecord = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkDll = new System.Windows.Forms.CheckBox();
            this.chkHtml = new System.Windows.Forms.CheckBox();
            this.chkCss = new System.Windows.Forms.CheckBox();
            this.chkText = new System.Windows.Forms.CheckBox();
            this.chkAspx = new System.Windows.Forms.CheckBox();
            this.chkCS = new System.Windows.Forms.CheckBox();
            this.rbFileTypes = new System.Windows.Forms.RadioButton();
            this.rbAllFileTypes = new System.Windows.Forms.RadioButton();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInputPath
            // 
            this.btnInputPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInputPath.Location = new System.Drawing.Point(420, 29);
            this.btnInputPath.Name = "btnInputPath";
            this.btnInputPath.Size = new System.Drawing.Size(102, 23);
            this.btnInputPath.TabIndex = 0;
            this.btnInputPath.Text = "Select Directory";
            this.btnInputPath.UseVisualStyleBackColor = true;
            this.btnInputPath.Click += new System.EventHandler(this.btnInputPath_Click);
            // 
            // txtInputPath
            // 
            this.txtInputPath.Location = new System.Drawing.Point(140, 30);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.ReadOnly = true;
            this.txtInputPath.Size = new System.Drawing.Size(277, 20);
            this.txtInputPath.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSaveFile);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOutputPath);
            this.groupBox1.Controls.Add(this.btnOutputPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInputPath);
            this.groupBox1.Controls.Add(this.btnInputPath);
            this.groupBox1.Location = new System.Drawing.Point(23, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory Browser";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbOutputFileExcel);
            this.groupBox3.Controls.Add(this.rbOutputFileText);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtLastModifiedDays);
            this.groupBox3.Controls.Add(this.txtMaxRecord);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(234, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 83);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Output Options";
            // 
            // rbOutputFileExcel
            // 
            this.rbOutputFileExcel.AutoSize = true;
            this.rbOutputFileExcel.Location = new System.Drawing.Point(206, 61);
            this.rbOutputFileExcel.Name = "rbOutputFileExcel";
            this.rbOutputFileExcel.Size = new System.Drawing.Size(51, 17);
            this.rbOutputFileExcel.TabIndex = 6;
            this.rbOutputFileExcel.Text = "Excel";
            this.rbOutputFileExcel.UseVisualStyleBackColor = true;
            // 
            // rbOutputFileText
            // 
            this.rbOutputFileText.AutoSize = true;
            this.rbOutputFileText.Checked = true;
            this.rbOutputFileText.Location = new System.Drawing.Point(154, 61);
            this.rbOutputFileText.Name = "rbOutputFileText";
            this.rbOutputFileText.Size = new System.Drawing.Size(46, 17);
            this.rbOutputFileText.TabIndex = 5;
            this.rbOutputFileText.TabStop = true;
            this.rbOutputFileText.Text = "Text";
            this.rbOutputFileText.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Output File Type :";
            // 
            // txtLastModifiedDays
            // 
            this.txtLastModifiedDays.Location = new System.Drawing.Point(152, 16);
            this.txtLastModifiedDays.MaxLength = 4;
            this.txtLastModifiedDays.Name = "txtLastModifiedDays";
            this.txtLastModifiedDays.Size = new System.Drawing.Size(100, 20);
            this.txtLastModifiedDays.TabIndex = 3;
            this.txtLastModifiedDays.Text = "30";
            this.txtLastModifiedDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastModifiedDays_KeyPress);
            // 
            // txtMaxRecord
            // 
            this.txtMaxRecord.Location = new System.Drawing.Point(152, 40);
            this.txtMaxRecord.MaxLength = 4;
            this.txtMaxRecord.Name = "txtMaxRecord";
            this.txtMaxRecord.Size = new System.Drawing.Size(100, 20);
            this.txtMaxRecord.TabIndex = 2;
            this.txtMaxRecord.Text = "100";
            this.txtMaxRecord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxRecord_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Max Record :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Modified Date In Days :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkDll);
            this.groupBox2.Controls.Add(this.chkHtml);
            this.groupBox2.Controls.Add(this.chkCss);
            this.groupBox2.Controls.Add(this.chkText);
            this.groupBox2.Controls.Add(this.chkAspx);
            this.groupBox2.Controls.Add(this.chkCS);
            this.groupBox2.Controls.Add(this.rbFileTypes);
            this.groupBox2.Controls.Add(this.rbAllFileTypes);
            this.groupBox2.Location = new System.Drawing.Point(27, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 83);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Types";
            // 
            // chkDll
            // 
            this.chkDll.AutoSize = true;
            this.chkDll.Location = new System.Drawing.Point(120, 60);
            this.chkDll.Name = "chkDll";
            this.chkDll.Size = new System.Drawing.Size(46, 17);
            this.chkDll.TabIndex = 7;
            this.chkDll.Text = "DLL";
            this.chkDll.UseVisualStyleBackColor = true;
            // 
            // chkHtml
            // 
            this.chkHtml.AutoSize = true;
            this.chkHtml.Location = new System.Drawing.Point(121, 39);
            this.chkHtml.Name = "chkHtml";
            this.chkHtml.Size = new System.Drawing.Size(47, 17);
            this.chkHtml.TabIndex = 6;
            this.chkHtml.Text = "Html";
            this.chkHtml.UseVisualStyleBackColor = true;
            // 
            // chkCss
            // 
            this.chkCss.AutoSize = true;
            this.chkCss.Location = new System.Drawing.Point(65, 60);
            this.chkCss.Name = "chkCss";
            this.chkCss.Size = new System.Drawing.Size(47, 17);
            this.chkCss.TabIndex = 5;
            this.chkCss.Text = "CSS";
            this.chkCss.UseVisualStyleBackColor = true;
            // 
            // chkText
            // 
            this.chkText.AutoSize = true;
            this.chkText.Location = new System.Drawing.Point(8, 60);
            this.chkText.Name = "chkText";
            this.chkText.Size = new System.Drawing.Size(47, 17);
            this.chkText.TabIndex = 4;
            this.chkText.Text = "Text";
            this.chkText.UseVisualStyleBackColor = true;
            // 
            // chkAspx
            // 
            this.chkAspx.AutoSize = true;
            this.chkAspx.Location = new System.Drawing.Point(66, 39);
            this.chkAspx.Name = "chkAspx";
            this.chkAspx.Size = new System.Drawing.Size(49, 17);
            this.chkAspx.TabIndex = 3;
            this.chkAspx.Text = "Aspx";
            this.chkAspx.UseVisualStyleBackColor = true;
            // 
            // chkCS
            // 
            this.chkCS.AutoSize = true;
            this.chkCS.Location = new System.Drawing.Point(9, 39);
            this.chkCS.Name = "chkCS";
            this.chkCS.Size = new System.Drawing.Size(40, 17);
            this.chkCS.TabIndex = 2;
            this.chkCS.Text = "CS";
            this.chkCS.UseVisualStyleBackColor = true;
            // 
            // rbFileTypes
            // 
            this.rbFileTypes.AutoSize = true;
            this.rbFileTypes.Checked = true;
            this.rbFileTypes.Location = new System.Drawing.Point(9, 15);
            this.rbFileTypes.Name = "rbFileTypes";
            this.rbFileTypes.Size = new System.Drawing.Size(106, 17);
            this.rbFileTypes.TabIndex = 1;
            this.rbFileTypes.TabStop = true;
            this.rbFileTypes.Text = "Select File Types";
            this.rbFileTypes.UseVisualStyleBackColor = true;
            this.rbFileTypes.CheckedChanged += new System.EventHandler(this.rbFileTypes_CheckedChanged);
            // 
            // rbAllFileTypes
            // 
            this.rbAllFileTypes.AutoSize = true;
            this.rbAllFileTypes.Location = new System.Drawing.Point(121, 15);
            this.rbAllFileTypes.Name = "rbAllFileTypes";
            this.rbAllFileTypes.Size = new System.Drawing.Size(36, 17);
            this.rbAllFileTypes.TabIndex = 0;
            this.rbAllFileTypes.Text = "All";
            this.rbAllFileTypes.UseVisualStyleBackColor = true;
            this.rbAllFileTypes.CheckedChanged += new System.EventHandler(this.rbAllFileTypes_CheckedChanged);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(386, 200);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(137, 23);
            this.btnSaveFile.TabIndex = 8;
            this.btnSaveFile.Text = "Generate File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(148, 202);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(221, 20);
            this.txtFileName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Output File Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output Directory Path :";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(140, 72);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.ReadOnly = true;
            this.txtOutputPath.Size = new System.Drawing.Size(277, 20);
            this.txtOutputPath.TabIndex = 4;
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Location = new System.Drawing.Point(420, 71);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(102, 23);
            this.btnOutputPath.TabIndex = 3;
            this.btnOutputPath.Text = "Select Directory";
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Directory Path :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Design && Developed By : Vikash Kumar";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(23, 255);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(28, 13);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 277);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files Log Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnInputPath;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnOutputPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFileTypes;
        private System.Windows.Forms.RadioButton rbAllFileTypes;
        private System.Windows.Forms.CheckBox chkCss;
        private System.Windows.Forms.CheckBox chkText;
        private System.Windows.Forms.CheckBox chkAspx;
        private System.Windows.Forms.CheckBox chkCS;
        private System.Windows.Forms.TextBox txtMaxRecord;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastModifiedDays;
        private System.Windows.Forms.RadioButton rbOutputFileExcel;
        private System.Windows.Forms.RadioButton rbOutputFileText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDll;
        private System.Windows.Forms.CheckBox chkHtml;
    }
}

