using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_Using_Exception
{
    class Program
    {
        static void Main(string[] args)
        {

            Pattern pattern = new Pattern();
            bool result = pattern.ValidateFirstName("Shubham");
            bool result1 = pattern.ValidateLastName("Bodake");
            bool result2 = pattern.ValidateEmail("Shubham@gmail.com");
            bool result3 = pattern.ValidateMobileNumber("91 7757929383");
            bool result4 = pattern.ValidatePasswordRule1("shubhambodake");
            bool result5 = pattern.ValidatePasswordRule2("Shubhambodake");
            bool result6 = pattern.ValidatePasswordRule2("");
            try
            { 
                if(result != true)
                {
                    throw new Exception("Input string is not in correct format");
                }

                Console.WriteLine(result);

                if (result1 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }
                Console.WriteLine(result1);

                if (result2 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }
                Console.WriteLine(result2);

                if (result3 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }
                Console.WriteLine(result3);

                if (result4 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }
                Console.WriteLine(result4);

                if (result5 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }
                Console.WriteLine(result5);

                if (result6 != true)
                {
                    throw new Exception("Input string is not in correct format");
                }
                Console.WriteLine(result6);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
     }
 }


