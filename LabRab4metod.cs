using System;
using System.Collections.Generic;


namespace ConsoleApp7
{
    class Program
    {
        static void PrintEven(List<int> jhopka)
        {
             for (int i = 0; i < jhopka.Count; i+=2)
            {
                Console.Write(jhopka[i]);
                Console.Write(' ');
            } 
        }
        static List<int> GetMultiple(int startValue, int endValue)
        {
            List<int> jhopka = new List<int>();
            for ( int j = startValue; j < endValue; j++)
            {
                if (j % 7 == 0 && j != 0)
                {
                    jhopka.Add(j);
                }
            }
            return jhopka;      
        }
        static void Main(string[] args)
        {
            int startValue = int.Parse(Console.ReadLine());
            int endValue = int.Parse(Console.ReadLine());
            PrintEven(GetMultiple(startValue, endValue));
        }
    }
}
