using System;

namespace SimpsonsDepartmentStoreSystem.objects
{
    public class Customers
    {
        int customerID;
        string customerTitle;
        string customerForename;
        string customerSurname;
        string customerAddressLine1;
        string customerAddressLine2;
        string customerAddressCounty;
        string customerAddressPostcode;
        string customerEmail;
        string customerPhoneNumber;
        DateTime customerDateOfBirth;
        bool customerSurvey;
        bool customerArchived;

        public Customers()
        {
        }

        public Customers(int customerID, string customerTitle, string customerForename, string customerSurname, string customerAddressLine1, string customerAddressLine2, string customerAddressCounty, string customerAddressPostcode, string customerEmail, string customerPhoneNumber, DateTime customerDateOfBirth, bool customerSurvey, bool customerArchived)
        {
            CustomerID = customerID;
            CustomerTitle = customerTitle;
            CustomerForename = customerForename;
            CustomerSurname = customerSurname;
            CustomerAddressLine1 = customerAddressLine1;
            CustomerAddressLine2 = customerAddressLine2;
            CustomerAddressCounty = customerAddressCounty;
            CustomerAddressPostcode = customerAddressPostcode;
            CustomerEmail = customerEmail;
            CustomerPhoneNumber = customerPhoneNumber;
            CustomerDateOfBirth = customerDateOfBirth;
            CustomerSurvey = customerSurvey;
            CustomerArchived = customerArchived;
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string CustomerTitle
        {
            get { return customerTitle; }
            set 
            {
                if (value.Trim() == "")
                { throw new exceptions.IsNull("You have not selected a title. Please select one to continue."); }
                customerTitle = value; 
            }
        }

        public string CustomerForename
        {
            get { return customerForename; }
            set 
            {
                if (value.Trim() == "")
                { throw new exceptions.IsNull("You have not entered a forename. Please enter one to continue."); }

                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsNumber(value[i]))
                    { throw new exceptions.HasNumber("The forename you have entered has a number in it. Please remove it before continuing."); }
                }

                customerForename = value.Trim(); 
            }
        }

        public string CustomerSurname
        {
            get { return customerSurname; }
            set
            {
                if (value.Trim() == "")
                { throw new exceptions.IsNull("You have not entered a surname. Please enter one to continue."); }

                for (int i = 0; i < value.Length; i++)
                {
                    if (Char.IsNumber(value[i]))
                    { throw new exceptions.HasNumber("The surname you have entered has a number in it. Please remove it before continuing."); }
                }
                customerSurname = value.Trim();
            }
        }

        public string CustomerAddressLine1
        {
            get { return customerAddressLine1; }
            set 
            {
                if (value.Trim() == "")
                { throw new exceptions.IsNull("You have entered the first line of the address. Please enter it to continue."); }
                customerAddressLine1 = value; 
            }
        }

        public string CustomerAddressLine2
        {
            get { return customerAddressLine2; }
            set 
            {
                if (value.Trim() == "")
                { throw new exceptions.IsNull("You have not entered the second line of the address. Please enter it to continue."); }
                customerAddressLine2 = value; 
            }
        }

        public string CustomerAddressCounty
        {
            get { return customerAddressCounty; }
            set 
            {
                if (value.Trim() == "")
                { throw new exceptions.IsNull("You have not entered the county of the address. Please enter it to continue."); }
                customerAddressCounty = value; 
            }
        }

        public string CustomerAddressPostcode
        {
            get { return customerAddressPostcode; }
            set 
            {
                if (value.Trim() == "")
                { throw new exceptions.IsNull("You have not entered the postcode of the address. Please enter it to continue."); }
                customerAddressPostcode = value; 
            }
        }

        public string CustomerEmail
        {
            get { return customerEmail; }
            set 
            {
                value.Replace(" ", "");

                if (value.Length < 6)
                { throw new exceptions.IsTooShort("The entered email is too short to actually exist. Please check the email again."); }
                bool j = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == '@')
                    { j = true; }
                }
                if (j == false)
                { throw new exceptions.HasNoAt("The email you have entered has no \"@\" symbol. Please enter a valid email address."); }

                if (value.Substring(value.Length - 4) == ".com" || value.Substring(value.Length - 3) == ".uk" || value.Substring(value.Length - 3) == ".ie" || value.Substring(value.Length - 4) == ".net" || value.Substring(value.Length - 5) == ".info")
                {
                    customerEmail = value;                  
                }
                else { throw new exceptions.HasInvalidDomain("The email you have entered does not belong to a valid website - please check again."); }
            }
        }

        public string CustomerPhoneNumber
        {
            get { return customerPhoneNumber; }
            set 
            {
                value.Replace(" ", "");
                if (value == "")
                { throw new exceptions.IsNull("You have not entered a phone number. Please enter one to continue."); }

                if (value.Length < 11)
                { throw new exceptions.IsTooShort("The entered phone number is too short. Please check the phone number again."); }

                for (int i = 0; i < value.Length; i++)
                {
                    if (!Char.IsDigit(value[i]))
                    { throw new exceptions.HasLetter("The Phone number you have entered has a letter in it. Please remove it before continuing."); }
                }
                customerPhoneNumber = value;
            }
        }

        public DateTime CustomerDateOfBirth
        {
            get { return customerDateOfBirth; }
            set 
            {
                if (DateTime.Compare(value, DateTime.Now) > 0)
                { throw new exceptions.IsAfterToday("You have selected a date that hasn't happened yet as a date of birth. Please double check."); }
                customerDateOfBirth = value; 
            }
        }

        public bool CustomerSurvey
        {
            get { return customerSurvey; }
            set { customerSurvey = value; }
        }

        public bool CustomerArchived
        {
            get { return customerArchived; }
            set { customerArchived = value; }
        }
    }
}
