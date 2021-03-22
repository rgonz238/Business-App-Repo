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
            this.tbPgRepair = new System.Windows.Forms.TabPage();
            this.tbPgInstallUpgrade = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxInfo = new System.Windows.Forms.TextBox();
            this.tbPgNetworkService = new System.Windows.Forms.TabPage();
            this.tbPgWebService = new System.Windows.Forms.TabPage();
            this.tbPgDatabaseService = new System.Windows.Forms.TabPage();
            this.tbPgPurchase = new System.Windows.Forms.TabPage();
            this.tabControlNewOrder.SuspendLayout();
            this.tbPgOrderSummary.SuspendLayout();
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
            this.btnCancel.Location = new System.Drawing.Point(341, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitOrder.Location = new System.Drawing.Point(122, 417);
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
            this.tabControlNewOrder.Location = new System.Drawing.Point(12, 70);
            this.tabControlNewOrder.Name = "tabControlNewOrder";
            this.tabControlNewOrder.SelectedIndex = 0;
            this.tabControlNewOrder.Size = new System.Drawing.Size(588, 330);
            this.tabControlNewOrder.TabIndex = 21;
            // 
            // tbPgOrderSummary
            // 
            this.tbPgOrderSummary.Controls.Add(this.label5);
            this.tbPgOrderSummary.Controls.Add(this.txtBxInfo);
            this.tbPgOrderSummary.Location = new System.Drawing.Point(4, 22);
            this.tbPgOrderSummary.Name = "tbPgOrderSummary";
            this.tbPgOrderSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgOrderSummary.Size = new System.Drawing.Size(580, 304);
            this.tbPgOrderSummary.TabIndex = 0;
            this.tbPgOrderSummary.Text = "Order Summary";
            this.tbPgOrderSummary.UseVisualStyleBackColor = true;
            // 
            // tbPgRepair
            // 
            this.tbPgRepair.Location = new System.Drawing.Point(4, 22);
            this.tbPgRepair.Name = "tbPgRepair";
            this.tbPgRepair.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgRepair.Size = new System.Drawing.Size(580, 408);
            this.tbPgRepair.TabIndex = 1;
            this.tbPgRepair.Text = "Repair";
            this.tbPgRepair.UseVisualStyleBackColor = true;
            // 
            // tbPgInstallUpgrade
            // 
            this.tbPgInstallUpgrade.Location = new System.Drawing.Point(4, 22);
            this.tbPgInstallUpgrade.Name = "tbPgInstallUpgrade";
            this.tbPgInstallUpgrade.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgInstallUpgrade.Size = new System.Drawing.Size(580, 408);
            this.tbPgInstallUpgrade.TabIndex = 2;
            this.tbPgInstallUpgrade.Text = "Install/Upgrade";
            this.tbPgInstallUpgrade.UseVisualStyleBackColor = true;
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
            // txtBxInfo
            // 
            this.txtBxInfo.Location = new System.Drawing.Point(86, 22);
            this.txtBxInfo.Multiline = true;
            this.txtBxInfo.Name = "txtBxInfo";
            this.txtBxInfo.Size = new System.Drawing.Size(476, 264);
            this.txtBxInfo.TabIndex = 18;
            // 
            // tbPgNetworkService
            // 
            this.tbPgNetworkService.Location = new System.Drawing.Point(4, 22);
            this.tbPgNetworkService.Name = "tbPgNetworkService";
            this.tbPgNetworkService.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgNetworkService.Size = new System.Drawing.Size(580, 408);
            this.tbPgNetworkService.TabIndex = 3;
            this.tbPgNetworkService.Text = "Network Service";
            this.tbPgNetworkService.UseVisualStyleBackColor = true;
            // 
            // tbPgWebService
            // 
            this.tbPgWebService.Location = new System.Drawing.Point(4, 22);
            this.tbPgWebService.Name = "tbPgWebService";
            this.tbPgWebService.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgWebService.Size = new System.Drawing.Size(580, 408);
            this.tbPgWebService.TabIndex = 4;
            this.tbPgWebService.Text = "Web Service";
            this.tbPgWebService.UseVisualStyleBackColor = true;
            // 
            // tbPgDatabaseService
            // 
            this.tbPgDatabaseService.Location = new System.Drawing.Point(4, 22);
            this.tbPgDatabaseService.Name = "tbPgDatabaseService";
            this.tbPgDatabaseService.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgDatabaseService.Size = new System.Drawing.Size(580, 408);
            this.tbPgDatabaseService.TabIndex = 5;
            this.tbPgDatabaseService.Text = "Database Service";
            this.tbPgDatabaseService.UseVisualStyleBackColor = true;
            // 
            // tbPgPurchase
            // 
            this.tbPgPurchase.Location = new System.Drawing.Point(4, 22);
            this.tbPgPurchase.Name = "tbPgPurchase";
            this.tbPgPurchase.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgPurchase.Size = new System.Drawing.Size(580, 408);
            this.tbPgPurchase.TabIndex = 6;
            this.tbPgPurchase.Text = "Purchase";
            this.tbPgPurchase.UseVisualStyleBackColor = true;
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 458);
            this.Controls.Add(this.tabControlNewOrder);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblNewOrdCustName);
            this.Controls.Add(this.label1);
            this.Name = "frmNewOrder";
            this.Text = "frmNewOrder";
            this.tabControlNewOrder.ResumeLayout(false);
            this.tbPgOrderSummary.ResumeLayout(false);
            this.tbPgOrderSummary.PerformLayout();
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
        private System.Windows.Forms.TextBox txtBxInfo;
        private System.Windows.Forms.TabPage tbPgNetworkService;
        private System.Windows.Forms.TabPage tbPgWebService;
        private System.Windows.Forms.TabPage tbPgDatabaseService;
        private System.Windows.Forms.TabPage tbPgPurchase;
    }
}