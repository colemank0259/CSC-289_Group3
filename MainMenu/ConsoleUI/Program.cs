using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDI;

namespace ConsoleUI
{
    class Program
    {
        private static void Main(string[] args)
        {
            /* This module will display the main menu
             * for the user and allow a selection of
             * options tied to other modules.
             * 
             * This may later be changed from a
             * console app to something more
             * appropriate for the application's
             * interface.
             * 
             * For now, this is our starting point.
             */

            // Boolean for application access
            bool exit = false;

            // Do-while loop for application
            do
            {
                // Display main menu for user
                Console.WriteLine("---Main Menu---");
                Console.WriteLine("1. User login");
                Console.WriteLine("2. Input message");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Please enter an option: ");
                string choice = Console.ReadLine();
                int option;
                // Validate user input as an integer
                if (int.TryParse(choice, out option))
                {
                    // Switch-case to validate integer as a menu option
                    switch (option)
                    {
                        case 1:
                            // Display user login form

                            /* This will call another module to show
                             * a field for username and password,
                             * buttons to login or cancel,
                             * and a button to create an account.
                             * This information will be validated
                             * to log the user in or prompt the user
                             * that the information was incorrect.
                             * This form will also allow a new user
                             * to create an account.
                             */
                            Console.WriteLine("Please enter login information...");
                            break;
                        case 2:
                            // Allow user to input message using provided interface.
                            Console.WriteLine("Please enter your message using the key provided...");
                            TriDirectionalInput.TDIMain();
                            break;
                        case 3:
                            // Changes exit value to false, exiting the program
                            exit = true;
                            break;
                        default:
                            // Message if input is not a menu option
                            Console.WriteLine($"'{choice}' is not a valid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    // Message if input is not an integer
                    Console.WriteLine($"'{choice}' is not a valid choice. Please try again.");
                }

            } while (exit == false);            
        }
    }
}
