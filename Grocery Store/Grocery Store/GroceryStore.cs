using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Store
{
    /// <summary>
    /// This program represents a grocery store. 
    /// It uses user input such as name of commodity,
    /// amount and price then calculates VAT prices for it and print it neatly.
    /// </summary>
    class GroceryStore
    {
        static void Main(string[] args)
        {
            //Set title for the console window
            Console.Title = "Apu's Supermarket";
            //Declare and initiate a new instance of the Product class
            Product product = new Product();
            //Call the Start method in the class Product using the new instance of it
            product.Start();
            //Write a line warning the user that the program is about to close
            Console.WriteLine("Press Enter to exit!");
            //Wait for input from the user to keep the window from closing
            Console.ReadLine();
        }
    }
}
