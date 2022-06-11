using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpession
{
    public class UserRegistration
    {
        public Regex FirstNameR = new Regex(@"^[A-Z]{1}[a-zA-Z]{2,}$");
        public Regex LastNameR = new Regex(@"^[A-Z]{1}[a-zA-Z]{2,}$");
        public Regex EmailR = new Regex(@"^[a-z]{3,}([.]{1}[a-z]{3,})?@bl.co([.]{1}[a-z]{2})?$");
        public Regex MobileNoR = new Regex(@"^[0-9]{2}[ ][6-9]{1}[0-9]{9}$");
        public Regex PasswordR = new Regex(@"^[a-zA-Z0-9]{8,}$");
       
        public string validFirstName(string FirstName)
        {

            if (FirstNameR.IsMatch(FirstName))
                return "First Name is valid";             
            else
               
                return "First Name is not valid";
        }
        public string validLastName(string LastName)
        {
            if (FirstNameR.IsMatch(LastName))
                return "Last Name is valid";
            else
                return "Last Name is not valid";
        }
        public string validEmail(string Email)
        {
            if (EmailR.IsMatch(Email))
                return "EmailId is valid";
            else
                return "EmailID is not valid";
        }
        public string validMobileNo(string MobileNo)
        {
            if (MobileNoR.IsMatch(MobileNo))
                return "MobileNo is valid";
            else
                return "MobileNo is not valid";
        }
        public string validPassword(string Password)
        {
            if (PasswordR.IsMatch(Password))
                return "Password is valid";
            else
                return "Password is not valid";
        }
       
    }
}

