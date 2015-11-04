using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourlypayrate;
            Console.Write(" Please enter your hourly pay rate");
            hourlypayrate = Convert.ToDouble(Console.ReadLine());

            if (hourlypayrate < 5.65)
                Console.WriteLine("error");
        }
    }
}
