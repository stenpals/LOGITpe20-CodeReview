using System;

namespace Speedometer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*The program asks for distance and time as input and displays the speed in kilometers per hour*/
            Console.WriteLine("Enter covered distance in km: ");
            int speed = Console.ReadLine();
            Console.WriteLine("Enter time spent in hour: ");
            int time = Console.ReadLine();

            double kph = speed % time;


        }
    }
}
