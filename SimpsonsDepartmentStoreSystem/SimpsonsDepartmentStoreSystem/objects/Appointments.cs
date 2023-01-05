using System;

namespace SimpsonsDepartmentStoreSystem.objects
{
    public class Appointments
    {
        int appointmentID;
        int customer;
        int staff;
        int room;
        DateTime appointmentTime;

        public Appointments()
        {

        }

        public Appointments(int appointmentID, int customer, int staff, int room, DateTime appointmentTime)
        {
            AppointmentID = appointmentID;
            Customer = customer;
            Staff = staff;
            Room = room;
            AppointmentTime = appointmentTime;
        }

        public int AppointmentID
        { 
            get { return appointmentID; }
            set { appointmentID = value; }
        }

        public int Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public int Staff
        {
            get { return staff; }
            set { staff = value; }
        }

        public int Room
        {
            get { return room; }
            set { room = value; }
        }

        public DateTime AppointmentTime
        {
            get { return appointmentTime; }
            set { appointmentTime = value; }
        }
    }
}
