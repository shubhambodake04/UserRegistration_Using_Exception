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
            bool result2 = pattern.ValidateLastName("Shubham@gmail.com");
            try
            { 
                if(result != true)
                {
                    throw new Exception("Input string is not in correct format");
                }

                Console.WriteLine(result);
                Console.WriteLine(result1);
                Console.WriteLine(result2);

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
     }
 }

