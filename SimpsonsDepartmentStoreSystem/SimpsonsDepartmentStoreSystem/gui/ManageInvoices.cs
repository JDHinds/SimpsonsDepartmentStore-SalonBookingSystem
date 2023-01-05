using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpsonsDepartmentStoreSystem.gui
{
    public partial class ManageInvoices : Template
    {        
        public ManageInvoices()
        {
            InitializeComponent();

            dtpDateEnd.Hide();
            lblDtpDateEnd.Hide();

            dtpDateStart.Value = DateTime.Today;
            dtpDateEnd.Value = DateTime.Today;

            dtpDateStart.MaxDate = DateTime.Today; //You can't get an invoice for a date that hasn't happened yet
            dtpDateEnd.MaxDate = DateTime.Today;

            List<objects.Customers> i = new dal.Customers().getListOfCustomers();
            foreach (objects.Customers j in i)
            {
                cboCustomers.Items.Add(j.CustomerTitle + " " + j.CustomerForename + " " + j.CustomerSurname);
            }  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cboCustomers.SelectedIndex != -1) //Checking if a customer is selected
            {
                int i = new dal.Customers().getListOfCustomers()[cboCustomers.SelectedIndex].CustomerID;

                bool j = false;
                List<objects.Appointments> appointments = new dal.Appointments().getListOfAppointmentsByCustomerID(i);

                foreach (objects.Appointments k in appointments)
                {
                    if (k.AppointmentTime.Date >= dtpDateStart.Value && k.AppointmentTime.Date <= dtpDateEnd.Value)
                    { j = true; } //Checking if the customer has any appointments in the given range
                }

                if (j == true)
                {
                    //This line of code loads data into the 'simpsonsDepartmentStoreDataSet.SimpsonsDepartmentStoreDataTable' table
                    this.simpsonsDepartmentStoreDataTableAdapter.Fill(this.simpsonsDepartmentStoreDataSet.SimpsonsDepartmentStoreDataTable, i, dtpDateStart.Value, dtpDateEnd.Value.AddDays(1));
                    this.rpvInvoice.RefreshReport();
                }
                else
                {
                    MessageBox.Show("The selected customer has no appointments in the given date range.", "No Appointments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You have not selected a customer", "No Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chkDates_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDates.Checked == false)
            {
                lblDtpDateStart.Text = "Date";
                dtpDateEnd.Hide();
                lblDtpDateEnd.Hide();
                dtpDateEnd.Value = dtpDateStart.Value;
            }
            else
            {
                lblDtpDateStart.Text = "Start Date";
                dtpDateEnd.Show();
                lblDtpDateEnd.Show();
            }
        }

        private void dtpDateStart_ValueChanged(object sender, EventArgs e)
        {
            if (chkDates.Checked == false)
            {
                dtpDateEnd.Value = dtpDateStart.Value;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new gui.Cosmetics().Show();
            this.Hide();
        }
    }
}