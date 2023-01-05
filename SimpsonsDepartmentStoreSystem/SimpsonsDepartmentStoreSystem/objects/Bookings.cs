using System;

namespace SimpsonsDepartmentStoreSystem.objects
{
    public class Bookings
    {
        int appointment;
        int treatment;

        public Bookings()
        { }

        public Bookings(int appointment, int treatment)
        {
            Appointment = appointment;
            Treatment = treatment;
        }

        public int Appointment
        {
            get { return appointment; }
            set { appointment = value; }
        }

        public int Treatment
        {
            get { return treatment; }
            set { treatment = value; }
        }
    }
}
