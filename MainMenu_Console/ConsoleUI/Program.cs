using System;
using System.Windows.Forms;
using Utilities;
using TDI_Library;
using Login_Form;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This is the program's home base.
             * Functionality should be limited
             * and imported methods should be
             * used to keep the code clean.
             * As of now, there is a TDI_Library
             * that holds the key to interpretation
             * and a Utilities Library that handles
             * standard messages and useful snippets.
             * There is also a in-progress Login Form
             * that will be added in later.
             */

            // Boolean for application access
            bool exit = false;

            // Do-while loop for application
            do
            {
                // Display main menu for user
                Utils.MainMenu();
                // Get validated integer from user
                string optionString = Utils.PromptInput();

                if (int.TryParse(optionString, out int option))
                {
                    // Switch-case to validate integer as a menu option
                    switch (option)
                    {
                        case 1:
                            // Display user login form
                            Login login = new Login();
                            Application.Run(login);

                            
                            //get username and password
                            //Console.WriteLine("Please enter your username");
                            //String username = Console.ReadLine();
                            //Console.WriteLine("Please enter your password");
                            //String password = Console.ReadLine();


                            ////create user object
                            //User user = new User(username, password);
                            ////validate user login
                            //user.ValidateUser();
                            //if (user.Valid == true) { Console.WriteLine("You Logged in!"); }
                            break;
                        case 2:
                            // Allow user to input message using provided interface.
                            Console.WriteLine("Please enter your message using the key provided...");
                            TDI_Class.Main();
                            break;
                        case 3:
                            // Changes exit value to false, exiting the program
                            exit = true;
                            break;
                        default:
                            // Message if input is not a menu option
                            Utils.InvalidInput(option.ToString());
                            break; 
                    }
                }
                else
                {
                    Utils.InvalidInput(optionString);
                }
            } while (exit == false);
        }
    }
}