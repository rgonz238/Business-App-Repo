namespace BusinessApp
{
    partial class frmMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPgCustomers = new System.Windows.Forms.TabPage();
            this.lblErrorSelectCust = new System.Windows.Forms.Label();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.cmbBxExistCust = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxMiddleInit = new System.Windows.Forms.TextBox();
            this.txtBxPhoneNum = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxNameCompany = new System.Windows.Forms.TextBox();
            this.tabPgOrders = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPgEmpInfo = new System.Windows.Forms.TabPage();
            this.cmbBxCIExistEmp = new System.Windows.Forms.ComboBox();
            this.btnCISubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radBtnCINewEmployee = new System.Windows.Forms.RadioButton();
            this.radBtnCIExistEmployee = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbBxCIDepartment = new System.Windows.Forms.ComboBox();
            this.chkBxCIIsSupervisor = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbBxCIDriversState = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mskTxtBxCISSN = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBxCIState = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxCIMiddleInit = new System.Windows.Forms.TextBox();
            this.txtBxCILastName = new System.Windows.Forms.TextBox();
            this.txtBxCIAddress = new System.Windows.Forms.TextBox();
            this.txtBxCICity = new System.Windows.Forms.TextBox();
            this.txtBxCIZipCode = new System.Windows.Forms.TextBox();
            this.txtBxCIPhoneNum = new System.Windows.Forms.TextBox();
            this.txtBxCIDriversLic = new System.Windows.Forms.TextBox();
            this.txtBxCIFirstName = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPgCustomers.SuspendLayout();
            this.tabPgOrders.SuspendLayout();
            this.tabPgEmpInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPgCustomers);
            this.tabControl1.Controls.Add(this.tabPgOrders);
            this.tabControl1.Controls.Add(this.tabPgEmpInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(588, 434);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPgCustomers
            // 
            this.tabPgCustomers.Controls.Add(this.lblErrorSelectCust);
            this.tabPgCustomers.Controls.Add(this.btnNewOrder);
            this.tabPgCustomers.Controls.Add(this.btnNewCustomer);
            this.tabPgCustomers.Controls.Add(this.cmbBxExistCust);
            this.tabPgCustomers.Controls.Add(this.label5);
            this.tabPgCustomers.Controls.Add(this.label4);
            this.tabPgCustomers.Controls.Add(this.label3);
            this.tabPgCustomers.Controls.Add(this.label2);
            this.tabPgCustomers.Controls.Add(this.label1);
            this.tabPgCustomers.Controls.Add(this.txtBxLastName);
            this.tabPgCustomers.Controls.Add(this.txtBxMiddleInit);
            this.tabPgCustomers.Controls.Add(this.txtBxPhoneNum);
            this.tabPgCustomers.Controls.Add(this.txtBxEmail);
            this.tabPgCustomers.Controls.Add(this.txtBxNameCompany);
            this.tabPgCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabPgCustomers.Name = "tabPgCustomers";
            this.tabPgCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgCustomers.Size = new System.Drawing.Size(580, 408);
            this.tabPgCustomers.TabIndex = 0;
            this.tabPgCustomers.Text = "Customers";
            this.tabPgCustomers.UseVisualStyleBackColor = true;
            // 
            // lblErrorSelectCust
            // 
            this.lblErrorSelectCust.AutoSize = true;
            this.lblErrorSelectCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSelectCust.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSelectCust.Location = new System.Drawing.Point(82, 60);
            this.lblErrorSelectCust.Name = "lblErrorSelectCust";
            this.lblErrorSelectCust.Size = new System.Drawing.Size(194, 17);
            this.lblErrorSelectCust.TabIndex = 15;
            this.lblErrorSelectCust.Text = "Please select a customer!";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Location = new System.Drawing.Point(206, 278);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(124, 36);
            this.btnNewOrder.TabIndex = 14;
            this.btnNewOrder.Text = "New Order...";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click_1);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(375, 25);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(103, 23);
            this.btnNewCustomer.TabIndex = 13;
            this.btnNewCustomer.Text = "New Customer...";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // cmbBxExistCust
            // 
            this.cmbBxExistCust.FormattingEnabled = true;
            this.cmbBxExistCust.Location = new System.Drawing.Point(75, 25);
            this.cmbBxExistCust.Name = "cmbBxExistCust";
            this.cmbBxExistCust.Size = new System.Drawing.Size(201, 21);
            this.cmbBxExistCust.TabIndex = 12;
            this.cmbBxExistCust.SelectedIndexChanged += new System.EventHandler(this.cmbBxExistCust_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Middle Initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(423, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name OR Company";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Enabled = false;
            this.txtBxLastName.Location = new System.Drawing.Point(336, 93);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(238, 20);
            this.txtBxLastName.TabIndex = 5;
            // 
            // txtBxMiddleInit
            // 
            this.txtBxMiddleInit.Enabled = false;
            this.txtBxMiddleInit.Location = new System.Drawing.Point(307, 93);
            this.txtBxMiddleInit.Name = "txtBxMiddleInit";
            this.txtBxMiddleInit.Size = new System.Drawing.Size(23, 20);
            this.txtBxMiddleInit.TabIndex = 4;
            // 
            // txtBxPhoneNum
            // 
            this.txtBxPhoneNum.Enabled = false;
            this.txtBxPhoneNum.Location = new System.Drawing.Point(6, 174);
            this.txtBxPhoneNum.Name = "txtBxPhoneNum";
            this.txtBxPhoneNum.Size = new System.Drawing.Size(177, 20);
            this.txtBxPhoneNum.TabIndex = 3;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Enabled = false;
            this.txtBxEmail.Location = new System.Drawing.Point(250, 174);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(324, 20);
            this.txtBxEmail.TabIndex = 2;
            // 
            // txtBxNameCompany
            // 
            this.txtBxNameCompany.Enabled = false;
            this.txtBxNameCompany.Location = new System.Drawing.Point(6, 93);
            this.txtBxNameCompany.Name = "txtBxNameCompany";
            this.txtBxNameCompany.Size = new System.Drawing.Size(295, 20);
            this.txtBxNameCompany.TabIndex = 1;
            // 
            // tabPgOrders
            // 
            this.tabPgOrders.Controls.Add(this.label19);
            this.tabPgOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPgOrders.Name = "tabPgOrders";
            this.tabPgOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgOrders.Size = new System.Drawing.Size(580, 408);
            this.tabPgOrders.TabIndex = 1;
            this.tabPgOrders.Text = "Orders";
            this.tabPgOrders.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(139, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(236, 20);
            this.label19.TabIndex = 0;
            this.label19.Text = "DISPLAY ORDERS HERE!!!";
            // 
            // tabPgEmpInfo
            // 
            this.tabPgEmpInfo.Controls.Add(this.cmbBxCIExistEmp);
            this.tabPgEmpInfo.Controls.Add(this.btnCISubmit);
            this.tabPgEmpInfo.Controls.Add(this.groupBox2);
            this.tabPgEmpInfo.Controls.Add(this.label18);
            this.tabPgEmpInfo.Controls.Add(this.cmbBxCIDepartment);
            this.tabPgEmpInfo.Controls.Add(this.chkBxCIIsSupervisor);
            this.tabPgEmpInfo.Controls.Add(this.label17);
            this.tabPgEmpInfo.Controls.Add(this.label16);
            this.tabPgEmpInfo.Controls.Add(this.cmbBxCIDriversState);
            this.tabPgEmpInfo.Controls.Add(this.label15);
            this.tabPgEmpInfo.Controls.Add(this.mskTxtBxCISSN);
            this.tabPgEmpInfo.Controls.Add(this.label14);
            this.tabPgEmpInfo.Controls.Add(this.label13);
            this.tabPgEmpInfo.Controls.Add(this.label12);
            this.tabPgEmpInfo.Controls.Add(this.label11);
            this.tabPgEmpInfo.Controls.Add(this.label10);
            this.tabPgEmpInfo.Controls.Add(this.cmbBxCIState);
            this.tabPgEmpInfo.Controls.Add(this.label9);
            this.tabPgEmpInfo.Controls.Add(this.label8);
            this.tabPgEmpInfo.Controls.Add(this.label7);
            this.tabPgEmpInfo.Controls.Add(this.label6);
            this.tabPgEmpInfo.Controls.Add(this.txtBxCIMiddleInit);
            this.tabPgEmpInfo.Controls.Add(this.txtBxCILastName);
            this.tabPgEmpInfo.Controls.Add(this.txtBxCIAddress);
            this.tabPgEmpInfo.Controls.Add(this.txtBxCICity);
            this.tabPgEmpInfo.Controls.Add(this.txtBxCIZipCode);
            this.tabPgEmpInfo.Controls.Add(this.txtBxCIPhoneNum);
            this.tabPgEmpInfo.Controls.Add(this.txtBxCIDriversLic);
            this.tabPgEmpInfo.Controls.Add(this.txtBxCIFirstName);
            this.tabPgEmpInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPgEmpInfo.Name = "tabPgEmpInfo";
            this.tabPgEmpInfo.Size = new System.Drawing.Size(580, 408);
            this.tabPgEmpInfo.TabIndex = 2;
            this.tabPgEmpInfo.Text = "Employee Info";
            this.tabPgEmpInfo.UseVisualStyleBackColor = true;
            // 
            // cmbBxCIExistEmp
            // 
            this.cmbBxCIExistEmp.FormattingEnabled = true;
            this.cmbBxCIExistEmp.Location = new System.Drawing.Point(387, 344);
            this.cmbBxCIExistEmp.Name = "cmbBxCIExistEmp";
            this.cmbBxCIExistEmp.Size = new System.Drawing.Size(170, 21);
            this.cmbBxCIExistEmp.TabIndex = 33;
            // 
            // btnCISubmit
            // 
            this.btnCISubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCISubmit.Location = new System.Drawing.Point(211, 336);
            this.btnCISubmit.Name = "btnCISubmit";
            this.btnCISubmit.Size = new System.Drawing.Size(128, 33);
            this.btnCISubmit.TabIndex = 32;
            this.btnCISubmit.Text = "Submit";
            this.btnCISubmit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radBtnCINewEmployee);
            this.groupBox2.Controls.Add(this.radBtnCIExistEmployee);
            this.groupBox2.Location = new System.Drawing.Point(22, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 100);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // radBtnCINewEmployee
            // 
            this.radBtnCINewEmployee.AutoSize = true;
            this.radBtnCINewEmployee.Location = new System.Drawing.Point(17, 62);
            this.radBtnCINewEmployee.Name = "radBtnCINewEmployee";
            this.radBtnCINewEmployee.Size = new System.Drawing.Size(96, 17);
            this.radBtnCINewEmployee.TabIndex = 32;
            this.radBtnCINewEmployee.Text = "New Employee";
            this.radBtnCINewEmployee.UseVisualStyleBackColor = true;
            // 
            // radBtnCIExistEmployee
            // 
            this.radBtnCIExistEmployee.AutoSize = true;
            this.radBtnCIExistEmployee.Checked = true;
            this.radBtnCIExistEmployee.Location = new System.Drawing.Point(17, 28);
            this.radBtnCIExistEmployee.Name = "radBtnCIExistEmployee";
            this.radBtnCIExistEmployee.Size = new System.Drawing.Size(110, 17);
            this.radBtnCIExistEmployee.TabIndex = 0;
            this.radBtnCIExistEmployee.TabStop = true;
            this.radBtnCIExistEmployee.Text = "Existing Employee";
            this.radBtnCIExistEmployee.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(268, 293);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 15);
            this.label18.TabIndex = 30;
            this.label18.Text = "Department";
            // 
            // cmbBxCIDepartment
            // 
            this.cmbBxCIDepartment.FormattingEnabled = true;
            this.cmbBxCIDepartment.Location = new System.Drawing.Point(211, 269);
            this.cmbBxCIDepartment.Name = "cmbBxCIDepartment";
            this.cmbBxCIDepartment.Size = new System.Drawing.Size(170, 21);
            this.cmbBxCIDepartment.TabIndex = 29;
            // 
            // chkBxCIIsSupervisor
            // 
            this.chkBxCIIsSupervisor.AutoSize = true;
            this.chkBxCIIsSupervisor.Location = new System.Drawing.Point(401, 206);
            this.chkBxCIIsSupervisor.Name = "chkBxCIIsSupervisor";
            this.chkBxCIIsSupervisor.Size = new System.Drawing.Size(145, 17);
            this.chkBxCIIsSupervisor.TabIndex = 28;
            this.chkBxCIIsSupervisor.Text = "Employee Is a Supervisor";
            this.chkBxCIIsSupervisor.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(230, 228);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 15);
            this.label17.TabIndex = 27;
            this.label17.Text = "Drivers License State";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(43, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "Drivers License #";
            // 
            // cmbBxCIDriversState
            // 
            this.cmbBxCIDriversState.FormattingEnabled = true;
            this.cmbBxCIDriversState.Location = new System.Drawing.Point(244, 204);
            this.cmbBxCIDriversState.Name = "cmbBxCIDriversState";
            this.cmbBxCIDriversState.Size = new System.Drawing.Size(96, 21);
            this.cmbBxCIDriversState.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(384, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "Social Security Number";
            // 
            // mskTxtBxCISSN
            // 
            this.mskTxtBxCISSN.Location = new System.Drawing.Point(401, 144);
            this.mskTxtBxCISSN.Mask = "000-00-0000";
            this.mskTxtBxCISSN.Name = "mskTxtBxCISSN";
            this.mskTxtBxCISSN.Size = new System.Drawing.Size(100, 20);
            this.mskTxtBxCISSN.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(221, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "Phone Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 21;
            this.label13.Text = "Zip Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(126, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(354, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 19;
            this.label11.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(484, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "State";
            // 
            // cmbBxCIState
            // 
            this.cmbBxCIState.FormattingEnabled = true;
            this.cmbBxCIState.Location = new System.Drawing.Point(449, 94);
            this.cmbBxCIState.Name = "cmbBxCIState";
            this.cmbBxCIState.Size = new System.Drawing.Size(96, 21);
            this.cmbBxCIState.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(245, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Middle Initial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "-Employee Information-";
            // 
            // txtBxCIMiddleInit
            // 
            this.txtBxCIMiddleInit.Location = new System.Drawing.Point(272, 37);
            this.txtBxCIMiddleInit.Name = "txtBxCIMiddleInit";
            this.txtBxCIMiddleInit.Size = new System.Drawing.Size(29, 20);
            this.txtBxCIMiddleInit.TabIndex = 12;
            // 
            // txtBxCILastName
            // 
            this.txtBxCILastName.Location = new System.Drawing.Point(365, 37);
            this.txtBxCILastName.Name = "txtBxCILastName";
            this.txtBxCILastName.Size = new System.Drawing.Size(180, 20);
            this.txtBxCILastName.TabIndex = 11;
            // 
            // txtBxCIAddress
            // 
            this.txtBxCIAddress.Location = new System.Drawing.Point(24, 93);
            this.txtBxCIAddress.Name = "txtBxCIAddress";
            this.txtBxCIAddress.Size = new System.Drawing.Size(250, 20);
            this.txtBxCIAddress.TabIndex = 10;
            // 
            // txtBxCICity
            // 
            this.txtBxCICity.Location = new System.Drawing.Point(315, 93);
            this.txtBxCICity.Name = "txtBxCICity";
            this.txtBxCICity.Size = new System.Drawing.Size(100, 20);
            this.txtBxCICity.TabIndex = 9;
            // 
            // txtBxCIZipCode
            // 
            this.txtBxCIZipCode.Location = new System.Drawing.Point(24, 144);
            this.txtBxCIZipCode.Name = "txtBxCIZipCode";
            this.txtBxCIZipCode.Size = new System.Drawing.Size(100, 20);
            this.txtBxCIZipCode.TabIndex = 7;
            // 
            // txtBxCIPhoneNum
            // 
            this.txtBxCIPhoneNum.Location = new System.Drawing.Point(190, 144);
            this.txtBxCIPhoneNum.Name = "txtBxCIPhoneNum";
            this.txtBxCIPhoneNum.Size = new System.Drawing.Size(150, 20);
            this.txtBxCIPhoneNum.TabIndex = 6;
            // 
            // txtBxCIDriversLic
            // 
            this.txtBxCIDriversLic.Location = new System.Drawing.Point(24, 206);
            this.txtBxCIDriversLic.Name = "txtBxCIDriversLic";
            this.txtBxCIDriversLic.Size = new System.Drawing.Size(140, 20);
            this.txtBxCIDriversLic.TabIndex = 4;
            // 
            // txtBxCIFirstName
            // 
            this.txtBxCIFirstName.Location = new System.Drawing.Point(24, 37);
            this.txtBxCIFirstName.Name = "txtBxCIFirstName";
            this.txtBxCIFirstName.Size = new System.Drawing.Size(180, 20);
            this.txtBxCIFirstName.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 458);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Computer Shop App";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPgCustomers.ResumeLayout(false);
            this.tabPgCustomers.PerformLayout();
            this.tabPgOrders.ResumeLayout(false);
            this.tabPgOrders.PerformLayout();
            this.tabPgEmpInfo.ResumeLayout(false);
            this.tabPgEmpInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPgCustomers;
        private System.Windows.Forms.TabPage tabPgOrders;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxMiddleInit;
        private System.Windows.Forms.TextBox txtBxPhoneNum;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxNameCompany;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxExistCust;
        private System.Windows.Forms.TabPage tabPgEmpInfo;
        private System.Windows.Forms.TextBox txtBxCIFirstName;
        private System.Windows.Forms.TextBox txtBxCIMiddleInit;
        private System.Windows.Forms.TextBox txtBxCILastName;
        private System.Windows.Forms.TextBox txtBxCIAddress;
        private System.Windows.Forms.TextBox txtBxCICity;
        private System.Windows.Forms.TextBox txtBxCIZipCode;
        private System.Windows.Forms.TextBox txtBxCIPhoneNum;
        private System.Windows.Forms.TextBox txtBxCIDriversLic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBxCIState;
        private System.Windows.Forms.MaskedTextBox mskTxtBxCISSN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbBxCIDriversState;
        private System.Windows.Forms.CheckBox chkBxCIIsSupervisor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbBxCIDepartment;
        private System.Windows.Forms.ComboBox cmbBxCIExistEmp;
        private System.Windows.Forms.Button btnCISubmit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBtnCINewEmployee;
        private System.Windows.Forms.RadioButton radBtnCIExistEmployee;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblErrorSelectCust;
        private System.Windows.Forms.Label label19;

    }
}

