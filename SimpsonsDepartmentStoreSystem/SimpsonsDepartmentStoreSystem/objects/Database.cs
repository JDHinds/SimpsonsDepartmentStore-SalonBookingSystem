using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SimpsonsDepartmentStoreSystem.objects
{
    public class Database
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader rdr;

        public Database()
        { }

        public bool connect()
        {
            SqlConnectionStringBuilder i = new SqlConnectionStringBuilder();
            string j = Application.StartupPath.Remove(Convert.ToInt16(Application.StartupPath.Length) - 9);

            i.DataSource = "(LocalDB)\\MSSQLLocalDB";
            i.AttachDBFilename = j + "SimpsonsDepartmentStoreDatabase.mdf";
            i.IntegratedSecurity = true;

            con = new SqlConnection(i.ToString());
            try { con.Open(); }
            catch {}

            if (con.State == System.Data.ConnectionState.Open)
            { return true; }
            else
            { return false; }
        }

        public void executeSQLCommand(string i)
        {
            connect();
            Cmd = Con.CreateCommand();
            Cmd.CommandText = i;
            Rdr = Cmd.ExecuteReader();
            Rdr.Close();
        }

        public SqlCommand Cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }

        public SqlConnection Con
        {
            get { return con; }
            set { con = value; }
        }

        public SqlDataReader Rdr
        {
            get { return rdr; }
            set { rdr = value; }
        }
    }
}
