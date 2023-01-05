using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpsonsDepartmentStoreSystem.gui
{
    public partial class ManageAppointments : Template
    {
        bool isEditing;
        int appointment = -1;

        DateTime dateTime;
        List<int> treatments = new List<int>();
        int staff = -1;
        int customer = -1;
        int room = -1;

        bool update = false;

        public ManageAppointments()
        {
            InitializeComponent();
            pbgSchedule.setup();
            fillFields(); //loads the lists of customers, staff, rooms, and treatments
            dtpAppointmentDate.Value = DateTime.Today;
            pbgSchedule.MouseDown += new MouseEventHandler(loadTime); //Assigning the click event to the schedule control
            dtpAppointmentTime.Value = new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, 9, 0, 0);
            dateTime = new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, 9, 0, 0);
            disableFields();
            btnDeleteAppointment.Hide();
            btnAddAppointment.Hide();
            lblDuration.Hide();
            lblCost.Hide();
            update = true; // Update's a bool used to stop the verification on adding/editing firing unnecessarily
        }

        private void dtpAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            pbgSchedule.AddStaffSchedule(dtpAppointmentDate.Value);
            foreach (Control i in pbgSchedule.Controls)
            {
                if (i.Name == "appointment")
                { i.Click += new EventHandler(loadAppointment); }
            }

            // Loads the appointments for the day

            clearFields();
        }

        private void fillFields() //Puts all the data from the database in the fields
        {
            List<objects.Staff> k = new dal.Staff().getListOfStaffFromReader();

            for (int i = 0; i < k.Count; i++)
            {
                cboStaff.Items.Add(k[i].StaffTitle + " " + k[i].StaffForename + " " + k[i].StaffSurname);
            }

            List<objects.Rooms> l = new dal.Rooms().getListOfRoomsFromReader();

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].NailBar == false)
                {
                    cboRoom.Items.Add(l[i].RoomNumber);
                }
                else
                {
                    cboRoom.Items.Add("Nail Bar");
                }
            }

            List<objects.Treatments> m = new dal.Treatments().getListOfTreatmentsFromReader();

            for (int i = 0; i < m.Count; i++)
            {
                cklTreatments.Items.Add(m[i].TreatmentName);
            }
        }

        private void disableFields() //Disallow anything from being entered
        {
            cboCustomers.Enabled = false;
            cboStaff.Enabled = false;
            cboRoom.Enabled = false;
            cklTreatments.Enabled = false;
            dtpAppointmentTime.Enabled = false;
            dtpAppointmentDate.Enabled = true;
        }

        private void enableFields() //Allow data to be entered
        {
            cboCustomers.Enabled = true;
            cboStaff.Enabled = true;
            cboRoom.Enabled = true;
            cklTreatments.Enabled = true;
            dtpAppointmentTime.Enabled = true;
            dtpAppointmentDate.Enabled = false;
        }

        private void clearFields() //Removes the selected data from all the fields
        {
            cboCustomers.Items.Clear();
            List<objects.Customers> m = new dal.Customers().getListOfCustomersWhereNotArchived();
            for (int n = 0; n < m.Count; n++)
            {
                cboCustomers.Items.Add(m[n].CustomerTitle + " " + m[n].CustomerForename + " " + m[n].CustomerSurname);
            }

            cboCustomers.SelectedIndex = -1;
            cboCustomers.Text = "";
            cboStaff.SelectedIndex = -1;
            cboRoom.SelectedIndex = -1;

            if (cklTreatments.CheckedItems.Count == 0 && cboRoom.Items.Count == 3)
            {
                cboRoom.Items.Add("Nail Bar");
            }
            else if (cklTreatments.CheckedItems.Count == 1 && cklTreatments.CheckedItems[0].ToString() == "Nails" && cboRoom.Items.Count == 3)
            {
                cboRoom.Items.Add("Nail Bar");
            }

            cklTreatments.ClearSelected();
            for (int j = 0; j < cklTreatments.Items.Count; j++)
            {
                cklTreatments.SetItemChecked(j, false);
            }
            dtpAppointmentTime.Value = new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, 9, 0, 0);

            dateTime = new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, 9, 0, 0);
            treatments = new List<int>();
            staff = -1;
            customer = -1;
            room = -1;
        }

        private bool areFieldsEnabled()
        {
            if (cboCustomers.Enabled == true)
            { return true; }
            return false;
        }

        private bool checkFields() //Make sure no fields are null before continuing
        {
            if (cboCustomers.SelectedIndex > -1)
            {
                if (cboStaff.SelectedIndex > -1)
                {
                    if (cboRoom.SelectedIndex > -1)
                    {
                        if (cklTreatments.CheckedIndices.Count > 0)
                        {
                            return true;
                        }
                        else
                        { MessageBox.Show("You have not selected any treatments. Please select one to continue"); }
                    }
                    else
                    { MessageBox.Show("You have not selected a room. Please select one to continue"); }
                }
                else
                { MessageBox.Show("You have not selected a member of staff. Please select one to continue"); }
            }
            else
            { MessageBox.Show("You have not selected a customer. Please select one to continue"); }
            return false;
        }

        private void addAppointment()
        {
            objects.Customers customer = new dal.Customers().getCustomerFromID(new dal.Customers().getListOfCustomersWhereNotArchived()[cboCustomers.SelectedIndex].CustomerID);
            if (customer.CustomerSurvey == false)
            {
                DialogResult i = MessageBox.Show("This user has not completed the survey. Only continue if the survey has been completed.", "Confirm Survey", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (i == DialogResult.Yes) // As per case study, all customers are required to fill out a survey before they can book an appointment. This is to make sure that they have before an appointment can be made.
                {
                    customer.CustomerSurvey = true;
                    new dal.Customers().editCustomer(customer);
                    int k = new dal.Appointments().addAndReturnAppointmentID(customer.CustomerID, cboStaff.SelectedIndex, cboRoom.SelectedIndex + 1, new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, dtpAppointmentTime.Value.Hour, dtpAppointmentTime.Value.Minute, 0));

                    for (int j = 0; j < cklTreatments.CheckedIndices.Count; j++)
                    {
                        new dal.Bookings().addBooking(k, cklTreatments.CheckedIndices[j]);
                    }
                }
            }
            else
            {
                int k = new dal.Appointments().addAndReturnAppointmentID(customer.CustomerID, cboStaff.SelectedIndex, cboRoom.SelectedIndex + 1, new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, dtpAppointmentTime.Value.Hour, dtpAppointmentTime.Value.Minute, 0));

                for (int j = 0; j < cklTreatments.CheckedIndices.Count; j++)
                {
                    new dal.Bookings().addBooking(k, cklTreatments.CheckedIndices[j]);
                }
            }
        }

        private void editAppointment()
        {
            new dal.Appointments().editAppointment(new dal.Customers().getListOfCustomers()[cboCustomers.SelectedIndex].CustomerID, cboStaff.SelectedIndex, cboRoom.SelectedIndex + 1, new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, dtpAppointmentTime.Value.Hour, dtpAppointmentTime.Value.Minute, 0), appointment);
            new dal.Bookings().deleteBookingByAppointmentID(appointment);
            for (int j = 0; j < cklTreatments.CheckedIndices.Count; j++)
            {
                new dal.Bookings().addBooking(appointment, cklTreatments.CheckedIndices[j]);
            }
        }

        private void deleteAppointment()
        {
            new dal.Appointments().deleteAppointment(appointment);
        }

        private void loadAppointment(object sender, EventArgs e) //Gets the appointment selected on the form, and fills the fields with the data for that appointment
        {
            if (!areFieldsEnabled())
            {
                if (((Control)sender).Tag != null && ((Control)sender).Name == "appointment")
                {
                    objects.Appointments i = new dal.Appointments().getAppointmentByID(Convert.ToInt32(((Control)sender).Tag));
                    for (int j = 0; j < cklTreatments.Items.Count; j++)
                    {
                        cklTreatments.SetItemChecked(j, false);
                    }
                    List<objects.Bookings> k = new dal.Bookings().getListOfBookingsByAppointmentID(Convert.ToInt32(((Control)sender).Tag));
                    int cost = 0;
                    int duration = 0;
                    foreach (objects.Bookings l in k)
                    {
                        cklTreatments.SetItemChecked(l.Treatment, true);
                        objects.Treatments treatments = new dal.Treatments().getTreatmentsByID(l.Treatment);
                        duration += treatments.TreatmentDuration;
                        cost += treatments.TreatmentCost;
                    }
                    btnAddAppointment.Show();
                    btnAddAppointment.Text = "Edit Appointment";
                    btnDeleteAppointment.Show();
                    btnDeleteAppointment.Text = "Delete Appointment";
                    isEditing = true;
                    appointment = Convert.ToInt32(((Control)sender).Tag);

                    cboCustomers.Items.Clear();
                    List<objects.Customers> m = new dal.Customers().getListOfCustomers();

                    for (int n = 0; n < m.Count; n++)
                    {
                        cboCustomers.Items.Add(m[n].CustomerTitle + " " + m[n].CustomerForename + " " + m[n].CustomerSurname);
                    }

                    foreach (objects.Customers customers in m)
                    {
                        if (customers.CustomerID == i.Customer)
                        {
                            cboCustomers.SelectedIndex = m.IndexOf(customers);
                        }
                    }

                    dtpAppointmentTime.Value = i.AppointmentTime;
                    cboStaff.SelectedIndex = i.Staff;
                    cboRoom.SelectedIndex = i.Room - 1;

                    lblDuration.Text = "Duration = " + duration + " min";
                    lblCost.Text = "Cost = £" + (new decimal(cost) / 100).ToString("0.00");

                    lblCost.Show();
                    lblDuration.Show();
                }
                else
                {
                    clearFields();
                    btnAddAppointment.Hide();
                    isEditing = false;
                    appointment = -1;

                    lblCost.Hide();
                    lblDuration.Hide();
                }
            }
        }

        private void loadTime(object sender, MouseEventArgs e) //When a time is clicked on the schedule, fetch the time in relative measures to the mouse position.
        {
            if (dtpAppointmentDate.Value >= DateTime.Today)
            {
                if ((!areFieldsEnabled() && isEditing == false) || areFieldsEnabled())
                {
                    if (isEditing == false)
                    {
                        btnDeleteAppointment.Text = "Discard Appointment";
                        btnAddAppointment.Text = "Add Appointment";
                    }
                    enableFields();
                    btnDeleteAppointment.Show();
                    btnAddAppointment.Show();
                    lblDuration.Show();
                    lblCost.Show();

                    update = false;
                    double j = e.X * 32 / pbgSchedule.Width;
                    dtpAppointmentTime.Value = new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, 09, 00, 00).AddMinutes(15 * Convert.ToInt32(Math.Floor(j)));
                    double i = e.Y * 4 / pbgSchedule.Height;
                    cboStaff.SelectedIndex = Convert.ToInt32(Math.Floor(i));
                    UpdatePreviewAppointment();
                    update = true;
                }

                else //If not today, or was previously viewing an appointment, clicking on a blank space will make it clear
                {
                    clearFields();
                    disableFields();
                    pbgSchedule.AddStaffSchedule(dtpAppointmentDate.Value);
                    foreach (Control j in pbgSchedule.Controls)
                    {
                        if (j.Name == "appointment")
                        { j.Click += new EventHandler(loadAppointment); }
                    }
                    btnDeleteAppointment.Hide();
                    lblDuration.Hide();
                    lblCost.Hide();
                    btnAddAppointment.Hide();

                    isEditing = false;
                }
            }
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (areFieldsEnabled() && checkFields())
            {
                if (isEditing == false)
                {
                    addAppointment(); //Adds an appointment if creating a new appointment. Otherwise, edits existing appointment
                }
                else if (isEditing == true)
                {
                    editAppointment();
                }
                clearFields();
                disableFields();
                pbgSchedule.AddStaffSchedule(dtpAppointmentDate.Value);
                foreach (Control i in pbgSchedule.Controls)
                {
                    if (i.Name == "appointment")
                    { i.Click += new EventHandler(loadAppointment); }
                }
                btnDeleteAppointment.Hide();
                btnAddAppointment.Hide();
                lblDuration.Hide();
                lblCost.Hide();
                btnAddAppointment.Text = "Add Appointment";
                isEditing = false;
            }
            else
            {
                btnDeleteAppointment.Text = "Discard Changes";
                btnAddAppointment.Text = "Save Changes";
                enableFields();
                btnDeleteAppointment.Show();
                lblDuration.Show();
                lblCost.Show();

                dateTime = dtpAppointmentTime.Value;
                staff = cboStaff.SelectedIndex;
                room = cboRoom.SelectedIndex;
                customer = cboCustomers.SelectedIndex;
                treatments.Clear();
                foreach (int m in cklTreatments.CheckedIndices)
                {
                    treatments.Add(m);
                }
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            DialogResult i = new DialogResult();
            if (isEditing == false)
            {
                i = MessageBox.Show("Are you sure you want to discard this appointment?", "Confirm Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (i == DialogResult.Yes)
                {
                    clearFields();
                    disableFields();
                    pbgSchedule.AddStaffSchedule(dtpAppointmentDate.Value);
                    foreach (Control j in pbgSchedule.Controls)
                    {
                        if (j.Name == "appointment")
                        { j.Click += new EventHandler(loadAppointment); }
                    }
                    btnDeleteAppointment.Hide();
                    lblDuration.Hide();
                    lblCost.Hide();
                    btnAddAppointment.Hide();

                    if (cklTreatments.CheckedItems.Count == 0 && cboRoom.Items.Count == 3)
                    {
                        cboRoom.Items.Add("Nail Bar");
                    }
                    else if (cklTreatments.CheckedItems.Count == 1 && cklTreatments.CheckedItems[0].ToString() == "Nails" && cboRoom.Items.Count == 3)
                    {
                        cboRoom.Items.Add("Nail Bar");
                    }
                }
            }
            else if (isEditing == true)
            {
                if (areFieldsEnabled())
                { 
                    i = MessageBox.Show("Are you sure you want to discard changes to this appointment?", "Confirm Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (i == DialogResult.Yes)
                    {
                        clearFields();
                        disableFields();
                        pbgSchedule.AddStaffSchedule(dtpAppointmentDate.Value);
                        foreach (Control j in pbgSchedule.Controls)
                        {
                            if (j.Name == "appointment")
                            { j.Click += new EventHandler(loadAppointment); }
                        }

                        btnDeleteAppointment.Hide();
                        btnAddAppointment.Hide();
                        lblDuration.Hide();
                        lblCost.Hide();
                        isEditing = false;

                        if (cklTreatments.CheckedItems.Count == 0 && cboRoom.Items.Count == 3)
                        {
                            cboRoom.Items.Add("Nail Bar");
                        }
                        else if (cklTreatments.CheckedItems.Count == 1 && cklTreatments.CheckedItems[0].ToString() == "Nails" && cboRoom.Items.Count == 3)
                        {
                            cboRoom.Items.Add("Nail Bar");
                        }
                    }
                }
                else
                {
                    i = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (i == DialogResult.Yes)
                    {
                        clearFields();
                        deleteAppointment();
                        disableFields();
                        pbgSchedule.AddStaffSchedule(dtpAppointmentDate.Value);
                        foreach (Control j in pbgSchedule.Controls)
                        {
                            if (j.Name == "appointment")
                            { j.Click += new EventHandler(loadAppointment); }
                        }

                        btnDeleteAppointment.Hide();
                        btnAddAppointment.Hide();
                        lblDuration.Hide();
                        lblCost.Hide();
                        isEditing = false;

                        if (cklTreatments.CheckedItems.Count == 0 && cboRoom.Items.Count == 3)
                        {
                            cboRoom.Items.Add("Nail Bar");
                        }
                        else if (cklTreatments.CheckedItems.Count == 1 && cklTreatments.CheckedItems[0].ToString() == "Nails" && cboRoom.Items.Count == 3)
                        {
                            cboRoom.Items.Add("Nail Bar");
                        }
                    }
                }
                
            }
            
        }

        private void dtpAppointmentTime_ValueChanged(object sender, EventArgs e)
        {
            if (update == true)
            { UpdatePreviewAppointment(); }
        }

        private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == true)
            { UpdatePreviewAppointment(); }
        }

        private void cboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == true)
            { UpdatePreviewAppointment(); }
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (update == true)
            { UpdatePreviewAppointment(); }
        }

        private void cklTreatments_SelectedIndexChanged(object sender, EventArgs e) //Controls the adding and removing of the "Nail Bar" option
        {
            if (update == true)
            { UpdatePreviewAppointment(); }
            if (cklTreatments.CheckedItems.Count == 0 && cboRoom.Items.Count == 3)
            {
                cboRoom.Items.Add("Nail Bar");
            }
            else if (cklTreatments.CheckedItems.Count == 1 && cklTreatments.CheckedItems[0].ToString() == "Nails" && cboRoom.Items.Count == 3)
            {
                cboRoom.Items.Add("Nail Bar");
            }
            else if (cklTreatments.CheckedItems.Count == 1 && cklTreatments.CheckedItems[0].ToString() != "Nails" && cboRoom.Items.Count == 4)
            {
                if (cboRoom.SelectedIndex == 3)
                { MessageBox.Show("You cannot book an appointment that has a non-nail treatment in the Nail Bar. The Nail Bar option will now be removed.", "Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                cboRoom.Items.Remove(cboRoom.Items[3]);
            }
            else if (cklTreatments.CheckedItems.Count > 1 && cboRoom.Items.Count == 4)
            {
                if (cboRoom.SelectedIndex == 3)
                { MessageBox.Show("You cannot book an appointment that has a non-nail treatment in the Nail Bar. The Nail Bar option will now be removed.", "Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                cboRoom.Items.Remove(cboRoom.Items[3]);
            }
        }

        private void UpdatePreviewAppointment() //Controls verification on double-booking customers, staff, rooms, etc.
        {
            if (cboStaff.SelectedIndex >= 0 && dtpAppointmentDate.Value >= DateTime.Today && areFieldsEnabled())
            {
                int j = 0;
                foreach (int i in cklTreatments.CheckedIndices)
                {
                    j += new dal.Treatments().getTreatmentsByID(i).TreatmentDuration;
                }

                if (dtpAppointmentTime.Value < new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, 09, 00, 00))
                {
                    MessageBox.Show("You cannot book an appointment before the store opens. Please select a later time.");
                    dtpAppointmentTime.Value = dateTime;
                }
                else if (dtpAppointmentTime.Value.AddMinutes(j) > new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, 17, 00, 00))
                {
                    MessageBox.Show("You cannot book an appointment that runs into closing time. Please select an earlier time.");
                    dtpAppointmentTime.Value = dateTime;
                }
                else
                {
                    int l = -1;
                    DateTime i = new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, dtpAppointmentTime.Value.Hour, dtpAppointmentTime.Value.Minute, 0);
                    if (isEditing == false)
                    {
                        pbgSchedule.AddPreviewAppointmentPictureBox(i, j, cboStaff.SelectedIndex);
                        foreach (Control k in pbgSchedule.Controls)
                        {
                            if (k.Tag != null && k.Tag.ToString() == "Preview")
                            {
                                l = pbgSchedule.Controls.IndexOf(k);
                            }
                        }
                    }
                    else
                    {
                        foreach (Control k in pbgSchedule.Controls)
                        {
                            if (k.Tag != null && k.Name.ToString() == "appointment" && Convert.ToInt32(k.Tag) == appointment)
                            {
                                l = pbgSchedule.Controls.IndexOf(k);
                            }
                        }

                        if (j == 0)
                        { j = 1; }

                        pbgSchedule.Controls[l].Location = new System.Drawing.Point(Convert.ToInt32((i - new DateTime(i.Year, i.Month, i.Day, 09, 00, 00)).TotalMinutes) * pbgSchedule.Width / 480 + 1, cboStaff.SelectedIndex * pbgSchedule.Height / 4 + 1);
                        pbgSchedule.Controls[l].Size = new System.Drawing.Size(j * pbgSchedule.Width / 480, pbgSchedule.Height / 4);
                    }

                    foreach (Control k in pbgSchedule.Controls)
                    {
                        if (l != -1 && k != pbgSchedule.Controls[l] && k.Name == "appointment" && k.Bounds.IntersectsWith(pbgSchedule.Controls[l].Bounds))
                        {
                            MessageBox.Show("You cannot book an appointment that overlaps with another appointment. Please select a different time.");
                            Reset();                            
                        }
                        if (l != -1 && k.Name == "Staff" && k.Bounds.IntersectsWith(pbgSchedule.Controls[l].Bounds))
                        {
                            objects.Staff m = new dal.Staff().getStaffFromID(Convert.ToInt32(k.Tag));
                            MessageBox.Show("Sorry, " + m.StaffForename + " " + m.StaffSurname + " is not working at these times. Please select another time or date.");
                            Reset();                            
                        }
                        if (l != -1 && k != pbgSchedule.Controls[l] && k.Name == "appointment" && !(pbgSchedule.Controls[l].Location.X + pbgSchedule.Controls[l].Width < k.Location.X || pbgSchedule.Controls[l].Location.X > k.Location.X + k.Width))
                        {
                            objects.Appointments appointment = new dal.Appointments().getAppointmentByID(Convert.ToInt32(k.Tag));
                            List<objects.Customers> customers;
                            if (isEditing == true)
                            {
                                customers = new dal.Customers().getListOfCustomers();
                            }
                            else
                            {
                                customers = new dal.Customers().getListOfCustomersWhereNotArchived();
                            }
                            if (cboCustomers.SelectedIndex != -1 && customers[cboCustomers.SelectedIndex].CustomerID == appointment.Customer)
                            {
                                DialogResult m = MessageBox.Show("This customer already has an appointment at the same time. Are you sure you want to double book this customer?", "Confirm Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (m == DialogResult.No)
                                {
                                    Reset();
                                }
                            }
                            if (cboRoom.SelectedIndex != -1 && cboRoom.SelectedIndex + 1 == appointment.Room && !(new dal.Rooms().getRoomsFromID(appointment.Room).NailBar))
                            {
                                MessageBox.Show("You cannot book an appointment for the same room at the same time. Please select another room.", "Room Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Reset();
                            }
                        }
                    }
                    dateTime = dtpAppointmentTime.Value;
                    staff = cboStaff.SelectedIndex;
                    room = cboRoom.SelectedIndex;
                    customer = cboCustomers.SelectedIndex;
                    treatments.Clear();
                    foreach (int m in cklTreatments.CheckedIndices)
                    {
                        treatments.Add(m);
                    }

                    int cost = 0;
                    j = 0;
                    foreach (int k in cklTreatments.CheckedIndices)
                    {
                        objects.Treatments treatments = new dal.Treatments().getTreatmentsByID(k);
                        j += treatments.TreatmentDuration;
                        cost += treatments.TreatmentCost;
                    }
                    lblDuration.Text = "Duration = " + j + " min";
                    lblCost.Text = "Cost = £" + (new decimal(cost) / 100).ToString("0.00");                   
                }
            }
        }

        public void Reset() //If there was a problem in the above method, this puts everything back to the way it was previously
        {
            dtpAppointmentTime.Value = dateTime;
            cboStaff.SelectedIndex = staff;
            cboCustomers.SelectedIndex = customer;
            cboRoom.SelectedIndex = room;
            foreach (int m in cklTreatments.CheckedIndices)
            {
                cklTreatments.SetItemCheckState(m, CheckState.Unchecked);
            }
            foreach (int m in treatments)
            {
                cklTreatments.SetItemCheckState(m, CheckState.Checked);
            }
            int j = 0;
            foreach (int m in cklTreatments.CheckedIndices)
            {
                j += new dal.Treatments().getTreatmentsByID(m).TreatmentDuration;
            }

            
            DateTime i = new DateTime(dtpAppointmentDate.Value.Year, dtpAppointmentDate.Value.Month, dtpAppointmentDate.Value.Day, dtpAppointmentTime.Value.Hour, dtpAppointmentTime.Value.Minute, 0);
            if (isEditing == false)
            {
                pbgSchedule.AddPreviewAppointmentPictureBox(i, j, cboStaff.SelectedIndex);
            }
            else
            {
                int l = -1;
                foreach (Control k in pbgSchedule.Controls)
                {
                    if (k.Tag != null && k.Name.ToString() == "appointment" && Convert.ToInt32(k.Tag) == appointment)
                    {
                        l = pbgSchedule.Controls.IndexOf(k);
                    }
                }

                if (j == 0)
                { j = 1; }

                pbgSchedule.Controls[l].Location = new System.Drawing.Point(Convert.ToInt32((i - new DateTime(i.Year, i.Month, i.Day, 09, 00, 00)).TotalMinutes) * pbgSchedule.Width / 480 + 1, cboStaff.SelectedIndex * pbgSchedule.Height / 4);
                pbgSchedule.Controls[l].Size = new System.Drawing.Size(j * pbgSchedule.Width / 480, pbgSchedule.Height / 4);
            }
        }

        public override void picCosmetics_Click(object sender, EventArgs e)
        {
            if (areFieldsEnabled() == true)
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
            if (areFieldsEnabled() == true)
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (areFieldsEnabled() == true) //Asks the user if they're sure they want to exit
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
    }
}