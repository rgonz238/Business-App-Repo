using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BusinessApp
{
    public partial class frmSecurityLogin : Form
    {
        #region INSTANCE VARIABLES

        frmMain fmain;

        #endregion

        #region CONSTRUCTORS

        public frmSecurityLogin(frmMain fm)
        {
            InitializeComponent();
            fmain = fm;
        }

        #endregion

        #region EVENTS

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //TODO: This needs to be much more secure (encrypted, hidden, etc.)
            if (txtBxUsername.Text == "rgonzales238" && txtBxPassword.Text == "BOBOSO")
            {
                MessageBox.Show("Username and password correct!!!",
                    "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                this.Dispose();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Username or password incorrect!!!",
                    "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmSecurityLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                fmain.tabRedirect();
            }
        }

        #endregion
    }
}