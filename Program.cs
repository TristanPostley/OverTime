using System;

namespace OverTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.WriteLine("Hello, to calculate overtime pay please input a start time after 9, an end time, a pay rate, and an overtime multiplier.");
            Console.WriteLine("Start time: ");
            double startTime = double.Parse(Console.ReadLine());
            Console.WriteLine("End time: ");
            double endTime = double.Parse(Console.ReadLine());
            Console.WriteLine("Pay rate: ");
            double payRate = double.Parse(Console.ReadLine());
            Console.WriteLine("multiplier: ");
            double multiplier = double.Parse(Console.ReadLine());

            if(endTime <= 17)
            {
                total = (endTime - startTime) * payRate;
            }
            else 
            {
                double basePay = (17 - startTime) * payRate;
                double overPay = (endTime - 17) * payRate * multiplier;
                total = basePay + overPay;
            }

            Console.WriteLine($"Your total pay is: ${total.ToString("F")}");
        }
    }
}
