using System;
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            void Factorize()
            {
                int step = 1;
                int pipka = Convert.ToInt32(Console.ReadLine());
                int popka = 1;
                int jhopka;
                for (int i = 0; i <= popka; i++)
                {
                    if(pipka % step == 0)
                    {
                        jhopka = pipka / step;
                        Console.WriteLine($"{pipka} = {step} * {jhopka}");
                    }
                    popka += 1;
                    step +=  1; 
                }
           }
            Factorize();
         }
        
    }

}
