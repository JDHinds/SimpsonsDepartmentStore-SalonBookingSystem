using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SimpsonsDepartmentStoreSystem.dal
{
    public class Rooms
    {
        public Rooms()
        {}

        private objects.Rooms getRoomsFromReader(SqlDataReader i)
        {
            objects.Rooms j = new objects.Rooms(i.GetInt32(0), i.GetBoolean(1));
            return j;
        }

        public objects.Rooms getRoomsFromID(int j)
        {
            objects.Rooms i = new objects.Rooms();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Rooms where RoomNumber = " + j.ToString();
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i = getRoomsFromReader(db.Rdr); }
            db.Rdr.Close();

            return i;
        }

        public List<objects.Rooms> getListOfRoomsFromReader()
        {
            List<objects.Rooms> i = new List<objects.Rooms>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Rooms";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getRoomsFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }
    }
}
