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
    public partial class frmNewOrder : Form
    {
        #region INSTANCE VARIABLES

        frmMain form; //main form reference
        frmAddCustItems formAddItems; //add cust items form reference
        BusinessAppDataContext badc; //database context
        tblOrder newOrder; //database object - new order
        List<int> serviceTypeIDList; 
        DateTime currentDateTime; //current date/time
        Dictionary<int, tblOrder_Item> productID_OrderItemsDictExist;

        int orderID;
        int customerID;

        #endregion

        #region CONSTRUCTORS

        public frmNewOrder(frmMain form, int customerID)
        {
            InitializeComponent();

            this.form = form;
            formAddItems = new frmAddCustItems(this);
            this.customerID = customerID;
            currentDateTime = DateTime.Now;
            serviceTypeIDList = new List<int>();
            newOrder = new tblOrder();
            productID_OrderItemsDictExist = new Dictionary<int, tblOrder_Item>();

            init();
        }

        #endregion

        #region EVENTS

        private void chkBxRepair_CheckedChanged(object sender, EventArgs e)
        {
            //    <----------CONTINUE HERE------------->

            //TODO: create new form that will allow user to select hours, days,
                    //years, etc. and input how many of each, it will also initialize the
                    //the combo box with the corresponding checked check box
        }

        private void chkBxInstallUpgrade_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBxNetwork_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBxWeb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBxDatabase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBxPurchase_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxPurchase.Checked == true)
            {
                formAddItems.setOrderListItems(productID_OrderItemsDictExist);
                formAddItems.ShowDialog();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //TODO: Somewhere in here call stored procedure that will remove items
            //      from tblProductItems and change quantities accordingly
        }
       
        #endregion

        #region PRIVATE METHODS

        private void init()
        {
            badc = new BusinessAppDataContext();

            //initialize customer name label
            var cu = from c in badc.tblCustomers
                     where c.Customer_ID == customerID
                     select c;

            lblNewOrdCustName.Text = cu.FirstOrDefault().First_Name_OR_Company + " " +
                cu.FirstOrDefault().Last_Name;
        }

        private void buildOrderInfoMessage()
        {
            //TODO: 
        }

        #endregion

        #region PUBLIC METHODS

        public void setOrderListItems(Dictionary<int, tblOrder_Item> productID_OrderItemsDictExist)
        {
            this.productID_OrderItemsDictExist = productID_OrderItemsDictExist;
            buildOrderInfoMessage();
        }

        #endregion
    }
}


/*MessageBox.Show("testing stuff",
                    "test check", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);*/