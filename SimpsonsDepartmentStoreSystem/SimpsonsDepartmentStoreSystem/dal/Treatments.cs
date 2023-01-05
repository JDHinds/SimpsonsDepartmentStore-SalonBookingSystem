using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SimpsonsDepartmentStoreSystem.dal
{
    public class Treatments
    {
        public Treatments()
        { }

        private objects.Treatments getTreatmentsFromReader(SqlDataReader i)
        {
            objects.Treatments j = new objects.Treatments(i.GetInt32(0), i.GetString(1), i.GetInt32(2), i.GetInt32(3));
            return j;
        }

        public objects.Treatments getTreatmentsByID(int j)
        {
            objects.Treatments i = new objects.Treatments();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Treatments where TreatmentID = " + j.ToString();
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i = getTreatmentsFromReader(db.Rdr); }
            db.Rdr.Close();

            return i;
        }

        public List<objects.Treatments> getListOfTreatmentsFromReader()
        {
            List<objects.Treatments> i = new List<objects.Treatments>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Treatments";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getTreatmentsFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }
    }
}
