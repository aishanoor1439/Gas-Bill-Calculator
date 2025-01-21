using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Bill_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Customer Type(Domestic/Commercial):");
            string type = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Gas Pressure:");
            double pressure = double.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("Enter Total Billing Units:");
            int units = int.Parse(Console.ReadLine());

            double unitCost = 0; double extraCharge = 0; double taxRate = 0; double totalBill = 0; double tax = 0; double finalBill = 0;

            if (type == "domestic")
            {
                if (units < 100)
                {
                    unitCost = 15;
                }
                else if (units >= 100 && units <= 150)
                {
                    unitCost = 16;
                }
                else if (units > 150 && units < 250)
                {
                    unitCost = 17;
                }
                else if (units > 250)
                {
                    unitCost = 18;
                }
                if (pressure > 100)
                {
                    extraCharge = ((pressure - 100) / 50)) * 0.50 * units;
                }
                taxRate = 0.05;
            }
            if (type == "commercial")
            {
                if (units < 100)
                {
                    unitCost = 28;
                }
                else if (units >= 100 && units <= 150)
                {
                    unitCost = 29;
                }
                else if (units > 150 && units < 250)
                {
                    unitCost = 30;
                }
                else if (units > 250)
                {
                    unitCost = 31;
                }
                if (pressure > 200)
                {
                    extraCharge = ((pressure - 100) / 50)) * 2 * units;
                }
                taxRate = 0.075;
            }
            else
            {
                Console.WriteLine("Invalid Customer Type!");

            }
            
            totalBill = (units * unitCost) + extraCharge;
            tax = totalBill * taxRate;
            finalBill = totalBill * taxRate;

            Console.WriteLine($"\nTotal Units: {units}");
            Console.WriteLine($"Unit Cost: {unitCost} PKR");
            Console.WriteLine($"Extra Charge: {extraCharge} PKR");
            Console.WriteLine($"Total Bill (Before Tax): {totalBill} PKR");
            Console.WriteLine($"Tax: {tax} PKR");
            Console.WriteLine($"Final Bill: {finalBill} PKR");


        }
    }
}
