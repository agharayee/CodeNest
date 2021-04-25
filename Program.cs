using System;

namespace CodeNest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input the first number");
            var entry1 = Console.ReadLine();

            Console.WriteLine("Please Input the Second number");
            var entry2 = Console.ReadLine();

            Remainder(entry1, entry2);
        }
        public static void Remainder(string entry1, string entry2)
        {     
            try
            {
                var number1 = Convert.ToInt32(entry1);
                var number2 = Convert.ToInt32(entry2);
                var result = number1 % number2;
                System.Console.WriteLine($"The remainder of {number1} and {number2} is {result}");
            }
            catch
            {
                Console.WriteLine("The value you passed in was not able to process. Please provide another number");
            }
        }
    }
}
