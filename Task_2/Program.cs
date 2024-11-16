using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char selection = '0';
            List<int> list = new List<int>();
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"P - Print numbers");
                Console.WriteLine($"A - Add a number");
                Console.WriteLine($"M - Display mean of the numbers");
                Console.WriteLine($"S - Display the smallest number on the list");
                Console.WriteLine($"L - Display the largest number on the list");
                Console.WriteLine($"F - Search for a number");
                Console.WriteLine($"D - Delete a number");
                Console.WriteLine($"C - Clearing out the list");
                Console.WriteLine($"I - Modify a number");
                Console.WriteLine($"Q - Quit");
                Console.WriteLine($"______________________");
                Console.ResetColor();
                Console.Write($"Enter your choice: ");
                selection = char.ToUpper(char.Parse(Console.ReadLine()));
                switch (selection)
                {
                    case 'P':
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"[] - the list is empty \r\n \r\n");
                            Console.ResetColor();
                        }
                        else
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"The numbers on the list:-");
                        for (int i = 0; i < list.Count; ++i)
                            Console.WriteLine($"- {list[i]}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" ----------------------\r\n");
                        Console.WriteLine($"Press enter to continue");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;

                    case 'A':
                        Console.Write($"Enter your number: ");
                        int nweNum = 0;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        nweNum = int.Parse(Console.ReadLine());
                        if (!list.Contains(nweNum))
                        {
                            list.Add(nweNum);
                            Console.WriteLine($"{nweNum} added! \r\n \r\n");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{nweNum} already exists in the list.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Press enter to continue");
                            Console.ReadLine();
                            Console.WriteLine($" \r\n ---------------------------------- \r\n\r\n");
                            Console.ResetColor();
                        }
                        break;

                    case 'M':
                        double sum = 0;
                        double mean = 0;
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Unable to calculate the mean - no data\r\n \r\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                sum += list[i];
                            }
                            mean = sum / list.Count;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"The mean of the elements is: {mean}");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Press enter to continue");
                        Console.ReadLine();
                        Console.WriteLine($" \r\n ---------------------------------- \r\n\r\n");
                        Console.ResetColor();

                        break;
                    case 'S':
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Unable to determine the smallest number - list is empty\r\n \r\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            int small = list[0];
                            for (int i = 0; i < list.Count; i++)
                                if (list[i] < small)
                                {
                                    small = list[i];
                                }

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"The smallest element is: {small}");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Press enter to continue");
                        Console.ReadLine();
                        Console.WriteLine($"------------------------------------\r\n\r\n");
                        Console.ResetColor();
                        break;

                    case 'L':
                        if (list.Count == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Unable to determine the largest number - list is empty\r\n \r\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            int large = list[0];
                            for (int i = 0; i < list.Count; i++)
                                if (large < list[i])
                                {
                                    large = list[i];
                                }

                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"The largest number is: {large}");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Press enter to continue");
                        Console.ReadLine();
                        Console.WriteLine($"------------------------------------\r\n\r\n");
                        Console.ResetColor();
                        break;

                    case 'F':
                        Console.Write($"Enter the number you want to search for: ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        int search = int.Parse(Console.ReadLine());

                        int index = -1;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == search)
                            {
                                index = i;
                            }
                        }

                        if (index == -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"The number {search} is not found in the list.");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"The number {search} is found at Rank number {index+1} and index {index}.");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Press enter to continue");
                        Console.ReadLine();
                        Console.WriteLine($"------------------------------------\r\n\r\n");
                        Console.ResetColor();
                        break;

                    case 'C':
                        if (list.Count != 0)
                        {
                            list.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"The list cleared successfully");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"List already clear");
                            Console.ResetColor();
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Press enter to continue");
                        Console.ReadLine();
                        Console.WriteLine($"------------------------------------\r\n\r\n");
                        Console.ResetColor();
                        break;

                    case 'D':
                        int DelNum = 0;
                        Console.Write($"Enter the number you want to delete: ");
                        DelNum = int.Parse(Console.ReadLine());
                        int indexo = list.IndexOf(DelNum);

                        if (indexo != -1)
                        {
                            list.RemoveAt(indexo);
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"Number {DelNum} has been removed!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{DelNum} is not found in the list.");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Press enter to continue");
                        Console.ReadLine();
                        Console.WriteLine($"------------------------------------\r\n\r\n");
                        Console.ResetColor();
                        break;

                    case 'I':
                        int oldNum = 0;
                        Console.Write($"Enter the number to modify: ");
                        oldNum = int.Parse( Console.ReadLine()) ;
                        int comp = list.IndexOf(oldNum);
                        Console.Write($"Enter the new number: ");
                        int newNum = int.Parse(Console.ReadLine()) ;

                        if (comp != -1)
                        {
                            for (int i = 0; i < list.Count; i++)
                                if (list[i] == oldNum)
                                    list[i] = newNum;
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"{oldNum} is replaced by {newNum}! "); 
                            Console.ResetColor();
                        }
                        else
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{oldNum} is not found in the list.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Press enter to continue");
                        Console.ReadLine();
                        Console.WriteLine($"------------------------------------\r\n\r\n");
                        Console.ResetColor();
                        break;

                    case 'Q':
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"\r\n   ____                    _  _                  \r\n  / ___|  ___    ___    __| || |__   _   _   ___ \r\n | |  _  / _ \\  / _ \\  / _` || '_ \\ | | | | / _ \\\r\n | |_| || (_) || (_) || (_| || |_) || |_| ||  __/\r\n  \\____| \\___/  \\___/  \\__,_||_.__/  \\__, | \\___|\r\n                                     |___/       \r\n");
                        Console.ResetColor ();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Unknown selection, please try again");
                        Console.ResetColor();
                        break;
                      }   
            } while( selection != 'Q');
        }
    }
}
