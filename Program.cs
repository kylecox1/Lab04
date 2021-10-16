using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValidYesNo = false;
            bool rollDice = true;
            int sides = -1;
            int rollCount = 1;
            Random rand = new Random();

            do
            {
                Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n): ");
                string input = Console.ReadLine();
                if (input.Trim().ToLower() == "n")
                {
                    rollDice = false;
                    isValidYesNo = true;
                }
                else if (input.Trim().ToLower() == "y")
                {
                    isValidYesNo = true;
                }
                else
                {
                    Console.WriteLine($"Please just enter a 'y' or an 'n'.");
                }
            } while (isValidYesNo == false);

            while (rollDice == true)
            {
                bool isBadNumber = true;
                while (isBadNumber == true)
                {
                    Console.Write("How many sides sould each die have? ");
                    string userSides = Console.ReadLine();
                    if (!int.TryParse(userSides, out sides))
                    {
                        Console.WriteLine("Sorry, no decimals or non-number characters please.");
                    }
                    else if (sides < 1)
                    {
                        Console.WriteLine("Sorry, positive numbers only.");
                    }
                    else
                    {
                        isBadNumber = false;
                    }
                }
                Console.WriteLine($"Roll {rollCount}:");
                Console.WriteLine(rand.Next(1, sides + 1));
                Console.WriteLine(rand.Next(1, sides + 1));
                rollCount++;

                isValidYesNo = false;
                do
                {
                    Console.Write("Roll again? (y/n): ");
                    string againInput = Console.ReadLine();
                    if (againInput.Trim().ToLower() == "n")
                    {
                        rollDice = false;
                        isValidYesNo = true;
                    }
                    else if (againInput.Trim().ToLower() == "y")
                    {
                        isValidYesNo = true;
                    }
                    else
                    {
                        Console.WriteLine($"Please just enter a 'y' or an 'n'.");
                    }
                } while (isValidYesNo == false);
            }

            Console.WriteLine($"Thanks for playing! Press any key to exit.");
            Console.ReadKey();
        }
    }
}
