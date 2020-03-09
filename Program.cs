using System;
using System.Windows.Forms;

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
                Console.WriteLine("2. Register new User");
                Console.WriteLine("3. Input message");
                Console.WriteLine("4. Exit");
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

                            Application.Run(new Login());

                            //get username and password
                            Console.WriteLine("Please enter your username");
                            String username = Console.ReadLine();
                            Console.WriteLine("Please enter your password");
                            String password = Console.ReadLine();


                            //create user object
                            User user = new User(username, password);
                            //validate user login
                            user.Validate();
                            if (user.Valid == true) { Console.WriteLine("You Logged in!"); }
                            break;
                        case 2:
                            //display the registration form
                            Application.Run(new Registration());
                                                        
                            break;
                        case 3:
                            // Allow user to input message using provided interface.
                            Console.WriteLine("Please enter your message using the key provided...");
                            TDI_Library.TDI_Class.Main();
                            break;
                        case 4:
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
