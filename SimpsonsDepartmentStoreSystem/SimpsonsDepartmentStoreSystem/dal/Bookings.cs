using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace SimpsonsDepartmentStoreSystem.dal
{
    public class Bookings
    {
        public Bookings()
        { }

        private objects.Bookings getBookingsFromReader(SqlDataReader i) //Fills the Booking object with data from the data reader
        {
            objects.Bookings j = new objects.Bookings(i.GetInt32(0), i.GetInt32(1));
            return j;
        }

        public List<objects.Bookings> getListOfBookings() //Gets a list of all bookings
        {
            List<objects.Bookings> i = new List<objects.Bookings>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Bookings";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getBookingsFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }

        public List<objects.Bookings> getListOfBookingsByAppointmentID(int j) //Gets a list of all bookings for a specific Appointment
        {
            List<objects.Bookings> i = new List<objects.Bookings>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Bookings where AppointmentID = " + j;
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getBookingsFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }

        public void addBooking (int i, int j)
        { new objects.Database().executeSQLCommand("insert into Bookings values ('" + i + "', '" + j + "')"); }

        public void deleteBookingByAppointmentID(int i)
        {
            new objects.Database().executeSQLCommand("delete from Bookings where AppointmentID = " + i);
        }
    }
}
