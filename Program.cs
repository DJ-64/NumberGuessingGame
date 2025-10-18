using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalGuessingGame
{
    internal class Program
    {
        static void Main(string[] args) {
            int diff = 10;
            Console.WriteLine("Number Guessing Game");
            int points = 0;
            int bestMove = 5;
            int rolledWheel;
            bool highRank;
            bool[] shop =
            {
                false, // Premium Pass for wheel
                false  // Calculated best guesses
            };
            int[] shopPrices =
            {
                1050, //Premium Pass for wheel
                2850, // Calculated best guesses
            };
            string input;
            while (true)
            {
                Random random = new Random();
                int thinkInt = random.Next(1, diff+1);
                int inputInt = 0;
                int guesses = 0;
                int max = diff;
                bestMove = max / 2;
                if (shop[1])
                {
                    Console.WriteLine("Calculated Best Move: " + bestMove);
                }
                Console.Write("\n Guess a number 1 to " + diff + ": ");
                highRank = false;
                while (thinkInt != inputInt)
                {
                    input = Console.ReadLine();
                    inputInt = Convert.ToInt32(input);
                    Console.WriteLine("");
                    if (inputInt == bestMove)
                    {
                        Console.WriteLine("PERFECT MOVE, POINT BONUS!");
                        points += 32 * diff;
                    } else
                    if (inputInt >= max)
                    {
                        Console.WriteLine("Terrible move...");
                        points -= 45;
                    }
                    else
                    if (inputInt <= 0)
                    {
                        Console.WriteLine("Terrible move...");
                        points -= 45;
                    }
                    else
                    {
                        Console.WriteLine("Average Move");
                    }
                        guesses++;
                    if (inputInt == 0)
                    {
                        Console.WriteLine("Not zero!");
                    }
                    else if (thinkInt == inputInt)
                    {
                        points += 3 * diff;
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Correct!");
                        Console.WriteLine("Number: " + thinkInt);
                        Console.WriteLine("Guesses: " + guesses);
                        Console.WriteLine("Overall Rank:");
                        highRank = false;
                        switch (guesses) {
                            case 1:
                                Console.Write("  _____  \r\n |  __ \\ \r\n | |__) |   PERFECT!\r\n |  ___/ \r\n | |     \r\n |_|     \r\n         \r\n         ");
                                points += 16 * diff;
                                highRank = true;
                                break;
                                case 2:
                                Console.Write("   _____ \r\n  / ____|\r\n | (___  \r\n  \\___ \\ \r\n  ____) |\r\n |_____/ \r\n         \r\n         ");
                                points += 6 * diff;
                                highRank = true;
                                break;
                                case 3:
                                Console.Write("           \r\n     /\\    \r\n    /  \\   \r\n   / /\\ \\  \r\n  / ____ \\ \r\n /_/    \\_\\\r\n           \r\n           ");
                                points += 3 * diff;
                                highRank = true;
                                break;
                                case 4:
                                points += 3 * diff;
                                highRank = true;
                                Console.Write("           \r\n     /\\    \r\n    /  \\   \r\n   / /\\ \\  \r\n  / ____ \\ \r\n /_/    \\_\\\r\n           \r\n           ");
                                break;
                            case 5:
                                Console.Write("  ____  \r\n |  _ \\ \r\n | |_) |\r\n |  _ < \r\n | |_) |\r\n |____/ \r\n        \r\n        ");
                                break;
                            case 6:
                                Console.Write("  ____  \r\n |  _ \\ \r\n | |_) |\r\n |  _ < \r\n | |_) |\r\n |____/ \r\n        \r\n        ");
                                break;
                            case 7:
                                Console.Write("   _____ \r\n  / ____|\r\n | |     \r\n | |     \r\n | |____ \r\n  \\_____|\r\n         \r\n         ");
                                break;
                            default:
                                Console.Write("  _      \r\n | |     \r\n | |     \r\n | |     \r\n | |____ \r\n |______|\r\n         \r\n         ");
                                    break;
                        }
                        points -= guesses;
                        Console.WriteLine("");
                        Console.WriteLine("POINTS: " + points);
                        Console.WriteLine("");
                    }
                    else if (inputInt >= thinkInt)
                    {
                        max = inputInt;
                        Console.WriteLine("Guess lower!");
                    }
                    else if (thinkInt >= inputInt)
                    {
                        Console.WriteLine("Guess higher!");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("Choose Next:");
                Console.WriteLine("1 - Next Round");
                Console.WriteLine("2 - Evil Wheel of Misfortune");
                Console.WriteLine("3 - One Free Point");
                Console.WriteLine("4 - Points Store");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        break;
                        case "2":
                        Console.Clear();
                        Console.WriteLine("The EVIL WHEEL OF MISFORTUNE!");
                        Console.WriteLine("Press any key to test your luck!");
                        Console.ReadKey();
                        if (shop[0])
                        {
                            rolledWheel = random.Next(1, 4);
                            Console.Clear();
                            Console.WriteLine("You Got:");
                            switch (rolledWheel)
                            {
                                case 1:
                                    Console.WriteLine("Lose 25 Points...");
                                    points -= 25;
                                    break;
                                case 2:
                                    Console.WriteLine("Gain 100 Points!");
                                    points += 100;
                                    break;
                                case 3:
                                    Console.WriteLine("2x Points!");
                                    points *= 2;
                                    break;
                                case 4:
                                    Console.WriteLine("Nothing");
                                    break;
                            }
                        }
                        else
                        {
                            rolledWheel = random.Next(1, 3);
                            Console.Clear();
                            Console.WriteLine("You Got:");
                            switch (rolledWheel)
                            {
                                case 1:
                                    Console.WriteLine("Gain 100 Points!");
                                    points += 100;
                                    break;
                                case 2:
                                    Console.WriteLine("2x Points!");
                                    points *= 2;
                                    break;
                                case 3:
                                    Console.WriteLine("3x Points!");
                                    points *= 3;
                                    break;
                            }
                        }
                        Console.WriteLine("You now have " + points + " points.");
                        Console.WriteLine("Press any key to enter the next round.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("You got 1 free point!");
                        points += 1;
                        Console.WriteLine("Press any key to enter the next round.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                        case "4":
                        Console.Clear();
                        Console.Write("  _____      _       _          _____ _                 \r\n |  __ \\    (_)     | |        / ____| |                \r\n | |__) |__  _ _ __ | |_ ___  | (___ | |__   ___  _ __  \r\n |  ___/ _ \\| | '_ \\| __/ __|  \\___ \\| '_ \\ / _ \\| '_ \\ \r\n | |  | (_) | | | | | |_\\__ \\  ____) | | | | (_) | |_) |\r\n |_|   \\___/|_|_| |_|\\__|___/ |_____/|_| |_|\\___/| .__/ \r\n                                                 | |    \r\n                                                 |_|    ");
                        Console.WriteLine("");
                        Console.WriteLine("You have " + points + " points.");
                        Console.WriteLine("");
                        Console.WriteLine("1 - Evil Wheel of Misfortune Premium Pass");
                        Console.WriteLine(shopPrices[0] + " points");
                        Console.WriteLine("");
                        Console.WriteLine("2 - Best Move Hint");
                        Console.WriteLine(shopPrices[1] + " points");
                        Console.WriteLine("");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                if (points >= shopPrices[0])
                                {
                                    Console.WriteLine("Item bought!");
                                    shop[0] = true;
                                    points -= shopPrices[0];
                                }
                                else
                                {
                                    Console.WriteLine("You need more points.");
                                }
                                break;
                            case "2":
                                if (points >= shopPrices[1])
                                {
                                    Console.WriteLine("Item bought!");
                                    shop[1] = true;
                                    points -= shopPrices[1];
                                }
                                else
                                {
                                    Console.WriteLine("You need more points.");
                                }
                                break;
                            default:
                                Console.WriteLine("Nothing bought.");
                                break;
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Thank you for shopping!");
                        Console.WriteLine("Press any key to enter the next round");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                diff = diff + 20;
            }
        }
    }
}
