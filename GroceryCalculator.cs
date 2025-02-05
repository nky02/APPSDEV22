using System;

namespace GroceryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string itemName, userDecision;
            int quantityPerItem;
            double pricePerUnit, finalAmount = 0, totalCost = 0, discountAmount = 0;

            do
            {
                Console.WriteLine("Enter item name: ");
                itemName = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("Enter quantity of the item: ");
                    if (int.TryParse(Console.ReadLine(), out quantityPerItem) && quantityPerItem > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a positive integer for quantity.");
                }

                while (true)
                {
                    Console.WriteLine("Enter price per unit: ");
                    if (double.TryParse(Console.ReadLine(), out pricePerUnit) && pricePerUnit > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid input. Please enter a positive number for price.");
                }

                totalCost += quantityPerItem * pricePerUnit;

                Console.WriteLine("Do you want to input another product? [YES OR NO]");
                userDecision = Console.ReadLine().ToUpper().Trim();

            } while (userDecision == "YES");

            
            if (totalCost > 500)
            {
                discountAmount = totalCost * 0.20;
            }
            else if (totalCost > 200)
            {
                discountAmount = totalCost * 0.15;
            }
            else if (totalCost > 100)
            {
                discountAmount = totalCost * 0.10;
            }

            finalAmount = totalCost - discountAmount;

            Console.WriteLine("\t\t\tSharp's Grocery\n\t\t\tPurchase Receipt\n");
            Console.WriteLine("\tTotal cost before discount: ..................$" + totalCost);
            Console.WriteLine("\tDiscount amount: .............................$" + discountAmount);
            Console.WriteLine("\tTotal Payment: ...............................$" + finalAmount);
        }
    }
}
