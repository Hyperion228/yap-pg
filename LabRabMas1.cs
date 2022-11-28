using System;
using static System.Console;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите текст: ");
            string plump = ReadLine();
            string[] popka = plump.Split(' ');
            foreach (var pops in popka)
            {
                foreach (var letter in pops)
                    Console.WriteLine(letter);
                Console.WriteLine();
            }
        }
    }
}
