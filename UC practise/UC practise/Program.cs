using System;

namespace UC_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int WagePerHR = 20;
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == 0)
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Employee is present");
                int salary = WagePerHR * 8;
                Console.WriteLine(salary);
            }
        }
    }
}
