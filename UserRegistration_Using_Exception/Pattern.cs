using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration_Using_Exception
{
    public class Pattern
    {
        public string FIRSTNAME = "^[A-Z][a-z]{2,}$";
        public string LASTNAME = "^[A-Z][a-z]{2,}$";
        public string EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public string MOBILENUMBER = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        public string PASSWORDRULE1 = "^[a-zA-Z]{8,}$";
        public string PASSWORDRULE2 = "^[A-Z]+[a-zA-Z]{8,}$";
        public bool ValidateFirstName(string input)
        {
            return Regex.IsMatch(input, FIRSTNAME);
        }
        public bool ValidateLastName(string input)
        {
            return Regex.IsMatch(input, LASTNAME);
        }
        public bool ValidateEmail(string input)
        {
            return Regex.IsMatch(input, EMAIL);
        }
        public bool ValidateMobileNumber(string input)
        {
            return Regex.IsMatch(input, MOBILENUMBER);
        }
        public bool ValidatePasswordRule1(string input)
        {
            return Regex.IsMatch(input, PASSWORDRULE1);
        }
        public bool ValidatePasswordRule2(string input)
        {
            return Regex.IsMatch(input, PASSWORDRULE2);
        }
    }
}
