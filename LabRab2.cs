using System;
using static System.Console;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            int number = int.Parse(ReadLine());
            int count = 0;
            while (number > 1)
            {
                if (number % 2 == 0)
                    number /= 2;
                else number = number * 3 + 1;
                count++;
            }
            WriteLine($"Количество необходимых действий над числом - {count}");
        }
    }
}
