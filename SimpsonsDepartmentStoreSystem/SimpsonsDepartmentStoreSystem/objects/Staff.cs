using System;

namespace SimpsonsDepartmentStoreSystem.objects
{
    public class Staff
    {
        int staffID;
        string staffTitle;
        string staffForename;
        string staffSurname;
        int staffTimes;

        public Staff()
        {
            StaffID = 0;
            StaffTitle = "";
            StaffForename = "";
            StaffSurname = "";
            StaffTimes = -1;
        }

        public Staff(int staffID, string staffTitle, string staffForename, string staffSurname, int staffTimes)
        {
            StaffID = staffID;
            StaffTitle = staffTitle;
            StaffForename = staffForename;
            StaffSurname = staffSurname;
            StaffTimes = staffTimes;
        }

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string StaffTitle
        {
            get { return staffTitle; }
            set { staffTitle = value; }
        }

        public string StaffForename
        {
            get { return staffForename; }
            set { staffForename = value; }
        }

        public string StaffSurname
        {
            get { return staffSurname; }
            set { staffSurname = value; }
        }

        public int StaffTimes
        {
            get { return staffTimes; }
            set { staffTimes = value; }
        
        }
    }
}
