using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SimpsonsDepartmentStoreSystem.dal
{
    public class Customers
    {
        public Customers()
        {}

        private objects.Customers getCustomersFromReader(SqlDataReader i) //Fills the customer object with data from the data reader
        {
            objects.Customers j = new objects.Customers(i.GetInt32(0), makeCSharpSafe(i.GetString(1)), makeCSharpSafe(i.GetString(2)), makeCSharpSafe(i.GetString(3)),  makeCSharpSafe(i.GetString(4)), makeCSharpSafe(i.GetString(5)), makeCSharpSafe(i.GetString(6)), makeCSharpSafe(i.GetString(7)), makeCSharpSafe(i.GetString(8)), i.GetString(9), i.GetDateTime(10), i.GetBoolean(11), i.GetBoolean(12));
            return j;
        }

        public objects.Customers getCustomerFromID(int j) //Gets the customer with a specific ID
        {
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Customers where CustomerID = " + j.ToString();
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { 
                objects.Customers i = getCustomersFromReader(db.Rdr);
                db.Rdr.Close();
                return i;
            }
            return new objects.Customers();
        }

        public List<objects.Customers> getListOfCustomers() //Gets all customers
        {
            List<objects.Customers> i = new List<objects.Customers>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Customers";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getCustomersFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }

        public List<objects.Customers> getListOfCustomersWhereNotArchived() //Gets all customers that haven't been "deleted" i.e. archived
        {
            List<objects.Customers> i = new List<objects.Customers>();
            objects.Database db = new objects.Database();
            db.connect();

            db.Cmd = db.Con.CreateCommand();
            db.Cmd.CommandText = "select * from Customers where CustomerArchived = 0";
            db.Rdr = db.Cmd.ExecuteReader();

            while (db.Rdr.Read())
            { i.Add(getCustomersFromReader(db.Rdr)); }
            db.Rdr.Close();

            return i;
        }

        public void addCustomer(objects.Customers i) //Adds a customer
        {
            List<objects.Customers> customers = getListOfCustomers();
            int j;
            if (customers.Count == 0)
            { j = 0; }
            else
            { j = customers[customers.Count - 1].CustomerID + 1; }
            string k = "insert into Customers values (" + j + ", '" + makeSQLSafe(i.CustomerTitle) + "', '" + makeSQLSafe(i.CustomerForename) + "', '" + makeSQLSafe(i.CustomerSurname) + "', '" + makeSQLSafe(i.CustomerAddressLine1) + "', '" + makeSQLSafe(i.CustomerAddressLine2) + "', '" + makeSQLSafe(i.CustomerAddressCounty) + "', '" + makeSQLSafe(i.CustomerAddressPostcode) + "', '" + makeSQLSafe(i.CustomerEmail) + "', '" + i.CustomerPhoneNumber + "', '" + i.CustomerDateOfBirth.Date.ToString("yyyy-MM-dd") + "', ";
            if (i.CustomerSurvey == true)
            { k += "1"; }
            else
            { k += "0"; }
            k += ", 0)";
            new objects.Database().executeSQLCommand(k);
        }

        public void editCustomer(objects.Customers i) //Edits a customer
        {
            string j = "update Customers set CustomerTitle = '" + makeSQLSafe(i.CustomerTitle) + "', CustomerForename = '" + makeSQLSafe(i.CustomerForename) + "', CustomerSurname = '" + makeSQLSafe(i.CustomerSurname) + "', CustomerAddressLine1 = '" + makeSQLSafe(i.CustomerAddressLine1) + "', CustomerAddressLine2 = '" + makeSQLSafe(i.CustomerAddressLine2) + "', CustomerAddressCounty = '" + makeSQLSafe(i.CustomerAddressCounty) + "', CustomerAddressPostcode = '" + makeSQLSafe(i.CustomerAddressPostcode) + "', CustomerEmail = '" + makeSQLSafe(i.CustomerEmail) + "', CustomerPhoneNumber = '" + i.CustomerPhoneNumber + "', CustomerDateOfBirth = '" + i.CustomerDateOfBirth.ToString("yyyy-MM-dd") + "', CustomerArchived = ";

            if (i.CustomerArchived == true) //this code is required as SQL does not have a bool => it has a 'bit', which stores null, 0 or 1. Therefore, a "true" or "false" cannot be used in the query.
            { j += "1"; }
            else
            { j += "0"; }

            j += ", CustomerSurvey = ";
            if (i.CustomerSurvey == true)
            { j += "1"; }
            else
            { j += "0"; }

            j += " where CustomerID = " + i.CustomerID;

            objects.Database db = new objects.Database();
            db.executeSQLCommand(j);

            if (i.CustomerArchived == true)
            {
                dal.Appointments k = new dal.Appointments();
                List<objects.Appointments> l = k.getListOfAppointmentsByCustomerIDAfterNow(i.CustomerID);
                foreach (objects.Appointments m in l)
                {
                    k.deleteAppointment(m.AppointmentID);
                }
            } 
        }

        public void deleteCustomer(int i)
        {
            new objects.Database().executeSQLCommand("update Customers set CustomerArchived = 1 where CustomerID = " + i);
        }


        private string makeSQLSafe(string i) //These methods are to change any apostrophies used in names and places into a sql-safe alternative.
        {
            return i.Replace('\'', '|');
        }

        private string makeCSharpSafe(string i) //When the data is read back into c#, it changes it back to an apostrophy.
        {
           return i.Replace('|', '\'');
        }
    }
}