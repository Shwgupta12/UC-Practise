using System;

namespace UC_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int WagePerHr = 20;
            Random random = new Random();
            int value = random.Next(0, 3);
            if (value == 0)
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine(value);
            }
            else if (value == 1)
            {
                Console.WriteLine("Eployee is for part time");
                int salary = WagePerHr * 4;
                Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine("Emplyoee is for full time");
                int salary = WagePerHr * 8;
                Console.WriteLine(salary);
            }
        }
    }
}
