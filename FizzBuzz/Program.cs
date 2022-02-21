using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(NumberRules(i));
            }
            
        }
        static string NumberRules(int number)
        {
                string result = "";

                if (number % 3 == 0) 
                {
                    result += "Fizz";
                }
                if (number % 5 == 0)
                {
                    result += "Buzz";
                }
                if (number % 7 == 0)
                {
                    result += "Bang";
                }
                if (result == "")
                {
                    result = number.ToString();
                }
                return result;
        }
    }
}