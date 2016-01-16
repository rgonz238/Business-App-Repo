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
    public partial class frmNewCustomer : Form
    {
        #region INSTANCE VARIABLES

        frmMain form;
        int rowC;

        #endregion

        #region CONSTRUCTORS

        public frmNewCustomer(frmMain form)
        {    
            InitializeComponent();
            this.form = form;
            rowC = 0;
        }

        #endregion

        #region EVENTS

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radBtnFirstName.Checked)
            {
                if (txtBxNameCompany.Text == "" || txtBxLastName.Text == "" ||
                        txtBxPhoneNum.Text == "")
                {
                    MessageBox.Show("FirstName/Company, LastName," +
                    " and Phone Number box must have a value !",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                }

                else 
                {
                    insertNewCust();

                    MessageBox.Show("Insert new Customer successful !",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                   
                    this.Close();
                }
            }
            else 
            {
                if (txtBxNameCompany.Text == "" || txtBxPhoneNum.Text == "")
                {
                    MessageBox.Show("FirstName/Company," +
                    " and Phone Number must have a value !",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                }

                else 
                {
                    insertNewCust();

                    MessageBox.Show("Insert new Customer successful !",
                        "Message", MessageBoxButtons.OK, MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1);
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            //frmAddCustItems fac = new frmAddCustItems(this);
            //fac.Show();
        }

        #endregion

        #region PRIVATE METHODS

        private void insertNewCust()
        {
            BusinessAppDataContext badc = new BusinessAppDataContext();
            tblCustomer cust = new tblCustomer();

            cust.First_Name_OR_Company = txtBxNameCompany.Text;

            try {cust.Middle_Initial = Convert.ToChar(txtBxMiddleInit.Text);}
            catch (FormatException) { cust.Middle_Initial = null; }

            try {cust.Last_Name = txtBxLastName.Text;}
            catch (FormatException) { cust.Last_Name = null; }

            try {cust.Email = txtBxEmail.Text;}
            catch (FormatException) { cust.Email = null; }

            cust.Phone_Number = txtBxPhoneNum.Text;

            badc.tblCustomers.InsertOnSubmit(cust);
            badc.SubmitChanges();

            form.updateCmbBx();
        }

        #endregion

        #region PUBLIC METHODS

        internal void passItemsArray(string [,] ia, int rc)
        {
            string[,] itmarr = ia;
            rowC = rc;

            //dgvItemsDisplayed.Rows.Clear();

            for (int x = 0; x < rowC; x++)
            {
                string [] temp = new string [4];

                for (int y = 0; y < 4; y++)
                {
                    temp[y] = itmarr[x, y];
                }

                //dgvItemsDisplayed.Rows.Add(temp);
            }
        }

        #endregion
    }
}