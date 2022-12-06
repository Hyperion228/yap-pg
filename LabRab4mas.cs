using System;
using System.Text.RegularExpressions;


namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Convert.ToString(Console.ReadLine());
            int[] smas = new int[str.Length];
            for (int j = 0; j < str.Length; j++)
            {
                smas[j] = Convert.ToInt32(str.Substring(j, 1));
            }
            for(int i = 0; i < smas.Length; i++)
            {
                if (smas[i] == 2)
                {
                    Console.WriteLine("Пора долг родине отдать!");
                    break;
                }
                else if (smas[i] == 3 && smas[i] != 2)
                {
                    Console.WriteLine("Прощай стипендия!");
                    break;
                }
                else if (smas[i] != 3 && smas[i] != 2 && smas[i] == 4)
                {
                    Console.WriteLine("Живи пока, через полгода увидимся!");
                    break;
                }
                else if (smas[i] != 3 && smas[i] != 2 && smas[i] != 4 && smas[i] ==5)
                {
                    Console.WriteLine("О, отличник появился! На олимпиаду пойдешь");
                    break;
                }
            }
        }
    }
}
