using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    static public class Utilities
    {
        public static bool IsNumber(string number)
        {
            try
            {
                Convert.ToDecimal(number);
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter only number!");
                return false;
            }
        }
    }
}
