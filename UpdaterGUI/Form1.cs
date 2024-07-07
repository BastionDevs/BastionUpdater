using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpdaterGUI
{
    public partial class Form1 : Form
    {
        public bool InstallInProgress = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (InstallInProgress)
            {
                MessageBox.Show("An update is still in progress! Wait until all updates finish before exiting.", "Update in progress", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            } else
            {
                Environment.Exit(0);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            InstallInProgress = true;
        }

        private void radioButtonNotSkype_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNotSkype.Checked)
            {
                radioButtonBastionLauncher.Checked = false;
                radioButtonFortressAPI.Checked = false;
                radioButtonFSDKCS.Checked = false;
                radioButtonFSDKJS.Checked = false;
                radioButtonFSDKPHP.Checked = false;
                radioButtonFSDKPython.Checked = false;
                radioButtonLibraryManager.Checked = false;
            }
        }

        private void radioButtonBastionLauncher_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBastionLauncher.Checked)
            {
                radioButtonNotSkype.Checked = false;
                radioButtonFortressAPI.Checked = false;
                radioButtonFSDKCS.Checked = false;
                radioButtonFSDKJS.Checked = false;
                radioButtonFSDKPHP.Checked = false;
                radioButtonFSDKPython.Checked = false;
                radioButtonLibraryManager.Checked = false;
            }
        }

        private void radioButtonFortressAPI_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFortressAPI.Checked)
            {
                radioButtonNotSkype.Checked = false;
                radioButtonBastionLauncher.Checked = false;
                radioButtonFSDKCS.Checked = false;
                radioButtonFSDKJS.Checked = false;
                radioButtonFSDKPHP.Checked = false;
                radioButtonFSDKPython.Checked = false;
                radioButtonLibraryManager.Checked = false;
            }
        }

        private void radioButtonFSDKCS_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFSDKCS.Checked)
            {
                radioButtonNotSkype.Checked = false;
                radioButtonBastionLauncher.Checked = false;
                radioButtonFortressAPI.Checked = false;
                radioButtonFSDKJS.Checked = false;
                radioButtonFSDKPHP.Checked = false;
                radioButtonFSDKPython.Checked = false;
                radioButtonLibraryManager.Checked = false;
            }
        }

        private void radioButtonFSDKJS_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFSDKJS.Checked)
            {
                radioButtonNotSkype.Checked = false;
                radioButtonBastionLauncher.Checked = false;
                radioButtonFSDKCS.Checked = false;
                radioButtonFortressAPI.Checked = false;
                radioButtonFSDKPHP.Checked = false;
                radioButtonFSDKPython.Checked = false;
                radioButtonLibraryManager.Checked = false;
            }
        }

        private void radioButtonFSDKPython_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFSDKPython.Checked)
            {
                radioButtonNotSkype.Checked = false;
                radioButtonBastionLauncher.Checked = false;
                radioButtonFSDKCS.Checked = false;
                radioButtonFSDKJS.Checked = false;
                radioButtonFSDKPHP.Checked = false;
                radioButtonFortressAPI.Checked = false;
                radioButtonLibraryManager.Checked = false;
            }
        }

        private void radioButtonLibraryManager_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLibraryManager.Checked)
            {
                radioButtonNotSkype.Checked = false;
                radioButtonBastionLauncher.Checked = false;
                radioButtonFSDKCS.Checked = false;
                radioButtonFSDKJS.Checked = false;
                radioButtonFSDKPHP.Checked = false;
                radioButtonFSDKPython.Checked = false;
                radioButtonFortressAPI.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Check if app is installed and if so see if an update is available.
        }
    }
}
