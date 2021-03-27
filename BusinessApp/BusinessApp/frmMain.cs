using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusinessApp
{
    public partial class frmMain : Form
    {
        #region INSTANCE VARIABLES

        BusinessAppDataContext badc;
        Dictionary<int, String> custDictionary;
        Dictionary<int, String> empDictionary;
        List<int> custIDList;
        List<int> empIDList;

        #endregion

        #region FORM LOAD

        public frmMain()
        {
            InitializeComponent();
            lblErrorSelectCust.Visible = false;
            badc = new BusinessAppDataContext();
            custDictionary = new Dictionary<int, String>();
            empDictionary = new Dictionary<int, String>();
            custIDList = new List<int>();
            empIDList = new List<int>();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            populateCustCmbBox();
            //populateEmployeeCmbBox();
        }

        #endregion

        #region EVENTS

        private void cmbBxExistCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxExistCust.SelectedIndex == 0)
            {
                txtBxNameCompany.Clear(); txtBxMiddleInit.Clear(); txtBxLastName.Clear();
                txtBxPhoneNum.Clear(); txtBxEmail.Clear();
                lblErrorSelectCust.Visible = true;
            }

            else 
            {
                //FIXME: The customer needs to be in a nested dictionary keyed with index, and then with cust id
                //       e.g. Dictionary<int comboBxIndex>, Dictionary<int customerId, customer name>
                var cu = from c in badc.tblCustomers
                         where c.Customer_ID == cmbBxExistCust.SelectedIndex
                         select c;
                
                txtBxNameCompany.Text = cu.FirstOrDefault().First_Name_OR_Company;
                txtBxMiddleInit.Text = cu.FirstOrDefault().Middle_Initial.ToString();
                txtBxLastName.Text = cu.FirstOrDefault().Last_Name;
                txtBxPhoneNum.Text = cu.FirstOrDefault().Phone_Number;
                txtBxEmail.Text = cu.FirstOrDefault().Email;
                lblErrorSelectCust.Visible = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPgEmpInfo"])
            {
                frmSecurityLogin fsl = new frmSecurityLogin(this);
                fsl.ShowDialog();
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmNewCustomer fnc = new frmNewCustomer(this);
            fnc.ShowDialog();
        }

        private void btnNewOrder_Click_1(object sender, EventArgs e)
        {
            if (!txtBxNameCompany.Text.Equals(""))
            {
                lblErrorSelectCust.Visible = false;

                frmNewOrder frmNO = new frmNewOrder(this, custIDList[cmbBxExistCust.SelectedIndex]);
                frmNO.ShowDialog();
            }
        }

        #endregion

        #region PRIVATE METHODS

        private void populateCustCmbBox()
        {
            cmbBxExistCust.Items.Add("-Choose Existing Customer-");
            custIDList.Add(0);

            var cust = from c in badc.tblCustomers
                       select c;

            foreach (var element in cust)
            {
                custIDList.Add(element.Customer_ID);
                cmbBxExistCust.Items.Add(element.First_Name_OR_Company + " " + element.Last_Name);
            }

            cmbBxExistCust.SelectedIndex = 1;
        }

        //TODO: Mimic populateCustCmbBox() and complete
        private void populateEmployeeCmbBox()
        {
            cmbBxCIExistEmp.Items.Add("-Select Employee-");
            
            var employee = from emp in badc.tblEmployees
                           select emp;

            foreach (var element in employee)
            {
                //empDictionary.Add(element.Employee_ID, element.First_Name + " " + element.Last_Name);
            }

            foreach (String s in empDictionary.Values)
            {
                //cmbBxCIExistEmp.Items.Add(s);
            }

            cmbBxCIExistEmp.SelectedIndex = 1;
        }

        #endregion

        #region PUBLIC METHODS

        internal void updateCmbBx()
        {
            cmbBxExistCust.Items.Clear();
            populateCustCmbBox();
        }

        internal void tabRedirect()
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPgCustomers"];
        }

        #endregion
    }
}