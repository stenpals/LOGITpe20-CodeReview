using System;

namespace ToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a word");
            string word = Console.ReadLine().ToLower();
            switch (word)
            {
                case "sunday":
                  Console.WriteLine("A");
                    break;
                case "monday":
                    Console.WriteLine("B");
                    break;
                case "tuesday":
                    Console.WriteLine("C");
                    break;
                case "wednesday":
                    Console.WriteLine("D");
                    break;
                case "thursday":
                    Console.WriteLine("E");
                    break;
                case "friday":
                    Console.WriteLine("F");
                    break;
                case "saturday":
                    Console.WriteLine("G");
                    break;
                
                    
                    

            }
        }
    }
}