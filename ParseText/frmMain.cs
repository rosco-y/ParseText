using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseText
{
    public partial class frmMain : Form
    {
        string _pathToFile = string.Empty;
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdSelectFile_Click(object sender, EventArgs e)
        {            
            dlgFilePicker.ShowDialog(this);
            if (dlgFilePicker.CheckFileExists)
            {
                _pathToFile = dlgFilePicker.FileName;
                txtFileName.Text = System.IO.Path.GetFileNameWithoutExtension(_pathToFile);
                cmdParseFile.Enabled = true;
            }
            else
            {
                cmdParseFile.Enabled = false;
                MessageBox.Show(this, "File not Found.", "Error");
            }
        }
    }
}
