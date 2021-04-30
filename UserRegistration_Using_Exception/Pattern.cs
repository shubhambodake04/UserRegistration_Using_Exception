﻿using System;
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

        public bool ValidateFirstName(string input)
        {
            return Regex.IsMatch(input, FIRSTNAME);
        }
        public bool ValidateLastName(string input)
        {
            return Regex.IsMatch(input, LASTNAME);
        }
    }
}
