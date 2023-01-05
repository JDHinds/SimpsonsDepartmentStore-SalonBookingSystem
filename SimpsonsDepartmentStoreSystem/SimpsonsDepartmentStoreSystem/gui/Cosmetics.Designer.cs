
namespace SimpsonsDepartmentStoreSystem.gui
{
    partial class Cosmetics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cosmetics));
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.picSalon = new System.Windows.Forms.PictureBox();
            this.btnInvoices = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSalon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAppointments
            // 
            this.btnAppointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.Location = new System.Drawing.Point(28, 145);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(295, 121);
            this.btnAppointments.TabIndex = 1;
            this.btnAppointments.Text = "Manage Appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(28, 290);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(295, 121);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "Manage Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(28, 572);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(295, 121);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // picSalon
            // 
            this.picSalon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSalon.Image = ((System.Drawing.Image)(resources.GetObject("picSalon.Image")));
            this.picSalon.Location = new System.Drawing.Point(358, 145);
            this.picSalon.Name = "picSalon";
            this.picSalon.Size = new System.Drawing.Size(897, 548);
            this.picSalon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalon.TabIndex = 13;
            this.picSalon.TabStop = false;
            // 
            // btnInvoices
            // 
            this.btnInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.Location = new System.Drawing.Point(28, 432);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(295, 121);
            this.btnInvoices.TabIndex = 3;
            this.btnInvoices.Text = "Manage Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // Cosmetics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 716);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.picSalon);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnAppointments);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cosmetics";
            this.Text = "Cosmetics and Beauty Services";
            this.Controls.SetChildIndex(this.btnAppointments, 0);
            this.Controls.SetChildIndex(this.btnCustomers, 0);
            this.Controls.SetChildIndex(this.btnMenu, 0);
            this.Controls.SetChildIndex(this.picSalon, 0);
            this.Controls.SetChildIndex(this.btnInvoices, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picSalon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox picSalon;
        private System.Windows.Forms.Button btnInvoices;
    }
}