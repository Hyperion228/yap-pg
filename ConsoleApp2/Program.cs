using System;
using System.Collections.Generic;
using static System.Console;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> popkaChet = new List<double>();
            List<double> popkaNechet = new List<double>();
            Write("Введите х: ");
            double x = Convert.ToDouble(ReadLine());
            Write("Введите числа: ");
            string s = ReadLine();
            string[] mas = s.Split(' ');
            foreach (string z in mas)
            {
                double allchisla = Convert.ToDouble(z);
                if ((double)allchisla % 2 >= 0 && (double)allchisla % 2 < 1)
                {
                    popkaChet.Add(allchisla);
                }
                else
                {
                    popkaNechet.Add(allchisla);
                }
                popkaChet.Sort();
            } 
            foreach (double pipka in popkaChet)
            {
                Write(pipka);
                Write(" ");
            }
            WriteLine();
            foreach (double pipkaNechet in popkaNechet)
            {
                if(pipkaNechet > x)
                {
                    Write(pipkaNechet);
                    Write(" ");
                }
                
            }

        }
    }
}