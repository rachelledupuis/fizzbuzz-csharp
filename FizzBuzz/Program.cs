using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = "";

                if (i % 3 == 0) 
                {
                    result += "Fizz";
                }
                if (result == "")
                {
                    result = i.ToString();
                }
                Console.WriteLine(result);
            }
        }
    }
}