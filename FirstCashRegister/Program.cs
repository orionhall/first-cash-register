using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            // run keeps looping the program if a user chooses to do so
            bool run = true;
            while (run == true) 
            {
                // user enters the price of the item(s)
                Console.WriteLine("Enter the total.\n");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                // user enters the amount paid
                Console.WriteLine("Enter the amount paid.\n");
                decimal paid = Convert.ToDecimal(Console.ReadLine());
                
                // the price subtracted from the amount paid gives the value of the change
                decimal change = (paid - price);

                //these three are decimals but they could be doubles
                
                // declaring all of our necessary variables (denominations) as well as a string for the final answer
                // program currently only returns change <= $199.99 ;)
                int pennies = 0, nickels = 0, dimes = 0, quarters = 0, ones = 0, fives = 0, tens = 0, twenties = 0;
                string result = "";

                //tell the user what the change is in numerical form 
                Console.WriteLine("The change is " + change + ".");

                // logic begins for determining the number of the various denominations
                // when an if statement is satisfied, the iterator for that denomination, plus a string for the denomination, is added to the result string
                // while loops are used to determine how many of a particular denomination there are
                // as a denomination gets added, its value is subtracted from change until it eventually equals zero
                if (change >= 0)
                {
                    // The cash register currently only holds one hundred due to recent thefts
                    if (change >= 100m)
                    {
                        result += "One Hundred ";
                        change -= 100m;
                    }
                    // Twenties logic
                    while (change >= 20m)
                    {
                        twenties++;
                        change -= (20m);
                    }
                    if (twenties > 0 && twenties != 1)
                    {
                        result += twenties + " Twenties, ";
                    }
                    else if (twenties == 1 && change == 0m)
                    {
                        result += twenties + " Twenty.";
                    }
                    else if (twenties == 1)
                    {
                        result += twenties + " Twenty, ";
                    }
                    // Tens logic
                    while (change >= 10m)
                    {
                        tens++;

                        change -= (10m);
                    }
                    if (tens > 0 && tens != 1)
                    {
                        result += tens + " Tens, ";
                    }
                    else if (tens == 1 && change == 0m)
                    {
                        result += tens + " Ten.";
                    }
                    else if (tens == 1)
                    {
                        result += tens + " Ten, ";
                    }
                    // Fives logic
                    while (change >= 5m)
                    {
                        fives++;
                        change -= (5m);
                    }
                    if (fives > 0 && fives != 1)
                    {
                        result += fives + " Fives, ";
                    }
                    else if (fives == 1 && change == 0m)
                    {
                        result += fives + " Five.";
                    }
                    else if (fives == 1)
                    {
                        result += fives + " Five, ";
                    // Ones logic
                    }
                    while (change >= 1m)
                    {
                        ones++;

                        change -= (1m);
                    }
                    if (ones > 0 && ones != 1)
                    {
                        result += ones + " Ones, ";
                    }
                    else if (ones == 1 && change == 0m)
                    {
                        result += ones + " One.";
                    }
                    else if (ones == 1)
                    {
                        result += ones + " One, ";

                    }
                    // Quarters logic
                    while (change >= .25m)
                    {
                        quarters++;

                        change -= (.25m);
                    }
                    if (quarters > 0 && quarters != 1)
                    {
                        result += quarters + " Quarters, ";
                    }
                    else if (quarters == 1 && change == 0m)
                    {
                        result += quarters + " Quarter.";
                    }
                    else if (quarters == 1)
                    {
                        result += quarters + " Quarter, ";

                    }
                    // Dimes logic
                    while (change >= .10m)
                    {
                        dimes++;

                        change -= (.10m);
                    }
                    if (dimes > 0 && dimes != 1)
                    {
                        result += dimes + " Dimes, ";
                    }
                    else if (dimes == 1 && change == 0m)
                    {
                        result += dimes + " Dime.";
                    }
                    else if (dimes == 1)
                    {
                        result += dimes + " Dime, ";

                    }
                    // Nickels logic
                    while (change >= .05m)
                    {
                        nickels++;

                        change -= (.05m);
                    }
                    
                    if (nickels > 0 && nickels != 1)
                    {
                        result += nickels + " Nickels, ";
                    }
                    else if (nickels == 1 && change == 0m)
                    {
                        result += nickels + " Nickel.";
                    }
                    else if (nickels == 1)
                    {
                        result += nickels + " Nickel, ";
                    
                    }
                    // Pennies logic
                    while (change >= .01m)
                    {
                        pennies++;

                        change -= (.01m);
                    }
                    if (pennies > 0 && pennies != 1)
                    {
                        result += " and " + pennies + " Pennies.";
                    }
                    else if (pennies == 1 && change == 0m)
                    {
                        result += " and " + pennies + " Penny.";
                    }
                    else if (pennies == 1)
                    {
                        result += " and " + pennies + " Penny. ";

                    }
                    //Finally the console prints the change in denominational form 
                    Console.WriteLine("Give the customer " + result);

                }
                Console.WriteLine("\nWould you like to continue? y/n");
                string _continue = Console.ReadLine().ToLower();
                if (_continue == "n")
                {
                    run = false;
                }
                else if (_continue == "y")
                {
                    run = true;
                }
                else
                {
                    Console.WriteLine("That is not a valid response.  Enter 'y' to continue, or 'n' to exit.");
                    
                }
            }
        }
    }
}
