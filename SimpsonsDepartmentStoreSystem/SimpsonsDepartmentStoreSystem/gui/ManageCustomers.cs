using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpsonsDepartmentStoreSystem.gui
{
    public partial class ManageCustomers : gui.Template
    {
        string phone;


        public ManageCustomers()
        {
            InitializeComponent();
            refreshLstCustomers();
            disableFields();
            lklTxtEmail.Hide();
            dtpBirth.MaxDate = DateTime.Today.AddYears(-12); //Users cannot select a date of birth that is more than 12 years ago.
            btnAddCustomer.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            lstCustomers.Enabled = true;
            txtLstCustomers.Enabled = true;
        }
           
                            

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e) //Because adding a new customer is an option in the list box, different things need to happen when a different index is selected.
        {
            if (lstCustomers.SelectedIndex == -1)
            { 
                clearFields();
                disableFields();
                btnAddCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = false;

                lklTxtEmail.Hide();
            }
            else if (lstCustomers.SelectedIndex == 0)
            {
                enableFields(); 
                btnAddCustomer.Text = "Add Customer";
                btnDeleteCustomer.Text = "Discard";
                clearFields();
                btnAddCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = false;

                lklTxtEmail.Hide();

                lstCustomers.Enabled = true;
                txtLstCustomers.Enabled = true;
            }
            else
            {
                disableFields();
                btnAddCustomer.Text = "Edit Customer";
                btnDeleteCustomer.Text = "Delete Customer";
                btnAddCustomer.Enabled = true;
                btnDeleteCustomer.Enabled = true;

                lklTxtEmail.Show();

                fillCustomerDetailsToFields(findCustomer());

                lstCustomers.Enabled = true;
                txtLstCustomers.Enabled = true;
            }
        }

        public void refreshLstCustomers()
        {
            lstCustomers.Items.Clear();
            lstCustomers.Items.Add("Add New Customer");
            List<objects.Customers> i = new dal.Customers().getListOfCustomersWhereNotArchived();

            if (txtLstCustomers.Text.Trim().ToLower() != "") //If txtLstCustomers isn't empty, then use it to elimnate certain customers from the display
            {
                for (int k = 0; k < i.Count; k++)
                {
                    if ((i[k].CustomerTitle + " " + i[k].CustomerForename + " " + i[k].CustomerSurname).ToLower().Contains(txtLstCustomers.Text.Trim().ToLower()))
                    { lstCustomers.Items.Add(i[k].CustomerTitle + " " + i[k].CustomerForename + " " + i[k].CustomerSurname); }
                }
            }
            else
            {
                for (int k = 0; k < i.Count; k++)
                {
                    lstCustomers.Items.Add(i[k].CustomerTitle + " " + i[k].CustomerForename + " " + i[k].CustomerSurname);
                }
            }
        }

        public objects.Customers findCustomer()
        {
            if (txtLstCustomers.Text.Trim() != "" && lstCustomers.SelectedIndex > 0)
            {
                List<objects.Customers> i = new dal.Customers().getListOfCustomersWhereNotArchived();
                int j = 0;
                for (int k = 0; k < i.Count; k++)
                {
                    if ((i[k].CustomerTitle + " " + i[k].CustomerForename + " " + i[k].CustomerSurname).Contains(txtLstCustomers.Text))
                    {
                        if (j == lstCustomers.SelectedIndex - 1)
                        { return i[k]; }
                        else
                        { j += 1; }
                    }
                }
                return new objects.Customers();
            }
            else if (lstCustomers.SelectedIndex > 0)
            {
                return new dal.Customers().getListOfCustomersWhereNotArchived()[lstCustomers.SelectedIndex - 1];
            }
            else
            { return new objects.Customers(); }
        }

        public void clearFields() //Remove all the data from all the fields
        {
            cboTitle.SelectedIndex = -1;
            txtForename.Clear();
            txtSurname.Clear();
            txtAddressLine1.Clear();
            txtAddressLine2.Clear();
            txtAddressCounty.Clear();
            txtAddressPostcode.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            dtpBirth.Value = DateTime.Now.AddYears(-18);
            chkSurvey.Checked = false;
        }

        public void enableFields() //Allow values to entered/changed
        {
            cboTitle.Enabled = true;
            txtForename.Enabled = true;
            txtSurname.Enabled = true;
            txtAddressLine1.Enabled = true;
            txtAddressLine2.Enabled = true;
            txtAddressCounty.Enabled = true;
            txtAddressPostcode.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            dtpBirth.Enabled = true;
            chkSurvey.Enabled = true;
        }

        public void disableFields() //Disallow values to entered/changed
        {
            cboTitle.Enabled = false;
            txtForename.Enabled = false;
            txtSurname.Enabled = false;
            txtAddressLine1.Enabled = false;
            txtAddressLine2.Enabled = false;
            txtAddressCounty.Enabled = false;
            txtAddressPostcode.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            dtpBirth.Enabled = false;
            chkSurvey.Enabled = false;
        }

        public bool areFieldsEnabled()
        {
            if (cboTitle.Enabled == true && txtForename.Enabled == true && txtSurname.Enabled == true && txtEmail.Enabled == true)
            { return true; }
            else
            { return false; }
        }

        public void fillCustomerDetailsToFields(objects.Customers i) //Put all the customer's information into the fields
        {
            for (int j = 0; j < cboTitle.Items.Count; j++)
            {
                if (i.CustomerTitle == cboTitle.Items[j].ToString())
                { cboTitle.SelectedIndex = j; }
            }

            txtForename.Text = i.CustomerForename;
            txtSurname.Text = i.CustomerSurname;
            txtAddressLine1.Text = i.CustomerAddressLine1;
            txtAddressLine2.Text = i.CustomerAddressLine2;
            txtAddressCounty.Text = i.CustomerAddressCounty;
            txtAddressPostcode.Text = i.CustomerAddressPostcode;
            txtEmail.Text = i.CustomerEmail;
            txtPhone.Text = i.CustomerPhoneNumber;
            dtpBirth.Value = i.CustomerDateOfBirth;
            chkSurvey.Checked = i.CustomerSurvey;
        }

        public override void picCosmetics_Click(object sender, EventArgs e) //If there is unsaved data, then the user will be alerted to that when attempting to leave the form.
        {
            if (cboTitle.Enabled == true && btnAddCustomer.Enabled == true)
            {
                DialogResult i = MessageBox.Show("Are you sure you want to exit? You have unsaved data.", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (i == DialogResult.Yes)
                {
                    new gui.Cosmetics().Show();
                    this.Hide();
                }
            }
            else 
            {
                new gui.Cosmetics().Show();
                this.Hide();
            }
        }

        public override void picExit_Click(object sender, EventArgs e)
        {
            if (cboTitle.Enabled == true && btnAddCustomer.Enabled == true)
            {
                DialogResult i = MessageBox.Show("Are you sure you want to exit? You have unsaved data.", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (i == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                DialogResult i = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (i == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void lklTxtEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Email the selected customer
        {
            try
            { System.Diagnostics.Process.Start("mailto:" + txtEmail.Text); }
            catch
            { }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
            bool hasLetter = false;
            for (int i = 0; i < txtPhone.Text.Length; i++)
            {
                if (!Char.IsDigit(txtPhone.Text[i]))
                { hasLetter = true; }
            }
            if (txtPhone.Text.Length > 11 || hasLetter == true)
            {
                txtPhone.Text = phone;
            }
            else 
            {
                phone = txtPhone.Text;
            }
        }

        private void txtLstCustomers_TextChanged(object sender, EventArgs e) //Update the search
        {
            refreshLstCustomers();
        }

        private void cboTitle_SelectedIndexChanged(object sender, EventArgs e) //If there's data entered/changed, allow changes to be saved
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void txtForename_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void txtAddressLine1_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void txtAddressLine2_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void txtAddressCounty_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void txtAddressPostcode_TextChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void chkSurvey_CheckedChanged(object sender, EventArgs e)
        {
            btnAddCustomer.Enabled = true;
            btnDeleteCustomer.Enabled = true;
            lstCustomers.Enabled = false;
            txtLstCustomers.Enabled = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (cboTitle.Enabled == true && btnAddCustomer.Enabled == true)
            {
                DialogResult i = MessageBox.Show("Are you sure you want to exit? You have unsaved data.", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (i == DialogResult.Yes)
                {
                    new gui.Cosmetics().Show();
                    this.Hide();
                }
            }
            else
            {
                new gui.Cosmetics().Show();
                this.Hide();
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            dal.Customers i = new dal.Customers();
            if (areFieldsEnabled())
            {
                try
                {
                    if (lstCustomers.SelectedIndex == 0) //Adds a customer if you are creating a new customer, and edits it if you're editing one.
                    {
                        i.addCustomer(new objects.Customers(0, cboTitle.Text, txtForename.Text, txtSurname.Text, txtAddressLine1.Text, txtAddressLine2.Text, txtAddressCounty.Text, txtAddressPostcode.Text, txtEmail.Text, txtPhone.Text, dtpBirth.Value, chkSurvey.Checked, false));
                    }
                    else
                    {
                        i.editCustomer(new objects.Customers(findCustomer().CustomerID, cboTitle.Text, txtForename.Text, txtSurname.Text, txtAddressLine1.Text, txtAddressLine2.Text, txtAddressCounty.Text, txtAddressPostcode.Text, txtEmail.Text, txtPhone.Text, dtpBirth.Value, chkSurvey.Checked, false));
                    }
                    refreshLstCustomers();
                    clearFields();
                    disableFields();
                    lstCustomers.SelectedIndex = -1;
                    lstCustomers.Enabled = true;
                    txtLstCustomers.Enabled = true;
                    btnAddCustomer.Enabled = false;
                    btnDeleteCustomer.Enabled = false;
                    btnAddCustomer.Text = "Add Customer";
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); } //For the customised exceptions
            }
            else
            {
                if (lstCustomers.SelectedIndex < 1)
                { }
                else
                {
                    enableFields();
                    btnAddCustomer.Text = "Save Changes";
                    btnDeleteCustomer.Text = "Discard Changes";
                }
                btnAddCustomer.Enabled = false;
                btnDeleteCustomer.Enabled = true;
                lstCustomers.Enabled = false;
                txtLstCustomers.Enabled = false;
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            DialogResult i;
            if (lstCustomers.SelectedIndex == 0)
            { i = MessageBox.Show("Are you sure you want to discard this customer?", "Confirm Customer Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); }
            else if (areFieldsEnabled())
            { i = MessageBox.Show("Are you sure you want to discard changes to this customer?", "Confirm Customer Changes Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); }
            else
            { i = MessageBox.Show("Are you sure you want to delete this customer? All future bookings will also be removed.", "Confirm Customer Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation); }
            if (i == DialogResult.Yes)
            {
                if (lstCustomers.SelectedIndex < 1 || areFieldsEnabled())
                {
                    lstCustomers.SelectedIndex = -1;
                    btnAddCustomer.Enabled = false;
                    btnDeleteCustomer.Enabled = false;
                    lstCustomers.Enabled = true;
                    txtLstCustomers.Enabled = true;
                }
                else
                {
                    objects.Customers j = findCustomer();
                    new dal.Customers().deleteCustomer(j.CustomerID);
                    refreshLstCustomers();
                    clearFields();
                    lstCustomers.SelectedIndex = -1;
                    btnAddCustomer.Enabled = false;
                    btnDeleteCustomer.Enabled = false;
                    lstCustomers.Enabled = true;
                    txtLstCustomers.Enabled = true;
                    btnAddCustomer.Text = "Add Customer";
                }
            }
        }
    }
}