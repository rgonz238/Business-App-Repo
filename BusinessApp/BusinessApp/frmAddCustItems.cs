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
    public partial class frmAddCustItems : Form
    {
        #region INSTANCE VARIABLES

        const int QUANTITY_CELL_NUM = 3;  //quantity cell index in dgv

        BusinessAppDataContext badc; //data base context
        frmNewOrder form;  //new order form reference

        List<int> brandsIndexesList;  //index list for combo box
        List<int> productsIndexesList; //index list for combo box

        List<int> itemsDGVIndexesList; //index list for items in dgv

        Dictionary<int, tblOrder_Item> productID_OrderItemsDict; 
        Dictionary<int, tblOrder_Item> productID_OrderItemsDictExist;
        //Dictionary<int, tblOrder_Item> productID_OrderItemsDictTemp; 

        Dictionary<int, int> productID_QuantityDict;

        #endregion

        #region CONSTRUCTORS

        public frmAddCustItems(frmNewOrder form)
        {
            InitializeComponent();

            badc = new BusinessAppDataContext();  //initialize db context
            this.form = form;  //assign form reference
            //this.orderID = orderID;

            brandsIndexesList = new List<int>(); 
            productsIndexesList = new List<int>();
            itemsDGVIndexesList = new List<int>(); 

            productID_QuantityDict = new Dictionary<int, int>();
            productID_OrderItemsDict = new Dictionary<int, tblOrder_Item>();
            //productID_OrderItemsDictTemp = new Dictionary<int, tblOrder_Item>(); 

            cmbBxBrand.Items.Clear();  //clear brand combo box
            cmbBxBrand.Items.Add("--Choose Brand--"); //add first entry in combo box
            cmbBxBrand.SelectedIndex = 0;  //set selected index to 0

            brandsIndexesList.Add(0); //add 0 to brand indexes list

            cmbBxProducts.Enabled = false; //disable products combo box

            dgvItems.Rows.Clear();  //clear data grid view 

            //query for list of brands
            var brands = from table in badc.tblProductBrands select table;

            foreach (var element in brands) 
            {
                cmbBxBrand.Items.Add(element.Brand_Name); //add brands to combo box
                brandsIndexesList.Add(element.Brand_ID);  //add indexes to list
            }

            //query for list of all products
            var products = from table in badc.tblProductItems select table;

            foreach (var element in products)
            {
                //add product ids and quantities to list
                productID_QuantityDict.Add(element.Product_ID, element.Quantity);
            }
        }

        #endregion

        #region EVENTS

        private void cmbBxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxBrand.SelectedIndex != 0) //a selection is made other than the first entry
            {
                cmbBxProducts.Enabled = true;  //enable combo box for product
                cmbBxProducts.Items.Clear();   //clear the combo box
                cmbBxProducts.Items.Add("--Choose Product--");  //add title entry to combo box
                cmbBxProducts.SelectedIndex = 0;  //add 0 index for title entry

                productsIndexesList.Clear();  //clear product index list
                productsIndexesList.Add(0);   //add 0 to product index list for title entry

                //query products of corresponding brand
                var models = from table in badc.tblProductItems  
                             where table.Brand_ID == brandsIndexesList[cmbBxBrand.SelectedIndex]
                             select table;

                foreach (var element in models)
                {
                    if (element.Is_In_Stock) //only load if product is in stock
                    {
                        cmbBxProducts.Items.Add(element.Model); //add product model to combo box
                        productsIndexesList.Add(element.Product_ID); //add product id to list
                    }
                }
            }
            else //title entry in combo box is chosen
                cmbBxProducts.Enabled = false; //disable products combo box
        }

        private void cmbBxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxProducts.SelectedIndex != 0) //entry other than title entry is selected
            {
                //query product of selected combo box entry
                var product = from table in badc.tblProductItems 
                            where table.Product_ID == productsIndexesList[cmbBxProducts.SelectedIndex]
                            select table;

                //display comments on product (if any)
                txtBxComments.Text = product.FirstOrDefault().Comments;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isAdded = false;
            int tmpProdID = 0;
            int outValue; //trygetvalue output value (qty in stock)

            if (cmbBxBrand.SelectedIndex == 0 || cmbBxProducts.SelectedIndex == 0)
            {
                MessageBox.Show("Select brand and model!!!",
                   "Add Items Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1);
            }
            else //brand, model, and quantity is selected
            {
                //query selected brand
                var brand = from table in badc.tblProductBrands
                            where table.Brand_ID == brandsIndexesList[cmbBxBrand.SelectedIndex]
                            select table;

                //query selected product
                var product = from table in badc.tblProductItems
                            where table.Product_ID == productsIndexesList[cmbBxProducts.SelectedIndex]
                            select table;

                //retrieve quantity value for selected product
                productID_QuantityDict.TryGetValue(product.FirstOrDefault().Product_ID, out outValue);
                
                //check if quantity of product desired is valid
                if (Convert.ToInt32(numUpDownQuantity.Value) > outValue)
                {
                    MessageBox.Show("Insufficient quantity!!!",
                       "Add Items Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button1);
                }
                else //quantity desired is valid
                {
                    //check if item has already been added
                    foreach (int num in productID_OrderItemsDict.Keys)
                    {
                        if (num == product.FirstOrDefault().Product_ID)
                        { 
                            isAdded = true;
                            tmpProdID = num;
                            break;
                        }
                    }

                    if (isAdded)
                    {
                        MessageBox.Show("Item already added! Quantity will be adjusted!",
                        "Add Items Info", MessageBoxButtons.OK, MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);

                        //add qty to item qty/adjust quantity list
                        productID_OrderItemsDict[tmpProdID].Quantity += Convert.ToInt32(numUpDownQuantity.Value);
                        productID_QuantityDict[product.FirstOrDefault().Product_ID] -= Convert.ToInt32(numUpDownQuantity.Value);

                        //update quantity on single row in dgv
                        dgvItems.Rows[itemsDGVIndexesList.IndexOf(tmpProdID)].Cells[QUANTITY_CELL_NUM].Value = 
                            productID_OrderItemsDict[tmpProdID].Quantity;
                    }
                    else //item hasn't been added
                    {
                        //create new db order item
                        tblOrder_Item item = new tblOrder_Item();

                        //set corresponding data fields into new order item
                        item.Model = product.FirstOrDefault().Model;
                        item.Serial_Number = product.FirstOrDefault().Serial_Number;
                        item.Price = product.FirstOrDefault().Price;
                        item.Quantity = Convert.ToInt32(numUpDownQuantity.Value);
                        item.Comments = product.FirstOrDefault().Comments;
                        item.Type_ID = product.FirstOrDefault().Type_ID;
                        item.Brand_ID = product.FirstOrDefault().Brand_ID;

                        //add product id and order item into dictionary
                        productID_OrderItemsDict.Add(product.FirstOrDefault().Product_ID, item);

                        //adjust running quantity in prod id/quantity dictionary
                        productID_QuantityDict[product.FirstOrDefault().Product_ID] -= item.Quantity;

                        //add product id to list for dgv indexes
                        itemsDGVIndexesList.Add(product.FirstOrDefault().Product_ID);

                        //build string to add item to data grid view
                        String[] row = new String[] 
                        { 
                            brand.FirstOrDefault().Brand_Name, product.FirstOrDefault().Model, 
                            product.FirstOrDefault().Price.ToString("C") + " (ea.)", 
                            Convert.ToInt32(numUpDownQuantity.Value).ToString()
                        };

                        //add item to data grid view
                        dgvItems.Rows.Add(row);
                    }
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                tblOrder_Item tmp_item = new tblOrder_Item();
                int tmp_prod_id;

                tmp_item = productID_OrderItemsDict.ElementAt(dgvItems.CurrentRow.Index).Value;
                tmp_prod_id = productID_OrderItemsDict.ElementAt(dgvItems.CurrentRow.Index).Key;

                productID_QuantityDict[tmp_prod_id] += tmp_item.Quantity;
                productID_OrderItemsDict.Remove(tmp_prod_id);
                itemsDGVIndexesList.Remove(tmp_prod_id);

                //remove selected dgv row
                dgvItems.Rows.RemoveAt(dgvItems.CurrentRow.Index);
            }
            else //row count <= 0
            {
                MessageBox.Show("No items to remove!!!",
                       "Remove Items Error", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button1);
            }
        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            form.setOrderListItems(productID_OrderItemsDict); //pass items dictionary to new order form

            this.Hide(); //close window
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            form.setOrderListItems(productID_OrderItemsDictExist); //send existing item dictionary back to new order form
            this.Hide();
        }

        private void frmAddCustItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                form.setOrderListItems(productID_OrderItemsDictExist); //send existing item dictionary back to new order form
                this.Hide();
            }
        }

        #endregion

        #region PUBLIC METHODS

        public void setOrderListItems(Dictionary<int, tblOrder_Item> productID_OrderItemsDictExist)
        {
            this.productID_OrderItemsDictExist = productID_OrderItemsDictExist;

            //create deep copy in order to not disturb other dictionary data
            productID_OrderItemsDict = productID_OrderItemsDictExist.ToDictionary(entry => entry.Key, entry => entry.Value);
            productID_OrderItemsDict.Clear();

            dgvItems.Rows.Clear();
            itemsDGVIndexesList.Clear();
            cloneDictionary(this.productID_OrderItemsDictExist, productID_OrderItemsDict);
            loadDGV();
        }

        #endregion

        #region PRIVATE METHODS

        void loadDGV()
        {
            foreach (var element in productID_OrderItemsDict)
            {
                var brand = from brands in badc.tblProductBrands
                            where brands.Brand_ID == element.Value.Brand_ID
                         select brands;

                String[] row = new String[] 
                        { 
                            brand.FirstOrDefault().Brand_Name, element.Value.Model, 
                            element.Value.Price.ToString("C") + " (ea.)", 
                            element.Value.Quantity.ToString()
                        };

                dgvItems.Rows.Add(row);
                itemsDGVIndexesList.Add(element.Key);
            }
        }

        void cloneDictionary(Dictionary<int, tblOrder_Item> initial,
            Dictionary<int, tblOrder_Item> target)
        {
            foreach (var element in initial)
            {
                target.Add(element.Key, element.Value);
            }
        }

        #endregion
    }
}