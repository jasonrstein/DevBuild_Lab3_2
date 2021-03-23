using System;
using System.Collections.Generic;
namespace DevBuildLab3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> shoppingList = new Dictionary<string, double>();

            bool addMoreItems = true;

            double averagePrice = 0.00;

            List<string> groceryItem = new List<string>();
            List<double> groceryPrice = new List<double>();

            groceryItem.Add("apple");
            groceryPrice.Add(.99);
            groceryItem.Add("banana");
            groceryPrice.Add(.59);
            groceryItem.Add("caulfl");
            groceryPrice.Add(1.59);
            groceryItem.Add("dragfr");
            groceryPrice.Add(2.19);


            Console.WriteLine("Item\t\t Price");
            Console.WriteLine("========================");

            for (int i = 0; i < groceryItem.Count; i++)
            {
                Console.WriteLine($"{groceryItem[i]}\t{groceryPrice[i]}");
            }

            do
            {
                Console.WriteLine("\nWhat item would you like to order?");
                string newItem = Console.ReadLine();
                Console.WriteLine();

                if (groceryItem.Contains(newItem) == false)
                {
                    Console.WriteLine("Sorry, we don't have those. Please try again.\n");
                }
                else
                {
                    int indexOfItem = groceryItem.IndexOf(newItem);
                    double price = groceryPrice[indexOfItem];
                    shoppingList.Add(newItem, price);

                    Console.WriteLine("Item\t\t Price");
                    Console.WriteLine("========================");

                    for (int i = 0; i < groceryItem.Count; i++)
                    {
                        Console.WriteLine($"{groceryItem[i]}\t{groceryPrice[i]}");
                    }

                    Console.WriteLine("Would you like to order anything else (y/n)?");
                    
                    string orderStatus = Console.ReadLine();


                        if (orderStatus == "y")
                        {
                            addMoreItems = true;
                        }
                        else if (orderStatus == "n")
                        {
                            addMoreItems = false;
                        }

                        else
                        {
                            Console.WriteLine("Please enter \"y\" or \"n\"");
                        }
                            
                }
            } while (addMoreItems);
            Console.WriteLine("\nThanks for your order!\nHere's what you got:\n\n*********************\n");
            foreach (var item in shoppingList)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
            foreach (var itemPrice in shoppingList)
            {
                averagePrice = itemPrice.Value + averagePrice;
            }
            Console.WriteLine($"\n*********************\n\nAverage price per item in order was ${averagePrice}\nPress Any Key to Continue");
        }
    }
}
