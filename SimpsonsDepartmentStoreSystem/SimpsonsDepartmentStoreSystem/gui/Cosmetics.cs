using System;

namespace SimpsonsDepartmentStoreSystem.gui
{
    public partial class Cosmetics : gui.Template
    {
        public Cosmetics()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e) //Brings the user to the area of the system they specify
        {
            new gui.BaseMenu().Show();
            this.Hide();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            new gui.ManageAppointments().Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new gui.ManageCustomers().Show();
            this.Hide();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            new gui.ManageInvoices().Show();
            this.Hide();
        }
    }
}
