using System;
using System.Collections.Generic;
namespace ConsoleApp11
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int ind1 = 0;
            int ind2 = 0;
            List<double> popka = new List<double>();
            string s = Console.ReadLine();
            string[] mas = s.Split(' ');
            foreach(string z in mas)
            {
                int allchisla = Convert.ToInt32(z);
                popka.Add(allchisla);
            }
            for (int i = 0; i < popka.Count; i++)
            {
                if (popka[i] == 0)
                {
                    ind1 = i;
                    break;
                } 
            }
            for (int j = ind1 + 1; j < popka.Count; j++)
            {
                if (popka[j] == 0)
                {
                    ind2 = j;
                   break; 
                }
            }
            for (int q = ind1 + 1; q < ind2; q++)
            {
                Console.Write(popka[q]);
                Console.Write(' ');
            }
        }
    }
}
