using System;

namespace FizzBuzz
{
    class Program
    {
        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string printString = "";
                bool multipleOfFive = i % 5 == 0;
                bool multipleOfThree = i % 3 == 0;

                if (multipleOfFive || multipleOfThree)
                {
                    if (multipleOfThree)
                    {
                        printString += Fizz;
                    }
                    if (multipleOfFive)
                    {
                        printString += Buzz;
                    }
                }
                else
                {
                    printString = i.ToString();
                }


                Console.Write(printString + " ");
            }
            Console.ReadLine();
        }
    }
}