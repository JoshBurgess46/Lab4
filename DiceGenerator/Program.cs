using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGeneratorLab4
{
    class Program
    {
        public static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Josh's Casino!");
            bool go = true;
            while (go)
            {
                Console.WriteLine("Roll the dice? Y or N");
                string answer = Console.ReadLine().ToLower();
               
                if (answer == "y")
                {
                    Console.WriteLine("How many sides are on your dice?");
                    string userString = Console.ReadLine();
                    int userInput;
                    if (int.TryParse(userString, out userInput))
                    {
                        int num1 = RollDie(userInput);
                        Console.WriteLine(num1);
                        int num2 = RollDie(userInput);
                        Console.WriteLine(num2);
                    }
                    else
                    {
                        Console.WriteLine("Thats not a proper input, try again.");
                    }
                }
                else if(answer =="n")
                {
                    Console.WriteLine("Thank you for playing! Good-Bye.");
                    go = false;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid input, please choose y for yes or n for no.");

                }
            }
        }

        public static int RollDie(int num)
        {

            return random.Next(1, (num+1));

        }
    }
}
