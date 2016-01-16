namespace BusinessApp
{
    partial class frmNewCustomer
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.txtBxMiddleInit = new System.Windows.Forms.TextBox();
            this.txtBxPhoneNum = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxNameCompany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnCompany = new System.Windows.Forms.RadioButton();
            this.radBtnFirstName = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(114, 237);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 36);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(291, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Middle Initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email Address";
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(342, 65);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(238, 20);
            this.txtBxLastName.TabIndex = 2;
            // 
            // txtBxMiddleInit
            // 
            this.txtBxMiddleInit.Location = new System.Drawing.Point(313, 65);
            this.txtBxMiddleInit.Name = "txtBxMiddleInit";
            this.txtBxMiddleInit.Size = new System.Drawing.Size(23, 20);
            this.txtBxMiddleInit.TabIndex = 1;
            // 
            // txtBxPhoneNum
            // 
            this.txtBxPhoneNum.Location = new System.Drawing.Point(12, 158);
            this.txtBxPhoneNum.Name = "txtBxPhoneNum";
            this.txtBxPhoneNum.Size = new System.Drawing.Size(177, 20);
            this.txtBxPhoneNum.TabIndex = 5;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(256, 158);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(324, 20);
            this.txtBxEmail.TabIndex = 6;
            // 
            // txtBxNameCompany
            // 
            this.txtBxNameCompany.Location = new System.Drawing.Point(12, 65);
            this.txtBxNameCompany.Name = "txtBxNameCompany";
            this.txtBxNameCompany.Size = new System.Drawing.Size(295, 20);
            this.txtBxNameCompany.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(181, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "-Enter New Customer Information-";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(334, 237);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnCompany);
            this.groupBox1.Controls.Add(this.radBtnFirstName);
            this.groupBox1.Location = new System.Drawing.Point(27, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 33);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // radBtnCompany
            // 
            this.radBtnCompany.AutoSize = true;
            this.radBtnCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnCompany.Location = new System.Drawing.Point(134, 10);
            this.radBtnCompany.Name = "radBtnCompany";
            this.radBtnCompany.Size = new System.Drawing.Size(77, 19);
            this.radBtnCompany.TabIndex = 4;
            this.radBtnCompany.Text = "Company";
            this.radBtnCompany.UseVisualStyleBackColor = true;
            // 
            // radBtnFirstName
            // 
            this.radBtnFirstName.AutoSize = true;
            this.radBtnFirstName.Checked = true;
            this.radBtnFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnFirstName.Location = new System.Drawing.Point(22, 10);
            this.radBtnFirstName.Name = "radBtnFirstName";
            this.radBtnFirstName.Size = new System.Drawing.Size(85, 19);
            this.radBtnFirstName.TabIndex = 3;
            this.radBtnFirstName.TabStop = true;
            this.radBtnFirstName.Text = "First Name";
            this.radBtnFirstName.UseVisualStyleBackColor = true;
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 328);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.txtBxMiddleInit);
            this.Controls.Add(this.txtBxPhoneNum);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxNameCompany);
            this.Name = "frmNewCustomer";
            this.Text = "frmNewCustomer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.TextBox txtBxMiddleInit;
        private System.Windows.Forms.TextBox txtBxPhoneNum;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxNameCompany;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnCompany;
        private System.Windows.Forms.RadioButton radBtnFirstName;
    }
}