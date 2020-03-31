using System;
using System.Collections.Generic;
using System.Text;

namespace TDI_Library_NET_Standard
{
    public class TDI_Class
    {
        public static void Main()
        {
            Console.WriteLine("Use the arrow keys to type your message: ");
            ConsoleKeyInfo first, second, third;
            List<string> Line = new List<string>();

            do // Exit key is 'X'
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
                                        Line.Add("A");          // Add "A" to the list Line.
                                        break;
                                    case ConsoleKey.DownArrow: // The rest of the switch-case structures
                                        Line.Add("B");          // follow the same logic, spelling out
                                        break;                 // the entire alphabet and a space character. 
                                    case ConsoleKey.RightArrow:
                                        Line.Add("C");
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
                                        Line.Add("D");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Line.Add("E");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Line.Add("F");
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
                                        Line.Add("G");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Line.Add("H");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Line.Add("I");
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
                                        Line.Add("J");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Line.Add("K");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Line.Add("L");
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
                                        Line.Add("M");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Line.Add("N");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Line.Add("O");
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
                                        Line.Add("P");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Line.Add("Q");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Line.Add("R");
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
                                        Line.Add("S");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Line.Add("T");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Line.Add("U");
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
                                        Line.Add("V");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Line.Add("W");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Line.Add("X");
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
                                        Line.Add("Y");
                                        break;
                                    case ConsoleKey.DownArrow:
                                        Line.Add("Z");
                                        break;
                                    case ConsoleKey.RightArrow:
                                        Line.Add(" ");
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
                string fullLine = string.Join("", Line); // This takes the list Line and creates a single line message.
                Console.WriteLine(fullLine);                // TODO: work on output to be more user-friendly.
            } while (first.Key != ConsoleKey.X);
        }

        public static void notMain()
        {
            List<string> Line = new List<string>();
            //List<ConsoleKey> Combo = new List<ConsoleKey>();
            //ConsoleKeyInfo first, second, third;
            //first = Console.ReadKey();
            //Combo.Add(first.Key);
            //second = Console.ReadKey();
            //Combo.Add(second.Key);
            //third = Console.ReadKey();
            //Combo.Add(third.Key);

            /* if it's possible to switch a list,
             * Combo can be used to simplify the old code
             */

            ConsoleKeyInfo first;
            first = Console.ReadKey();
            Console.WriteLine(first.KeyChar);

            string fullLine = string.Join("", Line);
            Console.WriteLine(fullLine);
        }
    }
}
