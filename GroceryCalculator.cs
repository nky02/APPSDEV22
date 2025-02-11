using System;

namespace GroceryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueAddingItems = true;
            string itemName, userDecision;
            int quantityPerItem;
            double pricePerUnit, totalCost = 0, discountAmount = 0;

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


                while (true)
                {
                    Console.WriteLine("Do you want to input another product? [YES or NO]");
                    userDecision = Console.ReadLine().ToUpper().Trim();

                    if (userDecision == "YES")
                    {
                        break;
                    }
                    else if (userDecision == "NO")
                    {
                        continueAddingItems = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'YES' or 'NO'.");
                    }
                }

            } while (continueAddingItems);


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


            double finalAmount = totalCost - discountAmount;

            Console.WriteLine("\n\t\t\tSharp's Grocery\n\t\t\tPurchase Receipt\n");
            Console.WriteLine($"\tTotal cost before discount: ..................${totalCost:F2}");
            Console.WriteLine($"\tDiscount amount: .............................${discountAmount:F2}");
            Console.WriteLine($"\tTotal Payment: ...............................${finalAmount:F2}");
        }
    }
}

