using System.Collections;

namespace Methods_Classes_Basics
{
    public class Methods_Classes
    {
        public static void callMethod()
        {
            Random rd = new Random();
            int roll = rd.Next(1, 7);
            Console.WriteLine(roll);

            int number = 7;
            string text = "seven";

            Console.WriteLine(number);
            Console.WriteLine();
            Console.WriteLine(text);

            Random dice = new Random();
            int roll1 = dice.Next();
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);

            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");


            int firstValue = 500;
            int secondValue = 600;
            int largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);
        }
    }
}