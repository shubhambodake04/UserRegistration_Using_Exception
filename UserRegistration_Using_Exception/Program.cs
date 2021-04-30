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
            bool result = pattern.ValidateFirstName("");
            

            try
            { 
             if(result != true)
                {
                    throw new Exception("Input string is not in correct format");
                }

             Console.WriteLine(result);
            
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
     }
 }

