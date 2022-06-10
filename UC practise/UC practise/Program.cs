using System;

namespace UC_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int WagePerHR = 20;
            Random random = new Random();
            int value = random.Next(0, 3);
            switch (value)
            {
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is present part time");
                    int salary = WagePerHR * 4;
                    Console.WriteLine(salary);
                    break;
                case 2:
                    Console.WriteLine("Employee is present full time");
                    int salaryfulltime = WagePerHR * 8;
                    Console.WriteLine(salaryfulltime);
                    break;




            }
        }
    }
}
