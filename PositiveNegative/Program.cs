using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program checks if the number is positive or negative*/

            Console.WriteLine("Enter your number: ");
            string UserInput = Console.ReadLine();
            int Num1 = Int32.Parse(UserInput);
            
           
            
            if (Num1 > 0)
            
            Console.WriteLine("The number is positive.");
            if (Num1 == 0)

            Console.WriteLine("The number is negative.");
            if (Num1 < 0)
                Console.WriteLine("This number is negative.");
            
        }
    }
}
