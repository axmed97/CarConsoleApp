using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "M5");

            Console.WriteLine("Welcome, Our Taxi App!");
            Console.WriteLine();
            string keyCode;
            do
            {
                Console.WriteLine("1. Go");
                Console.WriteLine("2. Top Up");
                Console.WriteLine("3. Stop");
                Console.WriteLine("4. Reset");
                Console.WriteLine("5. Exit");
                Console.Write(">>>>");
                keyCode = Console.ReadLine();

                if (Utilities.IsNumber(keyCode))
                {
                    switch (keyCode)
                    {
                        case "1":
                            car.Go();
                            break;
                        case "2":
                            car.TopUp();
                            break;
                        case "3":
                            car.Stop();
                            break;
                        case "4":
                            car.Reset();
                            break;
                        case "5":
                            break;
                        default:
                            Console.WriteLine("Please enter number between 1 and 5!");
                            break;
                    }
                }
            } while (keyCode != "4");
            

            
        }
    }
}
