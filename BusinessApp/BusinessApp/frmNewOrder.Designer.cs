namespace BusinessApp
{
    partial class frmNewOrder
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
            this.lblNewOrdCustName = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.tabControlNewOrder = new System.Windows.Forms.TabControl();
            this.tbPgOrderSummary = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPgRepair = new System.Windows.Forms.TabPage();
            this.tbPgInstallUpgrade = new System.Windows.Forms.TabPage();
            this.tbPgNetworkService = new System.Windows.Forms.TabPage();
            this.tbPgWebService = new System.Windows.Forms.TabPage();
            this.tbPgDatabaseService = new System.Windows.Forms.TabPage();
            this.tbPgPurchase = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.chkBxBackedUpData = new System.Windows.Forms.CheckBox();
            this.chkBxPlzBackup = new System.Windows.Forms.CheckBox();
            this.chkBxNoBackup = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControlNewOrder.SuspendLayout();
            this.tbPgOrderSummary.SuspendLayout();
            this.tbPgRepair.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // lblNewOrdCustName
            // 
            this.lblNewOrdCustName.AutoSize = true;
            this.lblNewOrdCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewOrdCustName.Location = new System.Drawing.Point(170, 28);
            this.lblNewOrdCustName.Name = "lblNewOrdCustName";
            this.lblNewOrdCustName.Size = new System.Drawing.Size(109, 20);
            this.lblNewOrdCustName.TabIndex = 1;
            this.lblNewOrdCustName.Text = "<custName>";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(427, 28);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(88, 17);
            this.lblOrderDate.TabIndex = 4;
            this.lblOrderDate.Text = "<orderDate>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Order Date:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(395, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.Location = new System.Drawing.Point(176, 520);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(120, 30);
            this.btnSubmitOrder.TabIndex = 12;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tabControlNewOrder
            // 
            this.tabControlNewOrder.Controls.Add(this.tbPgOrderSummary);
            this.tabControlNewOrder.Controls.Add(this.tbPgRepair);
            this.tabControlNewOrder.Controls.Add(this.tbPgInstallUpgrade);
            this.tabControlNewOrder.Controls.Add(this.tbPgNetworkService);
            this.tabControlNewOrder.Controls.Add(this.tbPgWebService);
            this.tabControlNewOrder.Controls.Add(this.tbPgDatabaseService);
            this.tabControlNewOrder.Controls.Add(this.tbPgPurchase);
            this.tabControlNewOrder.Location = new System.Drawing.Point(22, 63);
            this.tabControlNewOrder.Name = "tabControlNewOrder";
            this.tabControlNewOrder.SelectedIndex = 0;
            this.tabControlNewOrder.Size = new System.Drawing.Size(640, 430);
            this.tabControlNewOrder.TabIndex = 21;
            // 
            // tbPgOrderSummary
            // 
            this.tbPgOrderSummary.Controls.Add(this.treeView1);
            this.tbPgOrderSummary.Controls.Add(this.label5);
            this.tbPgOrderSummary.Location = new System.Drawing.Point(4, 22);
            this.tbPgOrderSummary.Name = "tbPgOrderSummary";
            this.tbPgOrderSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgOrderSummary.Size = new System.Drawing.Size(632, 404);
            this.tbPgOrderSummary.TabIndex = 0;
            this.tbPgOrderSummary.Text = "Order Summary";
            this.tbPgOrderSummary.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Summary:";
            // 
            // tbPgRepair
            // 
            this.tbPgRepair.Controls.Add(this.label9);
            this.tbPgRepair.Controls.Add(this.textBox2);
            this.tbPgRepair.Controls.Add(this.label8);
            this.tbPgRepair.Controls.Add(this.textBox1);
            this.tbPgRepair.Controls.Add(this.chkBxNoBackup);
            this.tbPgRepair.Controls.Add(this.chkBxPlzBackup);
            this.tbPgRepair.Controls.Add(this.chkBxBackedUpData);
            this.tbPgRepair.Controls.Add(this.btnRemoveDevice);
            this.tbPgRepair.Controls.Add(this.btnAddDevice);
            this.tbPgRepair.Controls.Add(this.label7);
            this.tbPgRepair.Controls.Add(this.listView1);
            this.tbPgRepair.Controls.Add(this.label6);
            this.tbPgRepair.Controls.Add(this.comboBox3);
            this.tbPgRepair.Controls.Add(this.label3);
            this.tbPgRepair.Controls.Add(this.comboBox2);
            this.tbPgRepair.Controls.Add(this.label2);
            this.tbPgRepair.Controls.Add(this.comboBox1);
            this.tbPgRepair.Location = new System.Drawing.Point(4, 22);
            this.tbPgRepair.Name = "tbPgRepair";
            this.tbPgRepair.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgRepair.Size = new System.Drawing.Size(632, 404);
            this.tbPgRepair.TabIndex = 1;
            this.tbPgRepair.Text = "Repair";
            this.tbPgRepair.UseVisualStyleBackColor = true;
            // 
            // tbPgInstallUpgrade
            // 
            this.tbPgInstallUpgrade.Location = new System.Drawing.Point(4, 22);
            this.tbPgInstallUpgrade.Name = "tbPgInstallUpgrade";
            this.tbPgInstallUpgrade.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgInstallUpgrade.Size = new System.Drawing.Size(632, 404);
            this.tbPgInstallUpgrade.TabIndex = 2;
            this.tbPgInstallUpgrade.Text = "Install/Upgrade";
            this.tbPgInstallUpgrade.UseVisualStyleBackColor = true;
            // 
            // tbPgNetworkService
            // 
            this.tbPgNetworkService.Location = new System.Drawing.Point(4, 22);
            this.tbPgNetworkService.Name = "tbPgNetworkService";
            this.tbPgNetworkService.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgNetworkService.Size = new System.Drawing.Size(632, 404);
            this.tbPgNetworkService.TabIndex = 3;
            this.tbPgNetworkService.Text = "Network Service";
            this.tbPgNetworkService.UseVisualStyleBackColor = true;
            // 
            // tbPgWebService
            // 
            this.tbPgWebService.Location = new System.Drawing.Point(4, 22);
            this.tbPgWebService.Name = "tbPgWebService";
            this.tbPgWebService.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgWebService.Size = new System.Drawing.Size(632, 404);
            this.tbPgWebService.TabIndex = 4;
            this.tbPgWebService.Text = "Web Service";
            this.tbPgWebService.UseVisualStyleBackColor = true;
            // 
            // tbPgDatabaseService
            // 
            this.tbPgDatabaseService.Location = new System.Drawing.Point(4, 22);
            this.tbPgDatabaseService.Name = "tbPgDatabaseService";
            this.tbPgDatabaseService.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgDatabaseService.Size = new System.Drawing.Size(632, 404);
            this.tbPgDatabaseService.TabIndex = 5;
            this.tbPgDatabaseService.Text = "Database Service";
            this.tbPgDatabaseService.UseVisualStyleBackColor = true;
            // 
            // tbPgPurchase
            // 
            this.tbPgPurchase.Location = new System.Drawing.Point(4, 22);
            this.tbPgPurchase.Name = "tbPgPurchase";
            this.tbPgPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgPurchase.Size = new System.Drawing.Size(632, 404);
            this.tbPgPurchase.TabIndex = 6;
            this.tbPgPurchase.Text = "Purchase";
            this.tbPgPurchase.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(230, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Brand:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Device Model:";
            this.label3.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(447, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(161, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Device Type:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(24, 51);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(161, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 223);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(581, 155);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(86, 23);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(527, 365);
            this.treeView1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Repair Summary:";
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(261, 185);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(103, 23);
            this.btnAddDevice.TabIndex = 22;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.Location = new System.Drawing.Point(447, 185);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(103, 23);
            this.btnRemoveDevice.TabIndex = 23;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            // 
            // chkBxBackedUpData
            // 
            this.chkBxBackedUpData.AutoSize = true;
            this.chkBxBackedUpData.Location = new System.Drawing.Point(24, 78);
            this.chkBxBackedUpData.Name = "chkBxBackedUpData";
            this.chkBxBackedUpData.Size = new System.Drawing.Size(150, 17);
            this.chkBxBackedUpData.TabIndex = 24;
            this.chkBxBackedUpData.Text = "I have backed up my data";
            this.chkBxBackedUpData.UseVisualStyleBackColor = true;
            // 
            // chkBxPlzBackup
            // 
            this.chkBxPlzBackup.AutoSize = true;
            this.chkBxPlzBackup.Location = new System.Drawing.Point(404, 78);
            this.chkBxPlzBackup.Name = "chkBxPlzBackup";
            this.chkBxPlzBackup.Size = new System.Drawing.Size(162, 17);
            this.chkBxPlzBackup.TabIndex = 25;
            this.chkBxPlzBackup.Text = "I want all my data backed up";
            this.chkBxPlzBackup.UseVisualStyleBackColor = true;
            // 
            // chkBxNoBackup
            // 
            this.chkBxNoBackup.AutoSize = true;
            this.chkBxNoBackup.Location = new System.Drawing.Point(200, 78);
            this.chkBxNoBackup.Name = "chkBxNoBackup";
            this.chkBxNoBackup.Size = new System.Drawing.Size(182, 17);
            this.chkBxNoBackup.TabIndex = 26;
            this.chkBxNoBackup.Text = "I do not want my data backed up";
            this.chkBxNoBackup.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Operating System:";
            this.label8.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 42);
            this.textBox2.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Describe Issue:";
            this.label9.Visible = false;
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tabControlNewOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblNewOrdCustName);
            this.Controls.Add(this.label1);
            this.Name = "frmNewOrder";
            this.Text = "New Order";
            this.tabControlNewOrder.ResumeLayout(false);
            this.tbPgOrderSummary.ResumeLayout(false);
            this.tbPgOrderSummary.PerformLayout();
            this.tbPgRepair.ResumeLayout(false);
            this.tbPgRepair.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewOrdCustName;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.TabControl tabControlNewOrder;
        private System.Windows.Forms.TabPage tbPgOrderSummary;
        private System.Windows.Forms.TabPage tbPgRepair;
        private System.Windows.Forms.TabPage tbPgInstallUpgrade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tbPgNetworkService;
        private System.Windows.Forms.TabPage tbPgWebService;
        private System.Windows.Forms.TabPage tbPgDatabaseService;
        private System.Windows.Forms.TabPage tbPgPurchase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.CheckBox chkBxNoBackup;
        private System.Windows.Forms.CheckBox chkBxPlzBackup;
        private System.Windows.Forms.CheckBox chkBxBackedUpData;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}