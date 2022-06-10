using System;

namespace UC_practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == 0)
            {
                Console.WriteLine("Emplyoee is absent");
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Employee is present");
                Console.WriteLine(value);
            }
        }
    }
}
