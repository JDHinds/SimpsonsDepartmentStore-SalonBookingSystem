
namespace SimpsonsDepartmentStoreSystem.gui
{
    partial class ManageCustomers
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblTxtForename = new System.Windows.Forms.Label();
            this.lblTxtSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblTxtEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCboTitle = new System.Windows.Forms.Label();
            this.cboTitle = new System.Windows.Forms.ComboBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblTxtPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDtpBirth = new System.Windows.Forms.Label();
            this.lklTxtEmail = new System.Windows.Forms.LinkLabel();
            this.txtLstCustomers = new SimpsonsDepartmentStoreSystem.gui.controls.WaterMarkTextBox();
            this.lblTxtAddress = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new SimpsonsDepartmentStoreSystem.gui.controls.WaterMarkTextBox();
            this.txtAddressLine2 = new SimpsonsDepartmentStoreSystem.gui.controls.WaterMarkTextBox();
            this.txtAddressCounty = new SimpsonsDepartmentStoreSystem.gui.controls.WaterMarkTextBox();
            this.txtAddressPostcode = new SimpsonsDepartmentStoreSystem.gui.controls.WaterMarkTextBox();
            this.picBorder = new System.Windows.Forms.PictureBox();
            this.chkSurvey = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.BackColor = System.Drawing.Color.Silver;
            this.lstCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 24;
            this.lstCustomers.Location = new System.Drawing.Point(7, 215);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(332, 482);
            this.lstCustomers.TabIndex = 3;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(808, 643);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(457, 54);
            this.btnDeleteCustomer.TabIndex = 17;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // txtForename
            // 
            this.txtForename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForename.Location = new System.Drawing.Point(440, 304);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(362, 29);
            this.txtForename.TabIndex = 5;
            this.txtForename.TextChanged += new System.EventHandler(this.txtForename_TextChanged);
            // 
            // lblTxtForename
            // 
            this.lblTxtForename.AutoSize = true;
            this.lblTxtForename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblTxtForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtForename.Location = new System.Drawing.Point(440, 271);
            this.lblTxtForename.Name = "lblTxtForename";
            this.lblTxtForename.Size = new System.Drawing.Size(124, 29);
            this.lblTxtForename.TabIndex = 0;
            this.lblTxtForename.Text = "Forename";
            // 
            // lblTxtSurname
            // 
            this.lblTxtSurname.AutoSize = true;
            this.lblTxtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblTxtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtSurname.Location = new System.Drawing.Point(368, 358);
            this.lblTxtSurname.Name = "lblTxtSurname";
            this.lblTxtSurname.Size = new System.Drawing.Size(110, 29);
            this.lblTxtSurname.TabIndex = 0;
            this.lblTxtSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(373, 391);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(429, 29);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lblTxtEmail
            // 
            this.lblTxtEmail.AutoSize = true;
            this.lblTxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblTxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtEmail.Location = new System.Drawing.Point(818, 446);
            this.lblTxtEmail.Name = "lblTxtEmail";
            this.lblTxtEmail.Size = new System.Drawing.Size(74, 29);
            this.lblTxtEmail.TabIndex = 0;
            this.lblTxtEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(823, 478);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(429, 29);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblCboTitle
            // 
            this.lblCboTitle.AutoSize = true;
            this.lblCboTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblCboTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCboTitle.Location = new System.Drawing.Point(373, 272);
            this.lblCboTitle.Name = "lblCboTitle";
            this.lblCboTitle.Size = new System.Drawing.Size(61, 29);
            this.lblCboTitle.TabIndex = 0;
            this.lblCboTitle.Text = "Title";
            // 
            // cboTitle
            // 
            this.cboTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTitle.FormattingEnabled = true;
            this.cboTitle.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs.",
            "Mx.",
            "Dr."});
            this.cboTitle.Location = new System.Drawing.Point(373, 304);
            this.cboTitle.Name = "cboTitle";
            this.cboTitle.Size = new System.Drawing.Size(61, 32);
            this.cboTitle.TabIndex = 4;
            this.cboTitle.SelectedIndexChanged += new System.EventHandler(this.cboTitle_SelectedIndexChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(345, 643);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(457, 54);
            this.btnAddCustomer.TabIndex = 16;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(7, 135);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 42);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblTxtPhone
            // 
            this.lblTxtPhone.AutoSize = true;
            this.lblTxtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblTxtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtPhone.Location = new System.Drawing.Point(818, 358);
            this.lblTxtPhone.Name = "lblTxtPhone";
            this.lblTxtPhone.Size = new System.Drawing.Size(256, 29);
            this.lblTxtPhone.TabIndex = 0;
            this.lblTxtPhone.Text = "Mobile Phone Number";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(823, 390);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 29);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // dtpBirth
            // 
            this.dtpBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpBirth.Location = new System.Drawing.Point(823, 304);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(191, 29);
            this.dtpBirth.TabIndex = 11;
            this.dtpBirth.ValueChanged += new System.EventHandler(this.dtpBirth_ValueChanged);
            // 
            // lblDtpBirth
            // 
            this.lblDtpBirth.AutoSize = true;
            this.lblDtpBirth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblDtpBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtpBirth.Location = new System.Drawing.Point(818, 271);
            this.lblDtpBirth.Name = "lblDtpBirth";
            this.lblDtpBirth.Size = new System.Drawing.Size(144, 29);
            this.lblDtpBirth.TabIndex = 0;
            this.lblDtpBirth.Text = "Date of Birth";
            // 
            // lklTxtEmail
            // 
            this.lklTxtEmail.AutoSize = true;
            this.lklTxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lklTxtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lklTxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklTxtEmail.Location = new System.Drawing.Point(818, 513);
            this.lklTxtEmail.Name = "lklTxtEmail";
            this.lklTxtEmail.Size = new System.Drawing.Size(253, 29);
            this.lklTxtEmail.TabIndex = 14;
            this.lklTxtEmail.TabStop = true;
            this.lklTxtEmail.Text = "Contact Now via Email";
            this.lklTxtEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklTxtEmail_LinkClicked);
            // 
            // txtLstCustomers
            // 
            this.txtLstCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtLstCustomers.Location = new System.Drawing.Point(7, 183);
            this.txtLstCustomers.Name = "txtLstCustomers";
            this.txtLstCustomers.Size = new System.Drawing.Size(332, 29);
            this.txtLstCustomers.TabIndex = 2;
            this.txtLstCustomers.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLstCustomers.WaterMarkText = "Search...";
            this.txtLstCustomers.TextChanged += new System.EventHandler(this.txtLstCustomers_TextChanged);
            // 
            // lblTxtAddress
            // 
            this.lblTxtAddress.AutoSize = true;
            this.lblTxtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblTxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtAddress.Location = new System.Drawing.Point(368, 446);
            this.lblTxtAddress.Name = "lblTxtAddress";
            this.lblTxtAddress.Size = new System.Drawing.Size(102, 29);
            this.lblTxtAddress.TabIndex = 0;
            this.lblTxtAddress.Text = "Address";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAddressLine1.Location = new System.Drawing.Point(373, 478);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(429, 29);
            this.txtAddressLine1.TabIndex = 7;
            this.txtAddressLine1.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtAddressLine1.WaterMarkText = "Address Line 1";
            this.txtAddressLine1.TextChanged += new System.EventHandler(this.txtAddressLine1_TextChanged);
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAddressLine2.Location = new System.Drawing.Point(373, 513);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(429, 29);
            this.txtAddressLine2.TabIndex = 8;
            this.txtAddressLine2.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtAddressLine2.WaterMarkText = "Address Line 2";
            this.txtAddressLine2.TextChanged += new System.EventHandler(this.txtAddressLine2_TextChanged);
            // 
            // txtAddressCounty
            // 
            this.txtAddressCounty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAddressCounty.Location = new System.Drawing.Point(373, 548);
            this.txtAddressCounty.Name = "txtAddressCounty";
            this.txtAddressCounty.Size = new System.Drawing.Size(429, 29);
            this.txtAddressCounty.TabIndex = 9;
            this.txtAddressCounty.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtAddressCounty.WaterMarkText = "County";
            this.txtAddressCounty.TextChanged += new System.EventHandler(this.txtAddressCounty_TextChanged);
            // 
            // txtAddressPostcode
            // 
            this.txtAddressPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAddressPostcode.Location = new System.Drawing.Point(373, 583);
            this.txtAddressPostcode.Name = "txtAddressPostcode";
            this.txtAddressPostcode.Size = new System.Drawing.Size(429, 29);
            this.txtAddressPostcode.TabIndex = 10;
            this.txtAddressPostcode.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtAddressPostcode.WaterMarkText = "Postcode";
            this.txtAddressPostcode.TextChanged += new System.EventHandler(this.txtAddressPostcode_TextChanged);
            // 
            // picBorder
            // 
            this.picBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.picBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBorder.Location = new System.Drawing.Point(345, 256);
            this.picBorder.Name = "picBorder";
            this.picBorder.Size = new System.Drawing.Size(920, 381);
            this.picBorder.TabIndex = 27;
            this.picBorder.TabStop = false;
            // 
            // chkSurvey
            // 
            this.chkSurvey.AutoSize = true;
            this.chkSurvey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.chkSurvey.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.chkSurvey.Location = new System.Drawing.Point(823, 579);
            this.chkSurvey.Name = "chkSurvey";
            this.chkSurvey.Size = new System.Drawing.Size(230, 33);
            this.chkSurvey.TabIndex = 15;
            this.chkSurvey.Text = "Survey Completed";
            this.chkSurvey.UseVisualStyleBackColor = false;
            this.chkSurvey.CheckedChanged += new System.EventHandler(this.chkSurvey_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(580, 135);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Customers";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblInstructions.Location = new System.Drawing.Point(345, 183);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(900, 58);
            this.lblInstructions.TabIndex = 29;
            this.lblInstructions.Text = "Either select \"Add new customer\" to store a new customer\'s details in the system," +
    " or\r\nselect an existing customer to edit their details or delete them.";
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 716);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.chkSurvey);
            this.Controls.Add(this.txtAddressPostcode);
            this.Controls.Add(this.txtAddressCounty);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.lblTxtAddress);
            this.Controls.Add(this.txtLstCustomers);
            this.Controls.Add(this.lklTxtEmail);
            this.Controls.Add(this.lblDtpBirth);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.lblTxtPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.cboTitle);
            this.Controls.Add(this.lblCboTitle);
            this.Controls.Add(this.lblTxtEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTxtSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblTxtForename);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.picBorder);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ManageCustomers";
            this.Text = "Manage Customers";
            this.Controls.SetChildIndex(this.picBorder, 0);
            this.Controls.SetChildIndex(this.lstCustomers, 0);
            this.Controls.SetChildIndex(this.btnDeleteCustomer, 0);
            this.Controls.SetChildIndex(this.txtForename, 0);
            this.Controls.SetChildIndex(this.lblTxtForename, 0);
            this.Controls.SetChildIndex(this.txtSurname, 0);
            this.Controls.SetChildIndex(this.lblTxtSurname, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.lblTxtEmail, 0);
            this.Controls.SetChildIndex(this.lblCboTitle, 0);
            this.Controls.SetChildIndex(this.cboTitle, 0);
            this.Controls.SetChildIndex(this.btnAddCustomer, 0);
            this.Controls.SetChildIndex(this.btnMenu, 0);
            this.Controls.SetChildIndex(this.txtPhone, 0);
            this.Controls.SetChildIndex(this.lblTxtPhone, 0);
            this.Controls.SetChildIndex(this.dtpBirth, 0);
            this.Controls.SetChildIndex(this.lblDtpBirth, 0);
            this.Controls.SetChildIndex(this.lklTxtEmail, 0);
            this.Controls.SetChildIndex(this.txtLstCustomers, 0);
            this.Controls.SetChildIndex(this.lblTxtAddress, 0);
            this.Controls.SetChildIndex(this.txtAddressLine1, 0);
            this.Controls.SetChildIndex(this.txtAddressLine2, 0);
            this.Controls.SetChildIndex(this.txtAddressCounty, 0);
            this.Controls.SetChildIndex(this.txtAddressPostcode, 0);
            this.Controls.SetChildIndex(this.chkSurvey, 0);
            this.Controls.SetChildIndex(this.lblInstructions, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblTxtForename;
        private System.Windows.Forms.Label lblTxtSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblTxtEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCboTitle;
        private System.Windows.Forms.ComboBox cboTitle;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblTxtPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label lblDtpBirth;
        private System.Windows.Forms.LinkLabel lklTxtEmail;
        private controls.WaterMarkTextBox txtLstCustomers;
        private System.Windows.Forms.Label lblTxtAddress;
        private controls.WaterMarkTextBox txtAddressLine1;
        private controls.WaterMarkTextBox txtAddressLine2;
        private controls.WaterMarkTextBox txtAddressCounty;
        private controls.WaterMarkTextBox txtAddressPostcode;
        private System.Windows.Forms.PictureBox picBorder;
        private System.Windows.Forms.CheckBox chkSurvey;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
    }
}