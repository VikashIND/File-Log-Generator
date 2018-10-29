using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToLongDateString();
            ValidateFileTypes();
        }

        private void btnInputPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtInputPath.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }
            }

        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtOutputPath.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {

                try
                {
                    var outputDirectory = txtOutputPath.Text;
                    var outputFileName = txtFileName.Text;
                    string outputFileExtension;

                    if (rbOutputFileExcel.Checked)
                        outputFileExtension = ".xls";
                    else if (rbOutputFileText.Checked)
                        outputFileExtension = ".txt";
                    else
                        outputFileExtension = ".txt";

                    outputDirectory += "\\" + outputFileName + outputFileExtension;


                    var files = Directory.EnumerateFiles(txtInputPath.Text, "*.*", SearchOption.AllDirectories).Select(i => new FileInfo(i))
                    .Where(file => file.LastWriteTime.Day <= Convert.ToInt32(txtLastModifiedDays.Text))
                    .OrderByDescending(file => file.LastWriteTime)
                    .Take(Convert.ToInt32(txtMaxRecord.Text));


                    using (StreamWriter writetext = new StreamWriter(outputDirectory))
                    {
                        writetext.Write("DateTime" + "\tFile Path" + Environment.NewLine);

                        foreach (var file in files)
                        {
                            if (!rbAllFileTypes.Checked)
                            {
                                foreach (var extension in FileExtensions())
                                {
                                    if (file.Extension.Contains(extension))
                                        writetext.Write(file.LastWriteTime + "\t" + file.FullName + Environment.NewLine);
                                }
                            }
                            else
                            {
                                writetext.Write(file.LastWriteTime + "\t" + file.FullName + Environment.NewLine);
                            }


                        }
                    }

                    MessageBox.Show("File created sucessfully."
                        + Environment.NewLine
                        + Environment.NewLine
                        + "Output Path : "
                        + outputDirectory
                        , "Sucess", MessageBoxButtons.OK, MessageBoxIcon.None);

                    ResetControls();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        private void rbFileTypes_CheckedChanged(object sender, EventArgs e)
        {
            ValidateFileTypes();
        }

        private void rbAllFileTypes_CheckedChanged(object sender, EventArgs e)
        {
            ValidateFileTypes();
        }

        private void txtLastModifiedDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtMaxRecord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        #region Private Methods
        private void ValidateFileTypes()
        {
            if (rbAllFileTypes.Checked)
            {
                chkAspx.Enabled = false;
                chkCS.Enabled = false;
                chkCss.Enabled = false;
                chkText.Enabled = false;
                chkDll.Enabled = false;
                chkHtml.Enabled = false;
            }
            else
            {
                chkAspx.Enabled = true;
                chkCS.Enabled = true;
                chkCss.Enabled = true;
                chkText.Enabled = true;
                chkDll.Enabled = true;
                chkHtml.Enabled = true;
            }
        }
        private void ResetControls()
        {
            txtFileName.Text = string.Empty;
            txtInputPath.Text = string.Empty;
            txtOutputPath.Text = string.Empty;
            rbFileTypes.Checked = true;
            rbOutputFileText.Checked = true;
            ValidateFileTypes();
        }
        private bool ValidateControls()
        {
            if (string.IsNullOrEmpty(txtInputPath.Text.Trim()))
            {
                MessageBox.Show("Input directory should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtOutputPath.Text.Trim()))
            {
                MessageBox.Show("Output directory should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtFileName.Text.Trim()))
            {
                MessageBox.Show("File name should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtLastModifiedDays.Text))
            {
                MessageBox.Show("Last modified in days should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(txtMaxRecord.Text))
            {
                MessageBox.Show("Max record should not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private List<string> FileExtensions()
        {
            List<string> extensions = new List<string>();
            if (rbFileTypes.Checked)
            {
                if (chkAspx.Checked)
                    extensions.Add(".aspx");
                if (chkCS.Checked)
                    extensions.Add(".cs");
                if (chkCss.Checked)
                    extensions.Add(".css");
                if (chkText.Checked)
                    extensions.Add(".txt");
                if (chkHtml.Checked)
                    extensions.Add(".html");
                if (chkDll.Checked)
                    extensions.Add(".dll");
            }
            return extensions;
        }
        #endregion
    }
}
