using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SimpsonsDepartmentStoreSystem.dal
{
    public class Appointments
    {
        public Appointments()
        { }

        private objects.Appointments getAppointmentsFromReader(SqlDataReader i) //Fills the Appointment object with data from the data reader
        {
            objects.Appointments j = new objects.Appointments(i.GetInt32(0), i.GetInt32(1), i.GetInt32(2), i.GetInt32(3), i.GetDateTime(4));
            return j;
        }

        public List<objects.Appointments> getListOfAppointments() //Gets a list of all appointments
        {
            List<objects.Appointments> i = new List<objects.Appointments>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Appointments";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getAppointmentsFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }

        public objects.Appointments getAppointmentByID(int j) //Gets a singular appointment by its appointment ID
        {          
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Appointments where AppointmentID = " + j.ToString();
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            {
                objects.Appointments i = getAppointmentsFromReader(db.Rdr);
                db.Rdr.Close();
                return i;
            }
            return new objects.Appointments();
        }

        public List<objects.Appointments> getDaysAppointmentsByStaffID(int j, DateTime date) //Gets all the appointments for staff and day => important for building the schedule
        {
            List<objects.Appointments> i = new List<objects.Appointments>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Appointments where StaffID = " + j + " and cast(AppointmentTime as DATE) = '" + date.ToString("yyyy-MM-dd") + "'";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getAppointmentsFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }

        public List<objects.Appointments> getListOfAppointmentsByCustomerID(int j) //Gets all the appointments for a customer => for checking if an onvoice can be created
        {
            List<objects.Appointments> i = new List<objects.Appointments>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Appointments where CustomerID = " + j;
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getAppointmentsFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }

        public List<objects.Appointments> getListOfAppointmentsByCustomerIDAfterNow(int j) //Gets all the appointments that happen after now => for deleting them if a customer is archived
        {
            List<objects.Appointments> i = new List<objects.Appointments>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Appointments where CustomerID = " + j + " and AppointmentTime > '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "'";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getAppointmentsFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }

        public int addAndReturnAppointmentID(int i, int j, int k, DateTime l) //For adding appointments => it's important to get the id back to make bookings (appointment + treatment)
        {
            List<objects.Appointments> appointments = getListOfAppointments();
            int m;
            if (appointments.Count == 0)
            { m = 0; }
            else
            { m = appointments[appointments.Count - 1].AppointmentID + 1; }           
            new objects.Database().executeSQLCommand("insert into Appointments values(" + m + ", '" + i + "', '" + j + "', '" + k + "', '" + l.ToString("yyyy-MM-dd HH:mm:ss") + "')");
            return m;
        }

        public void editAppointment(int i, int j, int k, DateTime l, int m)
        {
            new objects.Database().executeSQLCommand("update Appointments set CustomerID = '" + i + "', StaffID = '" + j + "', RoomNumber = '" + k + "', AppointmentTime = '" + l.ToString("yyyy-MM-dd HH:mm:ss") + "' where AppointmentID = '" + m + "'");
        }

        public void deleteAppointment(int i)
        {
            objects.Database j = new objects.Database();
            j.executeSQLCommand("delete from Bookings where AppointmentID = " + i);
            j.executeSQLCommand("delete from Appointments where AppointmentID = " + i);
        }
    }
}