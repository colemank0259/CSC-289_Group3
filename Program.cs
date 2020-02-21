using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
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
                            //create user and test created method
                            User test = new User("admin", "admin");
                            test.getUserTable();
                            break;
                        case 2:
                            // Allow user to input message using provided interface.

                            /* This will call a module to allow the user
                             * the ability to input a message using our
                             * application. In the beginning, this is looking
                             * like using arrow keys or WASD in combinations
                             * corresponding to individual characters of the
                             * alphabet.
                             */
                            Console.WriteLine("Please enter your message using the key provided...");
                            break;
                        case 3:
                            // Changes exit value to false, exiting the program
                            Console.WriteLine("Bye bye!");
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
