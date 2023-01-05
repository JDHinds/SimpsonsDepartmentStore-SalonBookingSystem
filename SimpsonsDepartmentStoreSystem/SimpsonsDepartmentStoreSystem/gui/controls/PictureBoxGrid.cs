using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpsonsDepartmentStoreSystem.gui.controls
{
    class PictureBoxGrid : Control
    {

        List<objects.Staff> staff;
        ToolTip tip;

        public PictureBoxGrid() : base()
        {
            
        }

        public void setup() //Sets up control for use
        {
            staff = new dal.Staff().getListOfStaffFromReader();
            BackColor = Color.FromArgb(67, 209, 95);
            tip = new ToolTip();
        }

        public void AddStaffSchedule(DateTime date) //Loads appointments in by staff
        {
            for (int i = Controls.Count - 1; i >= 0; i--)
            {
                Controls[i].Dispose();
            }

            AddGrid(8, staff.Count);

            if (isHoliday(date))
            {
                AddNotAvailablePictureBox(0, 0, Width, Height, -1);
            }
            else
            {

                for (int i = 0; i < staff.Count; i++)
                {
                    if (date.DayOfWeek == DayOfWeek.Friday)
                    {
                        if (staff[i].StaffTimes == 0 || staff[i].StaffTimes == 1)
                        {
                            AddNotAvailablePictureBox(0, i * Height / staff.Count + 1, Width, Height / staff.Count, staff[i].StaffID);
                        }
                        else
                        {
                            AddNotAvailablePictureBox(225 * Width / 480 + 1, i * Height / staff.Count + 1, 30 * Width / 480, Height / staff.Count, staff[i].StaffID);
                        }
                    }
                    else
                    {
                        if (staff[i].StaffTimes == 0)
                        {
                            AddNotAvailablePictureBox(0, i * Height / staff.Count + 1, 240 * Width / 480, Height / staff.Count, staff[i].StaffID);
                        }
                        else if (staff[i].StaffTimes == 1)
                        {
                            AddNotAvailablePictureBox(240 * Width / 480, i * Height / staff.Count + 1, 240 * Width / 480, Height / staff.Count, staff[i].StaffID);
                        }
                        else
                        {
                            AddNotAvailablePictureBox(225 * Width / 480, i * Height / staff.Count + 1, 30 * Width / 480, Height / staff.Count, staff[i].StaffID);
                        }
                    }

                    List<objects.Appointments> appointments = new dal.Appointments().getDaysAppointmentsByStaffID(staff[i].StaffID, date);

                    for (int j = 0; j < appointments.Count; j++)
                    {
                        double k = (appointments[j].AppointmentTime - new DateTime(date.Year, date.Month, date.Day, 09, 00, 00)).TotalMinutes;
                        List<objects.Bookings> l = new dal.Bookings().getListOfBookingsByAppointmentID(appointments[j].AppointmentID);

                        int m = 0;
                        int n = 0;

                        for (int o = 0; o < l.Count; o++)
                        {
                            objects.Treatments p = new dal.Treatments().getTreatmentsByID(l[o].Treatment);

                            m += p.TreatmentDuration;
                            n += p.TreatmentCost;
                        }

                        if (m == 0)
                        { m = 1; }

                        AddAppointmentLabel(Convert.ToInt32(k * Width / 480), i * Height / staff.Count + 1, m * Width / 480, Height / staff.Count, appointments[j], n);
                    }
                }
            }
        }

        private void AddGrid(int x, int y) //Adds the grid to the form
        {

            for (int i = 0; i < y; i++)
            {
                AddPictureBox(0, i * Height / y, Width, 1, Color.FromArgb(0, 0, 0));
            }

            AddPictureBox(0, Height - 1, Width, 1, Color.FromArgb(0, 0, 0));

            for (double i = 0; i < x; i++)
            {
                AddPictureBox(Convert.ToInt32((i + 0.75) * Width / x), 0, 1, Height, Color.FromArgb(170, 170, 170));
                AddPictureBox(Convert.ToInt32((i + 0.25) * Width / x), 0, 1, Height, Color.FromArgb(170, 170, 170));                
                AddPictureBox(Convert.ToInt32((i + 0.5) * Width / x), 0, 1, Height, Color.FromArgb(128, 128, 128));
                AddPictureBox(Convert.ToInt32(i * Width / x), 0, 1, Height, Color.FromArgb(0, 0, 0));
            }

            AddPictureBox(Width - 1, 0, 1, Height, Color.FromArgb(0, 0, 0));            
        }

        private void AddPictureBox(int x, int y, int i, int j, Color colour)
        {
            PictureBox k = new PictureBox();
            k.Location = new Point(x, y);
            k.Size = new Size(i, j);
            k.BackColor = colour;
            k.Name = "Grid";
            Controls.Add(k);
            k.SendToBack();
        }

        private void AddAppointmentLabel(int x, int y, int i, int j, objects.Appointments appointment, int price)
        {
            objects.Customers customer = new dal.Customers().getCustomerFromID(appointment.Customer);
            objects.Rooms room = new dal.Rooms().getRoomsFromID(appointment.Room);

            Label m = new Label();
            m.Text = customer.CustomerForename + " " + customer.CustomerSurname + "\n";
            if (room.NailBar == true)
            {
                m.Text += "Nail Bar";
            }
            else
            {
                m.Text += "Room " + room.RoomNumber.ToString();
            }
            m.Text += "\n£" + (new decimal(price) / 100).ToString("0.00");
            m.Font = new Font("Microsoft Sans Serif", 14.25F);
            m.AutoSize = false;
            m.TextAlign = ContentAlignment.MiddleCenter;
            m.Tag = appointment.AppointmentID;

            m.Location = new Point(x, y);
            m.Size = new Size(i, j);
            m.BackColor = Color.FromArgb(235, 64, 52);
            m.Cursor = Cursors.Hand;

            m.Name = "appointment";


            m.MouseHover += new EventHandler(AppointmentDetails);
            Controls.Add(m);
            m.BringToFront();
        }

        public void AddPreviewAppointmentPictureBox(DateTime i, int j, int id)
        {
            int k = new dal.Staff().getListOfStaffFromReader().Count;
            foreach (Control control in Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "Preview")
                {
                    Controls.Remove(control);
                    control.Dispose();
                }
            }
            PictureBox l = new PictureBox();
            l.Location = new Point(Convert.ToInt32((i - new DateTime(i.Year, i.Month, i.Day, 09, 00, 00)).TotalMinutes) * Width / 480 + 1, id * Height / k + 1);
            if (j == 0)
            { j = 1; }
            l.Size = new Size(j * Width / 480, Height / k);
            l.BackColor = Color.FromArgb(196, 112, 106);
            l.Tag = "Preview";
            Controls.Add(l);
        }

        private void AddNotAvailablePictureBox(int x, int y, int i, int j, int id)
        {
            PictureBox k = new PictureBox();
            k.Name = "Staff";
            k.Location = new Point(x, y);
            k.Size = new Size(i, j);
            k.BackColor = Color.FromArgb(62, 63, 71);
            k.Tag = id;
            k.Click += new EventHandler(StaffMessageBox);
            Controls.Add(k);
            k.SendToBack();
        }

        private void StaffMessageBox(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((Control)sender).Tag) == -1)
            {
                MessageBox.Show("Sorry, the salon will not be open on this date. Please select another day.");
            }
            else
            {
                objects.Staff i = new dal.Staff().getStaffFromID(Convert.ToInt32(((Control)sender).Tag));
                MessageBox.Show("Sorry, " + i.StaffForename + " " + i.StaffSurname + " is not working at these times. Please select another time or date.");
            }
        }

        private void AppointmentDetails(object sender, EventArgs e)
        {
            tip.SetToolTip((Control)sender, ((Control)sender).Text);
        }

        private bool isHoliday(DateTime i)
        {
            if ((i.Day == 1 && i.Month == 1) || (i.Day == 17 && i.Month == 3) || (i.Day == 25 && i.Month == 12) || (i.Day == 26 && i.Month == 12))
            { return true; }
            return false;
        }
    }
}