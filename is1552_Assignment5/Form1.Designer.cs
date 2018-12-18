namespace is1552_Assignment5
{
    partial class customerUpdateFRM
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
            this.customerNumLBL = new System.Windows.Forms.Label();
            this.customerNameLBL = new System.Windows.Forms.Label();
            this.customerAddressLBL = new System.Windows.Forms.Label();
            this.customerCityLBL = new System.Windows.Forms.Label();
            this.customerStateLBL = new System.Windows.Forms.Label();
            this.customerZipLBL = new System.Windows.Forms.Label();
            this.customerPhnNumLBL = new System.Windows.Forms.Label();
            this.customerEmailLBL = new System.Windows.Forms.Label();
            this.customerCMBOX = new System.Windows.Forms.ComboBox();
            this.customerNameTXT = new System.Windows.Forms.TextBox();
            this.customerCityTXT = new System.Windows.Forms.TextBox();
            this.customerStateTXT = new System.Windows.Forms.TextBox();
            this.customerZipCMBOX = new System.Windows.Forms.ComboBox();
            this.customerPhnNumTXT = new System.Windows.Forms.TextBox();
            this.customerEmailTXT = new System.Windows.Forms.TextBox();
            this.updateCustomerBTN = new System.Windows.Forms.Button();
            this.customerDeleteBTN = new System.Windows.Forms.Button();
            this.customerAddBTN = new System.Windows.Forms.Button();
            this.customerNumDS = new System.Data.DataSet();
            this.customerZipDS = new System.Data.DataSet();
            this.customerAddressTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerNumDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerZipDS)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNumLBL
            // 
            this.customerNumLBL.AutoSize = true;
            this.customerNumLBL.Location = new System.Drawing.Point(215, 35);
            this.customerNumLBL.Name = "customerNumLBL";
            this.customerNumLBL.Size = new System.Drawing.Size(99, 13);
            this.customerNumLBL.TabIndex = 0;
            this.customerNumLBL.Text = "Customer Numbers:";
            // 
            // customerNameLBL
            // 
            this.customerNameLBL.AutoSize = true;
            this.customerNameLBL.Location = new System.Drawing.Point(41, 113);
            this.customerNameLBL.Name = "customerNameLBL";
            this.customerNameLBL.Size = new System.Drawing.Size(38, 13);
            this.customerNameLBL.TabIndex = 1;
            this.customerNameLBL.Text = "Name:";
            // 
            // customerAddressLBL
            // 
            this.customerAddressLBL.AutoSize = true;
            this.customerAddressLBL.Location = new System.Drawing.Point(41, 162);
            this.customerAddressLBL.Name = "customerAddressLBL";
            this.customerAddressLBL.Size = new System.Drawing.Size(48, 13);
            this.customerAddressLBL.TabIndex = 2;
            this.customerAddressLBL.Text = "Address:";
            // 
            // customerCityLBL
            // 
            this.customerCityLBL.AutoSize = true;
            this.customerCityLBL.Location = new System.Drawing.Point(41, 206);
            this.customerCityLBL.Name = "customerCityLBL";
            this.customerCityLBL.Size = new System.Drawing.Size(27, 13);
            this.customerCityLBL.TabIndex = 3;
            this.customerCityLBL.Text = "City:";
            // 
            // customerStateLBL
            // 
            this.customerStateLBL.AutoSize = true;
            this.customerStateLBL.Location = new System.Drawing.Point(334, 206);
            this.customerStateLBL.Name = "customerStateLBL";
            this.customerStateLBL.Size = new System.Drawing.Size(35, 13);
            this.customerStateLBL.TabIndex = 4;
            this.customerStateLBL.Text = "State:";
            // 
            // customerZipLBL
            // 
            this.customerZipLBL.AutoSize = true;
            this.customerZipLBL.Location = new System.Drawing.Point(497, 206);
            this.customerZipLBL.Name = "customerZipLBL";
            this.customerZipLBL.Size = new System.Drawing.Size(25, 13);
            this.customerZipLBL.TabIndex = 5;
            this.customerZipLBL.Text = "Zip:";
            // 
            // customerPhnNumLBL
            // 
            this.customerPhnNumLBL.AutoSize = true;
            this.customerPhnNumLBL.Location = new System.Drawing.Point(41, 271);
            this.customerPhnNumLBL.Name = "customerPhnNumLBL";
            this.customerPhnNumLBL.Size = new System.Drawing.Size(81, 13);
            this.customerPhnNumLBL.TabIndex = 6;
            this.customerPhnNumLBL.Text = "Phone Number:";
            // 
            // customerEmailLBL
            // 
            this.customerEmailLBL.AutoSize = true;
            this.customerEmailLBL.Location = new System.Drawing.Point(41, 328);
            this.customerEmailLBL.Name = "customerEmailLBL";
            this.customerEmailLBL.Size = new System.Drawing.Size(80, 13);
            this.customerEmailLBL.TabIndex = 7;
            this.customerEmailLBL.Text = "E-Mail Address:";
            // 
            // customerCMBOX
            // 
            this.customerCMBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerCMBOX.FormattingEnabled = true;
            this.customerCMBOX.Location = new System.Drawing.Point(337, 32);
            this.customerCMBOX.Name = "customerCMBOX";
            this.customerCMBOX.Size = new System.Drawing.Size(121, 21);
            this.customerCMBOX.TabIndex = 8;
            this.customerCMBOX.SelectedIndexChanged += new System.EventHandler(this.customerCMBOX_SelectedIndexChanged);
            // 
            // customerNameTXT
            // 
            this.customerNameTXT.BackColor = System.Drawing.Color.White;
            this.customerNameTXT.Location = new System.Drawing.Point(132, 110);
            this.customerNameTXT.Name = "customerNameTXT";
            this.customerNameTXT.ReadOnly = true;
            this.customerNameTXT.Size = new System.Drawing.Size(512, 20);
            this.customerNameTXT.TabIndex = 9;
            // 
            // customerCityTXT
            // 
            this.customerCityTXT.Location = new System.Drawing.Point(132, 203);
            this.customerCityTXT.Name = "customerCityTXT";
            this.customerCityTXT.ReadOnly = true;
            this.customerCityTXT.Size = new System.Drawing.Size(182, 20);
            this.customerCityTXT.TabIndex = 11;
            // 
            // customerStateTXT
            // 
            this.customerStateTXT.Location = new System.Drawing.Point(372, 203);
            this.customerStateTXT.Name = "customerStateTXT";
            this.customerStateTXT.ReadOnly = true;
            this.customerStateTXT.Size = new System.Drawing.Size(103, 20);
            this.customerStateTXT.TabIndex = 12;
            // 
            // customerZipCMBOX
            // 
            this.customerZipCMBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerZipCMBOX.Enabled = false;
            this.customerZipCMBOX.FormattingEnabled = true;
            this.customerZipCMBOX.Location = new System.Drawing.Point(528, 203);
            this.customerZipCMBOX.Name = "customerZipCMBOX";
            this.customerZipCMBOX.Size = new System.Drawing.Size(121, 21);
            this.customerZipCMBOX.TabIndex = 13;
            this.customerZipCMBOX.SelectedIndexChanged += new System.EventHandler(this.customerZipCMBOX_SelectedIndexChanged);
            // 
            // customerPhnNumTXT
            // 
            this.customerPhnNumTXT.BackColor = System.Drawing.Color.White;
            this.customerPhnNumTXT.Location = new System.Drawing.Point(132, 268);
            this.customerPhnNumTXT.Name = "customerPhnNumTXT";
            this.customerPhnNumTXT.ReadOnly = true;
            this.customerPhnNumTXT.Size = new System.Drawing.Size(343, 20);
            this.customerPhnNumTXT.TabIndex = 14;
            // 
            // customerEmailTXT
            // 
            this.customerEmailTXT.BackColor = System.Drawing.Color.White;
            this.customerEmailTXT.Location = new System.Drawing.Point(132, 325);
            this.customerEmailTXT.Name = "customerEmailTXT";
            this.customerEmailTXT.ReadOnly = true;
            this.customerEmailTXT.Size = new System.Drawing.Size(343, 20);
            this.customerEmailTXT.TabIndex = 15;
            // 
            // updateCustomerBTN
            // 
            this.updateCustomerBTN.Location = new System.Drawing.Point(132, 370);
            this.updateCustomerBTN.Name = "updateCustomerBTN";
            this.updateCustomerBTN.Size = new System.Drawing.Size(141, 23);
            this.updateCustomerBTN.TabIndex = 16;
            this.updateCustomerBTN.Text = "Update";
            this.updateCustomerBTN.UseVisualStyleBackColor = true;
            this.updateCustomerBTN.Click += new System.EventHandler(this.updateCustomerBTN_Click);
            // 
            // customerDeleteBTN
            // 
            this.customerDeleteBTN.Location = new System.Drawing.Point(320, 370);
            this.customerDeleteBTN.Name = "customerDeleteBTN";
            this.customerDeleteBTN.Size = new System.Drawing.Size(141, 23);
            this.customerDeleteBTN.TabIndex = 17;
            this.customerDeleteBTN.Text = "Delete";
            this.customerDeleteBTN.UseVisualStyleBackColor = true;
            this.customerDeleteBTN.Click += new System.EventHandler(this.customerDeleteBTN_Click);
            // 
            // customerAddBTN
            // 
            this.customerAddBTN.Location = new System.Drawing.Point(508, 370);
            this.customerAddBTN.Name = "customerAddBTN";
            this.customerAddBTN.Size = new System.Drawing.Size(141, 23);
            this.customerAddBTN.TabIndex = 18;
            this.customerAddBTN.Text = "Add";
            this.customerAddBTN.UseVisualStyleBackColor = true;
            this.customerAddBTN.Click += new System.EventHandler(this.customerAddBTN_Click);
            // 
            // customerNumDS
            // 
            this.customerNumDS.DataSetName = "NewDataSet";
            // 
            // customerZipDS
            // 
            this.customerZipDS.DataSetName = "NewDataSet";
            // 
            // customerAddressTXT
            // 
            this.customerAddressTXT.BackColor = System.Drawing.Color.White;
            this.customerAddressTXT.Location = new System.Drawing.Point(132, 162);
            this.customerAddressTXT.Name = "customerAddressTXT";
            this.customerAddressTXT.ReadOnly = true;
            this.customerAddressTXT.Size = new System.Drawing.Size(512, 20);
            this.customerAddressTXT.TabIndex = 10;
            // 
            // customerUpdateFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 416);
            this.Controls.Add(this.customerAddressTXT);
            this.Controls.Add(this.customerAddBTN);
            this.Controls.Add(this.customerDeleteBTN);
            this.Controls.Add(this.updateCustomerBTN);
            this.Controls.Add(this.customerEmailTXT);
            this.Controls.Add(this.customerPhnNumTXT);
            this.Controls.Add(this.customerZipCMBOX);
            this.Controls.Add(this.customerStateTXT);
            this.Controls.Add(this.customerCityTXT);
            this.Controls.Add(this.customerNameTXT);
            this.Controls.Add(this.customerCMBOX);
            this.Controls.Add(this.customerEmailLBL);
            this.Controls.Add(this.customerPhnNumLBL);
            this.Controls.Add(this.customerZipLBL);
            this.Controls.Add(this.customerStateLBL);
            this.Controls.Add(this.customerCityLBL);
            this.Controls.Add(this.customerAddressLBL);
            this.Controls.Add(this.customerNameLBL);
            this.Controls.Add(this.customerNumLBL);
            this.Name = "customerUpdateFRM";
            this.Text = "Customer Update Screen";
            this.Load += new System.EventHandler(this.customerUpdateFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerNumDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerZipDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNumLBL;
        private System.Windows.Forms.Label customerNameLBL;
        private System.Windows.Forms.Label customerAddressLBL;
        private System.Windows.Forms.Label customerCityLBL;
        private System.Windows.Forms.Label customerStateLBL;
        private System.Windows.Forms.Label customerZipLBL;
        private System.Windows.Forms.Label customerPhnNumLBL;
        private System.Windows.Forms.Label customerEmailLBL;
        private System.Windows.Forms.ComboBox customerCMBOX;
        private System.Windows.Forms.TextBox customerNameTXT;
        private System.Windows.Forms.TextBox customerCityTXT;
        private System.Windows.Forms.TextBox customerStateTXT;
        private System.Windows.Forms.ComboBox customerZipCMBOX;
        private System.Windows.Forms.TextBox customerPhnNumTXT;
        private System.Windows.Forms.TextBox customerEmailTXT;
        private System.Windows.Forms.Button updateCustomerBTN;
        private System.Windows.Forms.Button customerDeleteBTN;
        private System.Windows.Forms.Button customerAddBTN;
        private System.Data.DataSet customerNumDS;
        private System.Data.DataSet customerZipDS;
        private System.Windows.Forms.TextBox customerAddressTXT;
    }
}

