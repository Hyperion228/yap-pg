using System;
using static System.Console;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            int hour = 12;
            int minute = 30;
            Write("Введите число щелчков: ");
            int steps = Convert.ToInt32(ReadLine());
            if (steps == 0)
            {
                WriteLine($"{hour} часов, {minute} минут");
            }
            else
            {
                hour = 13;
                minute = 10;
                for(int i = 0; i < steps - 1; i++)
                {
                     hour ++;
                     minute += 5;
                     hour %= 24;
                     minute %= 60;
                }
                WriteLine($"{hour} часов, {minute} минут");
                
            }
            
        }
    }
}
