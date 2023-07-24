using System;
// using DiceRoller.Models;
// I need 2 C# methods that can actually generate a random nmber for me thats between 1-6; those will serve as my pair of dice value

// A namespace is a collection of classes 
namespace DiceRoller.Models
{
    public class MyDiceRoller
    {
        private static readonly Random RandomDiceNum = new Random();

        public int GetRanDieNumber(int num1, int num2)
        {
            // num1 = 1;
            // num2 = 6;

            if(num1 > num2)
            {
                int newNum = num1;
                num1 = num2;
                num2 = newNum;
            }


            return RandomDiceNum.Next(num1, num2);
        }
    }
}
