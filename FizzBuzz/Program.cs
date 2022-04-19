using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = new List<string>();

            for (int i = 1; i <= 110; i++)
            {
                numbers.Add(NumberRules(i));
            }
            
            numbers.ForEach(Console.WriteLine);
            
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
                if (number % 11 == 0)
                {
                    result = "Bong";
                }
                if (result == "")
                {
                    result = number.ToString();
                }
                return result;
        }
    }
}