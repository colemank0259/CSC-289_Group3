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
            Console.WriteLine("Use the arrow keys to type your message: ");
            ConsoleKeyInfo first, second, third;

            /* The following code is test code
             * and will read key input
             * and provide feedback.
             * It will exit when
             * 'x' is pressed.
             */

            //do
            //{
            //    first = Console.ReadKey();
            //    Console.WriteLine(first.Key + " was pressed");
            //} while (first.Key != ConsoleKey.X);

            do // Exit key is still 'X'
            {
                /* This reads the first key and sends
                 * it to a switch-case statement.
                 * For the sake of the program,
                 * the Down Arrow will be referred
                 * to as Center.
                 */

                first = Console.ReadKey(); // Just like a .ReadLine(), but keypress.
                switch (first.Key) // This accesses the actual information of the keypress.
                {
                    case ConsoleKey.LeftArrow: // If the first key pressed is the left arrow...
                        second = Console.ReadKey(); // Read for second keypress.
                        switch (second.Key)
                        {
                            case ConsoleKey.LeftArrow: // If the second key pressed is the left arrow...
                                third = Console.ReadKey(); // Read for third keypress.
                                switch (third.Key)
                                {
                                    case ConsoleKey.LeftArrow: // If the third key pressed is the left arrow...
                                        Console.WriteLine("A"); // Print "A" to the screen.
                                        break;
                                    case ConsoleKey.DownArrow: // The rest of the switch-case structures
                                        Console.WriteLine("B");// follow the same logic, spelling out
                                        break;                 // the entire alphabet and a space character. 
                                    case ConsoleKey.RightArrow:
                                        Console.WriteLine("C");
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease use the arrow keys.");
                                        break;
                                }
                                break;
                            case ConsoleKey.DownArrow: // This is the Left, Center-Section
                                third = Console.ReadKey();
                                switch (third.Key)
                                {
                                    case ConsoleKey.LeftArrow:
                                        Console.WriteLine("D");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Console.WriteLine("E");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Console.WriteLine("F");
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease use the arrow keys.");
                                        break;
                                }
                                break;
                            case ConsoleKey.RightArrow: // This is the Left, Right-Section
                                third = Console.ReadKey();
                                switch (third.Key)
                                {
                                    case ConsoleKey.LeftArrow:
                                        Console.WriteLine("G");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Console.WriteLine("H");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Console.WriteLine("I");
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease use the arrow keys.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("\nPlease use the arrow keys.");
                                break;
                        }
                        break;
                    case ConsoleKey.DownArrow: // This is the Center Section
                        second = Console.ReadKey();
                        switch (second.Key)
                        {
                            case ConsoleKey.LeftArrow: // This is the Center, Left-Section
                                third = Console.ReadKey();
                                switch (third.Key)
                                {
                                    case ConsoleKey.LeftArrow:
                                        Console.WriteLine("J");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Console.WriteLine("K");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Console.WriteLine("L");
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease use the arrow keys.");
                                        break;
                                }
                                break;
                            case ConsoleKey.DownArrow: // This is the Center, Center-Section
                                third = Console.ReadKey();
                                switch (third.Key)
                                {
                                    case ConsoleKey.LeftArrow:
                                        Console.WriteLine("M");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Console.WriteLine("N");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Console.WriteLine("O");
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease use the arrow keys.");
                                        break;
                                }
                                break;
                            case ConsoleKey.RightArrow: // This is the Center, Right-Section
                                third = Console.ReadKey();
                                switch (third.Key)
                                {
                                    case ConsoleKey.LeftArrow:
                                        Console.WriteLine("P");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Console.WriteLine("Q");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Console.WriteLine("R");
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease use the arrow keys.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("\nPlease use the arrow keys.");
                                break;
                        }
                        break;
                    case ConsoleKey.RightArrow: // This is the Right Section
                        second = Console.ReadKey();
                        switch (second.Key)
                        {
                            case ConsoleKey.LeftArrow: // This is the Right, Left-Section
                                third = Console.ReadKey();
                                switch (third.Key)
                                {
                                    case ConsoleKey.LeftArrow:
                                        Console.WriteLine("S");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Console.WriteLine("T");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Console.WriteLine("U");
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease use the arrow keys.");
                                        break;
                                }
                                break;
                            case ConsoleKey.DownArrow: // This is the Right, Center-Section
                                third = Console.ReadKey();
                                switch (third.Key)
                                {
                                    case ConsoleKey.LeftArrow:
                                        Console.WriteLine("V");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Console.WriteLine("W");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Console.WriteLine("X");
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease use the arrow keys.");
                                        break;
                                }
                                break;
                            case ConsoleKey.RightArrow: // This is the Right, Right-Section
                                third = Console.ReadKey();
                                switch (third.Key)
                                {
                                    case ConsoleKey.LeftArrow:
                                        Console.WriteLine("Y");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Console.WriteLine("Z");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Console.WriteLine(" ");
                                        break;
                                    default:
                                        Console.WriteLine("\nPlease use the arrow keys.");
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("\nPlease use the arrow keys.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("\nPlease use the arrow keys.");
                        break;
                }
            } while (first.Key != ConsoleKey.X);

        }
    }
}
