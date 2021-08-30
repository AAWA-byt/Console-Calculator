using System;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num_1 = 0;
            double num_2 = 0;

            Console.WriteLine("Consolecalculator\r");
            Console.WriteLine("------------------------");

            Console.WriteLine("What is the first number of your calculation?");
            num_1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the seccond number of your calculation?");
            
            num_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What kind of calculation do you want to do?");
            Console.WriteLine("\ta - addition");
            Console.WriteLine("\ts - subtraction");
            Console.WriteLine("\tm - multiplication");
            Console.WriteLine("\td - division");
            Console.Write("-> ");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Result: {num_1} + {num_2} = " + (num_1 + num_2));
                    break;
                case "s":
                    Console.WriteLine($"Result: {num_1} - {num_2} = " + (num_1 - num_2));
                    break;
                case "m":
                    Console.WriteLine($"Result: {num_1} * {num_2} = " + (num_1 * num_2));
                    break;
                case "d":
                    Console.WriteLine($"Result: {num_1} / {num_2} = " + (num_1 / num_2));
                    break;
            }
            Console.WriteLine("------------------------");
            Console.Write("Press a random key to close the window...");
            Console.ReadKey();
        }
    }
}
