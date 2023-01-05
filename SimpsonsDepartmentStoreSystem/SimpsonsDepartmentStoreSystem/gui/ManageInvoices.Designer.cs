
namespace SimpsonsDepartmentStoreSystem.gui
{
    partial class ManageInvoices
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInvoices));
            this.simpsonsDepartmentStoreDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpsonsDepartmentStoreDataSet = new SimpsonsDepartmentStoreSystem.reporting.SimpsonsDepartmentStoreDataSet();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.lblCboCustomers = new System.Windows.Forms.Label();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.chkDates = new System.Windows.Forms.CheckBox();
            this.lblDtpDateStart = new System.Windows.Forms.Label();
            this.lblDtpDateEnd = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.rpvInvoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.simpsonsDepartmentStoreDataTableAdapter = new SimpsonsDepartmentStoreSystem.reporting.SimpsonsDepartmentStoreDataSetTableAdapters.SimpsonsDepartmentStoreDataTableAdapter();
            this.picBorder = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonsDepartmentStoreDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonsDepartmentStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // simpsonsDepartmentStoreDataTableBindingSource
            // 
            this.simpsonsDepartmentStoreDataTableBindingSource.DataMember = "SimpsonsDepartmentStoreDataTable";
            this.simpsonsDepartmentStoreDataTableBindingSource.DataSource = this.simpsonsDepartmentStoreDataSet;
            // 
            // simpsonsDepartmentStoreDataSet
            // 
            this.simpsonsDepartmentStoreDataSet.DataSetName = "SimpsonsDepartmentStoreDataSet";
            this.simpsonsDepartmentStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(12, 137);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(100, 43);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnRun
            // 
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(12, 676);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(421, 37);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Generate Invoice";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cboCustomers
            // 
            this.cboCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(146, 403);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(186, 32);
            this.cboCustomers.TabIndex = 2;
            // 
            // lblCboCustomers
            // 
            this.lblCboCustomers.AutoSize = true;
            this.lblCboCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblCboCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCboCustomers.Location = new System.Drawing.Point(23, 402);
            this.lblCboCustomers.Name = "lblCboCustomers";
            this.lblCboCustomers.Size = new System.Drawing.Size(117, 29);
            this.lblCboCustomers.TabIndex = 0;
            this.lblCboCustomers.Text = "Customer";
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateStart.Location = new System.Drawing.Point(28, 545);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(210, 29);
            this.dtpDateStart.TabIndex = 4;
            this.dtpDateStart.Value = new System.DateTime(2021, 11, 4, 0, 0, 0, 0);
            this.dtpDateStart.ValueChanged += new System.EventHandler(this.dtpDateStart_ValueChanged);
            // 
            // chkDates
            // 
            this.chkDates.AutoSize = true;
            this.chkDates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.chkDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.chkDates.Location = new System.Drawing.Point(28, 459);
            this.chkDates.Name = "chkDates";
            this.chkDates.Size = new System.Drawing.Size(176, 33);
            this.chkDates.TabIndex = 3;
            this.chkDates.Text = "Multiple Days";
            this.chkDates.UseVisualStyleBackColor = false;
            this.chkDates.CheckedChanged += new System.EventHandler(this.chkDates_CheckedChanged);
            // 
            // lblDtpDateStart
            // 
            this.lblDtpDateStart.AutoSize = true;
            this.lblDtpDateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblDtpDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtpDateStart.Location = new System.Drawing.Point(23, 513);
            this.lblDtpDateStart.Name = "lblDtpDateStart";
            this.lblDtpDateStart.Size = new System.Drawing.Size(63, 29);
            this.lblDtpDateStart.TabIndex = 0;
            this.lblDtpDateStart.Text = "Date";
            // 
            // lblDtpDateEnd
            // 
            this.lblDtpDateEnd.AutoSize = true;
            this.lblDtpDateEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblDtpDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtpDateEnd.Location = new System.Drawing.Point(23, 592);
            this.lblDtpDateEnd.Name = "lblDtpDateEnd";
            this.lblDtpDateEnd.Size = new System.Drawing.Size(112, 29);
            this.lblDtpDateEnd.TabIndex = 0;
            this.lblDtpDateEnd.Text = "End Date";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dtpDateEnd.Location = new System.Drawing.Point(28, 624);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(210, 29);
            this.dtpDateEnd.TabIndex = 5;
            this.dtpDateEnd.Value = new System.DateTime(2021, 11, 4, 0, 0, 0, 0);
            // 
            // rpvInvoice
            // 
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.simpsonsDepartmentStoreDataTableBindingSource;
            this.rpvInvoice.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvInvoice.LocalReport.ReportEmbeddedResource = "SimpsonsDepartmentStoreSystem.reporting.SimpsonsDepartmentStoreInvoice.rdlc";
            this.rpvInvoice.Location = new System.Drawing.Point(439, 137);
            this.rpvInvoice.Name = "rpvInvoice";
            this.rpvInvoice.ServerReport.BearerToken = null;
            this.rpvInvoice.Size = new System.Drawing.Size(834, 574);
            this.rpvInvoice.TabIndex = 0;
            this.rpvInvoice.TabStop = false;
            // 
            // simpsonsDepartmentStoreDataTableAdapter
            // 
            this.simpsonsDepartmentStoreDataTableAdapter.ClearBeforeFill = true;
            // 
            // picBorder
            // 
            this.picBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.picBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBorder.Location = new System.Drawing.Point(12, 394);
            this.picBorder.Name = "picBorder";
            this.picBorder.Size = new System.Drawing.Size(421, 276);
            this.picBorder.TabIndex = 28;
            this.picBorder.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(118, 142);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Invoices";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(236)))), ((int)(((byte)(222)))));
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblInstructions.Location = new System.Drawing.Point(12, 193);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(394, 174);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // ManageInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 716);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.rpvInvoice);
            this.Controls.Add(this.lblDtpDateEnd);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.lblDtpDateStart);
            this.Controls.Add(this.chkDates);
            this.Controls.Add(this.dtpDateStart);
            this.Controls.Add(this.cboCustomers);
            this.Controls.Add(this.lblCboCustomers);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.picBorder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageInvoices";
            this.Text = "Manage Invoices";
            this.Controls.SetChildIndex(this.picBorder, 0);
            this.Controls.SetChildIndex(this.btnMenu, 0);
            this.Controls.SetChildIndex(this.btnRun, 0);
            this.Controls.SetChildIndex(this.lblCboCustomers, 0);
            this.Controls.SetChildIndex(this.cboCustomers, 0);
            this.Controls.SetChildIndex(this.dtpDateStart, 0);
            this.Controls.SetChildIndex(this.chkDates, 0);
            this.Controls.SetChildIndex(this.lblDtpDateStart, 0);
            this.Controls.SetChildIndex(this.dtpDateEnd, 0);
            this.Controls.SetChildIndex(this.lblDtpDateEnd, 0);
            this.Controls.SetChildIndex(this.rpvInvoice, 0);
            this.Controls.SetChildIndex(this.lblInstructions, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.simpsonsDepartmentStoreDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpsonsDepartmentStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cboCustomers;
        private System.Windows.Forms.Label lblCboCustomers;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.CheckBox chkDates;
        private System.Windows.Forms.Label lblDtpDateStart;
        private System.Windows.Forms.Label lblDtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private Microsoft.Reporting.WinForms.ReportViewer rpvInvoice;
        private System.Windows.Forms.BindingSource simpsonsDepartmentStoreDataTableBindingSource;
        private reporting.SimpsonsDepartmentStoreDataSet simpsonsDepartmentStoreDataSet;
        private reporting.SimpsonsDepartmentStoreDataSetTableAdapters.SimpsonsDepartmentStoreDataTableAdapter simpsonsDepartmentStoreDataTableAdapter;
        private System.Windows.Forms.PictureBox picBorder;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInstructions;
    }
}