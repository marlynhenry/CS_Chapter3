using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradePoint;
            Console.Write("Please enter you grade point average");
            gradePoint = Convert.ToInt32(Console.ReadLine());

            int testScore;
            Console.Write("Please enter your test score");
            testScore = Convert.ToInt32(Console.ReadLine());

            if (gradePoint >= 3.0)
            {
                if (testScore >= 60)
                    Console.WriteLine("Accepted");
                else Console.WriteLine("Reject");
            }
            if (gradePoint < 3)
            {
                if (testScore >= 80)
                    Console.WriteLine("Accepted");
                else Console.WriteLine("Reject");
            }
        }     
    }
}
