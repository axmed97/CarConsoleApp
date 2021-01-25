using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    public class Car
    {
        public string Makra;
        public string Model;
        public decimal MaxFuel;
        public decimal CurrentFuel;
        private decimal FuelEffect;
        private decimal LokalKm = 0;
        private decimal GlobalKm = 0;
        public Car(string marka, string model, decimal maxFuel = 80, decimal currentFuel = 60, decimal fuelEffect = 12 )
        {
            this.Makra = marka;
            this.Model = model;
            this.MaxFuel = maxFuel;
            this.CurrentFuel = currentFuel;
            this.FuelEffect = fuelEffect;
        }
        public void Go()
        {
            int b = 0;
            while (b == 0)
            {
                Console.Write("How many km do you want to go?: ");
                string neededKm = Console.ReadLine();
                decimal needL = 0;
                if (Utilities.IsNumber(neededKm))
                {
                    decimal needIntKm = Convert.ToDecimal(neededKm);
                    if (CurrentFuel >= needIntKm / 100 * FuelEffect)
                    {
                        CurrentFuel -= needIntKm / 100 * FuelEffect;
                        Console.WriteLine($"You drove {needIntKm} km and current fuel is {CurrentFuel} l!");
                        b++;
                        LokalKm += needIntKm;
                        GlobalKm += needIntKm;
                    }
                    else
                    {
                        needL = needIntKm / 100 * FuelEffect;
                        Console.WriteLine($"You need {needL} l fuel and you don't have enough fuel. You have to refuel your car!");
                    }
                }
            }
        }
        public void TopUp()
        {
            TopUpStart:
            Console.Write($"How many l do you want fuel? Max Fuel: {MaxFuel} l; Current Fuel {CurrentFuel}!(write needed litr or full)");
            string neededFuel = Console.ReadLine();
            if (neededFuel == "full")
            {
                CurrentFuel = MaxFuel;
                Console.WriteLine($"Good way! Current Fuel is {CurrentFuel} l");
            }
            else if (Utilities.IsNumber(neededFuel))
            {
                decimal fuel = Convert.ToDecimal(neededFuel);
                if (MaxFuel > fuel + CurrentFuel)
                {
                    CurrentFuel += fuel;
                    Console.WriteLine($"Good way! Current Fuel is {CurrentFuel} l");
                }
                else
                {
                    Console.WriteLine($"Needed Fuel more than {MaxFuel} l");
                    goto TopUpStart;
                }
            }
        }
        public void Stop()
        {
            Console.WriteLine($"Local km: {LokalKm}; Global km: {GlobalKm}; Current Fuel: {CurrentFuel};");
        }
        public void Reset()
        {
            LokalKm = 0;
            Console.WriteLine($"Local km: 0");
        }
    }
}
