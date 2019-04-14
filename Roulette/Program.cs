using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            spinWheel();
        }
        static void spinWheel()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool game = true;
            Random rand = new Random();
            string[] Color = { "Black", "Red" };
            var r = new Random();
            int roll = rand.Next(0, 37);
            bool even = roll % 2 == 0;

            while (game)
            {
                //Starting menu
                Console.WriteLine("please type spin to see what if you've won your bet! Or type quit to exit");
                string input = " ";
                input = Console.ReadLine();
                if (input == "spin")
                {
                    Console.Clear();
                    string colorRand = Color[r.Next(Color.Length)];
                    Console.WriteLine("Your roullete roll was: " + colorRand + " " + roll);
                    Console.WriteLine("And now, Here Are the winning Bets!");
                    Console.WriteLine("Numbers bet");
                    Console.WriteLine("Doubles bet");
                    if (colorRand == "Black")
                    {
                        Console.WriteLine("blacks bet.");

                    }
                    if (colorRand == "Red")
                    {
                        Console.WriteLine("Reds bet");
                    }
                    if (even == true)
                    {
                        Console.WriteLine("evens bet");
                    }
                    if (even == false)
                    {
                        Console.WriteLine("Odds bet");
                    }
                    if (roll <= 18)
                    {
                        Console.WriteLine("lows bet ");
                    }
                    if (roll >= 19)
                    {
                        Console.WriteLine("Highs bet");
                    }
                    if (roll == 1 || roll == 2 || roll == 3)
                    {
                        Console.WriteLine("1/2/3 street bet");
                    }
                    if (roll == 4 || roll == 5 || roll == 6)
                    {
                        Console.WriteLine("4/5/6 street bet");
                    }
                    if (roll == 7 || roll == 8 || roll == 9)
                    {
                        Console.WriteLine("7/8/9 street bet");
                    }
                    if (roll == 10 || roll == 11 || roll == 12)
                    {
                        Console.WriteLine("10/11/12 street bet");
                    }
                    if (roll == 13 || roll == 14 || roll == 15)
                    {
                        Console.WriteLine("13/14/15 street bet");
                    }
                    if (roll == 16 || roll == 17 || roll == 18)
                    {
                        Console.WriteLine("16/17/18 street bet");
                    }
                    if (roll == 19 || roll == 20 || roll == 21)
                    {
                        Console.WriteLine("19/20/21 street bet");
                    }
                    if (roll == 22 || roll == 23 || roll == 24)
                    {
                        Console.WriteLine("22/23/24 street bet");
                    }
                    if (roll == 25 || roll == 26 || roll == 27)
                    {
                        Console.WriteLine("25/26/27 street bet");
                    }
                    if (roll == 28 || roll == 29 || roll == 30)
                    {
                        Console.WriteLine("28/29/30 street bet");
                    }
                    if (roll == 31 || roll == 32 || roll == 33)
                    {
                        Console.WriteLine("31/32/33 street bet");
                    }
                    if (roll == 33 || roll == 34 || roll == 35)
                    {
                        Console.WriteLine("34/35/36 street bet");
                    }
                    if (roll == 1 || roll == 4 || roll == 7 || roll == 10 || roll == 13 || roll == 16 || roll == 19 ||
                        roll == 22 || roll == 25 || roll == 28 || roll == 31 || roll == 34)
                    {
                        Console.WriteLine("First column bet");
                    }
                    if (roll == 2 || roll == 5 || roll == 8 || roll == 11 || roll == 14 || roll == 17 || roll == 20 ||
                        roll == 23 || roll == 26 || roll == 29 || roll == 32 || roll == 35)
                    {
                        Console.WriteLine("Second column bet");
                    }
                    if (roll == 3 || roll == 6 || roll == 9 || roll == 12 || roll == 15 || roll == 18 || roll == 21 ||
                        roll == 24 || roll == 27 || roll == 30 || roll == 33 || roll == 36)
                    {
                        Console.WriteLine("Third column bet");
                    }
                    if (roll == 1 || roll == 2 || roll == 3 || roll == 4 || roll == 5 || roll == 6 || roll == 7 || roll == 8 || roll == 9 ||
                        roll == 10 || roll == 11 || roll == 12)
                    {
                        Console.WriteLine("1st 12 bet");
                    }
                    if (roll == 13 || roll == 14 || roll == 15 || roll == 16 || roll == 17 || roll == 18 || roll == 19 || roll == 20 || roll == 21 ||
                        roll == 22 || roll == 23 || roll == 24)
                    {
                        Console.WriteLine("2nd 12 bet");
                    }
                    if (roll == 25 || roll == 26 || roll == 27 || roll == 28 || roll == 29 || roll == 30 || roll == 31 || roll == 32 || roll == 33 ||
                        roll == 34 || roll == 35 || roll == 36)
                    {
                        Console.WriteLine("3rd 12 bet");
                    }







                    if (input == "spin")
                    {


                        spinWheel();

                    }
                    
                }

                else if (input == "quit")
                {
                    
                    game = false;
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("please try again. thank you");
                    Console.ResetColor();
                }
            }
        }
    }
}
