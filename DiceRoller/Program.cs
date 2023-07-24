using System;
using System.Collections.Generic;

using DiceRoller.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Hello and welcome to the DiceRoller console application");
        Console.WriteLine();
        Console.WriteLine("To Continue playing game, enter 'ok' and if not, enter 'x' ");
        String userAns = Console.ReadLine().ToUpper();

        Console.WriteLine();
        Console.WriteLine();

        if (userAns == "OK")
        {
            // Generating the random numbers for player1
            MyDiceRoller rng = new MyDiceRoller();
            int Player1dicea = rng.GetRanDieNumber(1, 6);
            int Player1diceb = rng.GetRanDieNumber(1, 6);
            Console.WriteLine("================ Player 1's turn ================ ");
            Console.WriteLine($"Player1 rolled a  {Player1dicea} and a {Player1diceb}");

            // Summing up player1's total dice number rolled
            int Player1Total = Player1dicea + Player1diceb;

            Console.WriteLine();
            Console.WriteLine("To Continue Playing enter 'ok' and to quit, enter 'x'");
            string userAns2 = Console.ReadLine().ToUpper();

            if (userAns2 == "OK")
            {
                // Continuing to play
                Console.WriteLine();
                Console.WriteLine(" ================ Now it's Player 2's turn  ================ ");
                MyDiceRoller rng2 = new MyDiceRoller();
                int Player2dicea = rng2.GetRanDieNumber(1, 6);
                int Player2diceb = rng2.GetRanDieNumber(1, 6);
                Console.WriteLine($"Player2 rolled a {Player2dicea} and a {Player2diceb}");

                int Player2Total = Player2dicea + Player2diceb;

                Console.WriteLine();
                Console.WriteLine("To see the winner, enter 'true', to exit; enter 'false'");
                string seewinnerString = Console.ReadLine().ToUpper();
                bool seewinnerBool = bool.Parse(seewinnerString);

                if (seewinnerBool)
                {
                    if (Player1Total > Player2Total)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Player1 had a total of {Player1Total} and Player2 had a total of {Player2Total}");

                        Console.WriteLine();
                        Console.WriteLine("==========||===========");
                        Console.WriteLine("Player 1 is the winner");
                        Console.WriteLine("==========||===========");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("To Play Again, enter 'ok', to quit game enter 'x'");
                        string userContinue = Console.ReadLine().ToUpper();

                        if (userContinue == "OK")
                        {
                            Main();
                        }
                        else if (userContinue == "X")
                        {
                            Console.WriteLine("Goodbye My Dear User");
                        }
                        else
                        {
                            Console.WriteLine("Sorry I didn't get that, Please try again");
                            Console.WriteLine();
                            Console.WriteLine();
                            Main();

                        }
                    }
                    else if (Player2Total > Player1Total)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Player1 had a total of {Player1Total} and Player2 had a total of {Player2Total}");

                        Console.WriteLine();
                        Console.WriteLine("==========||===========");
                        Console.WriteLine("Player 2 is the winner");
                        Console.WriteLine("==========||===========");
                        Console.WriteLine();
                        Console.WriteLine("To Play Again, enter 'ok', to quit game enter 'x'");
                        string userContinue = Console.ReadLine().ToUpper();

                        if (userContinue == "OK")
                        {
                            Main();
                        }
                        else if (userContinue == "X")
                        {
                            Console.WriteLine("Goodbye My Dear User");
                        }
                        else
                        {
                            Console.WriteLine("Sorry I didn't get that, Please try again");
                            Console.WriteLine();
                            Console.WriteLine();
                            Main();

                        }

                    }
                    else if (Player1Total == Player2Total)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Player1 had a total of {Player1Total} and Player2 had a total of {Player2Total}");

                        Console.WriteLine();
                        // I didn't use else in this branch because I took care of the 3 possible scenarios that can happen all by myself
                        Console.WriteLine("It was a tie, nobody won the previous round. Lets go again");
                        Main();
                    }

                }

                else if (!seewinnerBool)
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye My Dear User");

                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Sorry, I did not get that; lets try again");
                    Main();
                }


            }
            else if (userAns == "X")
            {
                Console.WriteLine();
                Console.WriteLine("Goodbye My Dear User");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Sorry I didn't get that, Please try again");
                Console.WriteLine();
                Console.WriteLine();
                Main();

            }
        }

        else if (userAns == "X")
        {
            Console.WriteLine();
            Console.WriteLine("Goodbye My Dear User");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Sorry I didn't get that, Please try again");
            Console.WriteLine();
            Console.WriteLine();
            Main();

        }

    }

}