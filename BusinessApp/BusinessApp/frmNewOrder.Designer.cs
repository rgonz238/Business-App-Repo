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
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.chkBxRepair = new System.Windows.Forms.CheckBox();
            this.chkBxInstallUpgrade = new System.Windows.Forms.CheckBox();
            this.chkBxNetwork = new System.Windows.Forms.CheckBox();
            this.chkBxWeb = new System.Windows.Forms.CheckBox();
            this.chkBxDatabase = new System.Windows.Forms.CheckBox();
            this.chkBxPurchase = new System.Windows.Forms.CheckBox();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Service Type:";
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
            // txtBxInfo
            // 
            this.txtBxInfo.Location = new System.Drawing.Point(112, 169);
            this.txtBxInfo.Multiline = true;
            this.txtBxInfo.Name = "txtBxInfo";
            this.txtBxInfo.Size = new System.Drawing.Size(476, 216);
            this.txtBxInfo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(395, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(176, 404);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 30);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Information:";
            // 
            // chkBxRepair
            // 
            this.chkBxRepair.AutoSize = true;
            this.chkBxRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxRepair.Location = new System.Drawing.Point(136, 82);
            this.chkBxRepair.Name = "chkBxRepair";
            this.chkBxRepair.Size = new System.Drawing.Size(63, 17);
            this.chkBxRepair.TabIndex = 15;
            this.chkBxRepair.Text = "Repair";
            this.chkBxRepair.UseVisualStyleBackColor = true;
            this.chkBxRepair.CheckedChanged += new System.EventHandler(this.chkBxRepair_CheckedChanged);
            // 
            // chkBxInstallUpgrade
            // 
            this.chkBxInstallUpgrade.AutoSize = true;
            this.chkBxInstallUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxInstallUpgrade.Location = new System.Drawing.Point(290, 81);
            this.chkBxInstallUpgrade.Name = "chkBxInstallUpgrade";
            this.chkBxInstallUpgrade.Size = new System.Drawing.Size(114, 17);
            this.chkBxInstallUpgrade.TabIndex = 16;
            this.chkBxInstallUpgrade.Text = "Install/Upgrade";
            this.chkBxInstallUpgrade.UseVisualStyleBackColor = true;
            this.chkBxInstallUpgrade.CheckedChanged += new System.EventHandler(this.chkBxInstallUpgrade_CheckedChanged);
            // 
            // chkBxNetwork
            // 
            this.chkBxNetwork.AutoSize = true;
            this.chkBxNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxNetwork.Location = new System.Drawing.Point(453, 82);
            this.chkBxNetwork.Name = "chkBxNetwork";
            this.chkBxNetwork.Size = new System.Drawing.Size(120, 17);
            this.chkBxNetwork.TabIndex = 17;
            this.chkBxNetwork.Text = "Network Service";
            this.chkBxNetwork.UseVisualStyleBackColor = true;
            this.chkBxNetwork.CheckedChanged += new System.EventHandler(this.chkBxNetwork_CheckedChanged);
            // 
            // chkBxWeb
            // 
            this.chkBxWeb.AutoSize = true;
            this.chkBxWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxWeb.Location = new System.Drawing.Point(136, 119);
            this.chkBxWeb.Name = "chkBxWeb";
            this.chkBxWeb.Size = new System.Drawing.Size(99, 17);
            this.chkBxWeb.TabIndex = 18;
            this.chkBxWeb.Text = "Web Service";
            this.chkBxWeb.UseVisualStyleBackColor = true;
            this.chkBxWeb.CheckedChanged += new System.EventHandler(this.chkBxWeb_CheckedChanged);
            // 
            // chkBxDatabase
            // 
            this.chkBxDatabase.AutoSize = true;
            this.chkBxDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxDatabase.Location = new System.Drawing.Point(290, 119);
            this.chkBxDatabase.Name = "chkBxDatabase";
            this.chkBxDatabase.Size = new System.Drawing.Size(127, 17);
            this.chkBxDatabase.TabIndex = 19;
            this.chkBxDatabase.Text = "Database Service";
            this.chkBxDatabase.UseVisualStyleBackColor = true;
            this.chkBxDatabase.CheckedChanged += new System.EventHandler(this.chkBxDatabase_CheckedChanged);
            // 
            // chkBxPurchase
            // 
            this.chkBxPurchase.AutoSize = true;
            this.chkBxPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxPurchase.Location = new System.Drawing.Point(453, 119);
            this.chkBxPurchase.Name = "chkBxPurchase";
            this.chkBxPurchase.Size = new System.Drawing.Size(79, 17);
            this.chkBxPurchase.TabIndex = 20;
            this.chkBxPurchase.Text = "Purchase";
            this.chkBxPurchase.UseVisualStyleBackColor = true;
            this.chkBxPurchase.CheckedChanged += new System.EventHandler(this.chkBxPurchase_CheckedChanged);
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 458);
            this.Controls.Add(this.chkBxPurchase);
            this.Controls.Add(this.chkBxDatabase);
            this.Controls.Add(this.chkBxWeb);
            this.Controls.Add(this.chkBxNetwork);
            this.Controls.Add(this.chkBxInstallUpgrade);
            this.Controls.Add(this.chkBxRepair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNewOrdCustName);
            this.Controls.Add(this.label1);
            this.Name = "frmNewOrder";
            this.Text = "frmNewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNewOrdCustName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBxRepair;
        private System.Windows.Forms.CheckBox chkBxInstallUpgrade;
        private System.Windows.Forms.CheckBox chkBxNetwork;
        private System.Windows.Forms.CheckBox chkBxWeb;
        private System.Windows.Forms.CheckBox chkBxDatabase;
        private System.Windows.Forms.CheckBox chkBxPurchase;
    }
}