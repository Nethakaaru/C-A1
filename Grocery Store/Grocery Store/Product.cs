using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Store
{
    /// <summary>
    /// A class representing a product in a grocery store. 
    /// It contains an amount, a name, a price and a VAT value that differs depending on what it is.
    /// </summary>
    class Product
    {
        //Variables for the VAT rates
        private const double foodVATRate = 0.12, otherVATRate = 0.25;
        //A string variable for storing the name of the product
        private string name;
        //A variable to keep track of the amount.
        private int count;
        //The price of the product without VAT
        private double unitPrice;
        //A boolean to check if it is food or not
        private bool foodItem;
        //A variable for storing the unit price multiplied with the amount
        private double totalNetValue;

        //The method where it all happens. This method is called upon from the main class.
        public void Start()
        {
            //A call to the metod ReadInput
            ReadInput();
            //A call to the Calculate method
            Calculate();
            //A call to the ShowResults method
            ShowResults();
        }

        //A Method that calls other methods used to read input from the user
        private void ReadInput()
        {
            //A call to ReadName
            ReadName();
            //A call to ReadNetUnitPrice
            ReadNetUnitPrice();
            //A call to ReadIfFoodItem
            ReadIfFoodItem();
            //A call to ReadCount
            ReadCount();

        }

        //A method used to calculate the total net value of the the purchase
        private void Calculate()
        {
            //the net value is equal to the price of the product multiplied by its amount
            totalNetValue = count * unitPrice;
        }

        //A method used to print the results to the user
        private void ShowResults()
        {
            //A couple of empty lines. 
            Console.WriteLine();
            Console.WriteLine();
            //We obviously need to make the user feel welcome.
            Console.WriteLine("***************  WELCOME TO APU's SUPERMARKET  ***************");
            Console.WriteLine("***");
            //Print out the name, quantity, unit price and if it is food or not to the user. 
            //A couple of tab escape sequences are used to make the print neater.
            Console.WriteLine("*** Name of the product \t" + name);
            Console.WriteLine("*** Quantity \t\t\t" + count);
            Console.WriteLine("*** Unit Price \t\t\t" + unitPrice);
            Console.WriteLine("*** Food Item \t\t\t" + foodItem);
            Console.WriteLine("***");
            //If the item is food...
            if (foodItem)
            {
                //We print out the information related to only food items
                Console.WriteLine("*** Total Amount to pay: \t" + (totalNetValue * (1 + foodVATRate)));
                Console.WriteLine("*** Including VAT at 12 % \t" + (totalNetValue * foodVATRate));
            }
            //But if it isn't food...
            else
            {
                //We print out the information related only to what is not food
                Console.WriteLine("*** Total Amount to pay: \t" + (totalNetValue * (1 + otherVATRate)));
                Console.WriteLine("*** Including VAT at 25 % \t" + (totalNetValue * otherVATRate));
            }
            //Print out the credits and say farewell to the user
            Console.WriteLine("***");
            Console.WriteLine("*** This program has been developed by: Sebastian Aspegren ***");
            Console.WriteLine("********************  PLEASE COME AGAIN!  ********************");
            Console.WriteLine();

        }
        //A method used to read the name of the user
        private void ReadName()
        {
            //We ask the user for their name
            Console.Write("Enter the product name: ");
            //And then save it in a variable called name
            name = Console.ReadLine();
        }
        //A method that prompts the user for the price of the product
        private void ReadNetUnitPrice()
        {
            //We ask the user for the price
            Console.Write("Net unit price: ");
            //And then store it in a variable
            unitPrice = double.Parse(Console.ReadLine());
        }
        //A method used to decide if the item is food or not
        private void ReadIfFoodItem()
        {
            //We prompt the user to input y or n depending on if the product is food or not
            Console.Write("Food item (y/n): ");
            //the string that was input is converted into a char variable
            char response = char.Parse(Console.ReadLine());
            //If the response is a y or a Y it is food
            if ((response == 'y') || (response == 'Y'))
                foodItem = true;
            //Otherwise it isn't
            else
                foodItem = false;
        }
        //A method used to ask the user for the amount
        private void ReadCount()
        {
            //We prompt the user to input the amount they plan on purchasing
            Console.Write("Count: ");
            //And the convert the string into an integer and store it in out count variable
            count = int.Parse(Console.ReadLine());
        }
    }
}
