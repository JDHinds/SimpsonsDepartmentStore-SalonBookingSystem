using System;
using System.Windows.Forms;

namespace SimpsonsDepartmentStoreSystem.gui
{
    public partial class Template : Form
    {
        public Template()
        {
            InitializeComponent();
        }

        private void Template_Load(object sender, EventArgs e)
        {

        }

        private void picOffices_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately, this subsystem is outside the scope of this project, given the time contraints.");
        }

        private void picDresses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately, this subsystem is outside the scope of this project, given the time contraints.");
        }

        private void picAlterations_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately, this subsystem is outside the scope of this project, given the time contraints.");
        }

        private void picHouseholdGoods_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unfortunately, this subsystem is outside the scope of this project, given the time contraints.");
        }

        public virtual void picCosmetics_Click(object sender, EventArgs e)
        {
            new gui.Cosmetics().Show();
            this.Hide();
        }

        public virtual void picExit_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (i == DialogResult.Yes)
            {
                Application.Exit();
            }           
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new gui.ManageCustomers().Show();
            this.Hide();
        }

        private void manageAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new gui.ManageAppointments().Show();
            this.Hide();
        }

        private void manageInvoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new gui.ManageInvoices().Show();
            this.Hide();
        }

        private void accessUserGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("userguide.pdf");
        }
    }
}