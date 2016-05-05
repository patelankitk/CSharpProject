using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a list of integer //
            List<int> NumberList = new List<int>();

            //variable for user choice (Y/N)//
            String UserChoice;

            //vriable for User Option (A/S/X)
            string UserOption;

            //Do while loop for user to add number to list as long as they want //
            do
            {
                Console.WriteLine("Would you like to add number to the list? (Y/N):");
                UserChoice = Console.ReadLine().ToLower();
                Console.WriteLine("\n");

                // if statement if the user want to add more number to the list //
                if (UserChoice == "y")
                {
                    Console.WriteLine("Please Enter a number , followed by return :");

                    // variable to store user number //
                    int UserNumber = int.Parse(Console.ReadLine());

                    // adding usernumber to list //
                    NumberList.Add(UserNumber);

                    Console.WriteLine("");
                }

            } while (UserChoice != "n"); //End of first Do While Loop where user can add a number to list //

            //start of another do while loop to give user option to sort, average and exit //
            do {
                Console.WriteLine("Type 'A' to get the average of the lit, 'S' to sort it, or 'X' to exit:");
                UserOption = Console.ReadLine().ToLower();
                Console.WriteLine("\n");

                // switch statement for user to sort / average or exit //

                switch (UserOption)
                {
                    case "a":
                        //average the list using function average  for the list //
                        double Average = NumberList.Average();
                        Console.WriteLine("The Average of the list is {0}.\n", Average);
                        break;

                    case "s":
                        //sort the list using the function sort for th list //
                        NumberList.Sort();

                        Console.WriteLine("Your List is sorted, please see below sorted list.");

                        //usinng foreach loop to  display the sorted list to user //
                        foreach (int number in NumberList)
                        {
                            Console.Write("  " + number );
                        }
                        Console.WriteLine("\n");
                        break;

                    default:
                        break;
                }

            } while (UserOption != "x"); // end of do while loop where user can sort / average  or exit  //

        } //End of main program//

    }//End of Class //

}// End of namespace //
