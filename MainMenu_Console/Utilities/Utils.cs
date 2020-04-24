using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Utils
    {
        public static void MainMenu()
        {
            // Displays Main Menu options to user
            Console.WriteLine("---Main Menu---");
            Console.WriteLine("1. User login");
            Console.WriteLine("2. Register New User");
            Console.WriteLine("3. Input message");
            Console.WriteLine("4. Exit");
        }

        public static string PromptInput()
        {
            Console.WriteLine("Enter >>> ");
            string input = Console.ReadLine();
            return input;
        }

        public static void InvalidInput(string input)
        {
            Console.WriteLine($"'{input}' is not a valid input. Please try again.");
        }
    }
}
