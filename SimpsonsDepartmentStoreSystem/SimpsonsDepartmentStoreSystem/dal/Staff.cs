using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SimpsonsDepartmentStoreSystem.dal
{
    public class Staff
    {
        public Staff()
        {}

        private objects.Staff getStaffFromReader(SqlDataReader i)
        {
            objects.Staff j = new objects.Staff(i.GetInt32(0), i.GetString(1), i.GetString(2), i.GetString(3), i.GetInt32(4));
            return j;
        }

        public objects.Staff getStaffFromID(int j)
        {
            objects.Staff i = new objects.Staff();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Staff where StaffID = " + j.ToString();
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i = getStaffFromReader(db.Rdr); }
            db.Rdr.Close();

            return i;
        }

        public List<objects.Staff> getListOfStaffFromReader()
        {
            List<objects.Staff> i = new List<objects.Staff>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Staff";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getStaffFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }
    }
}