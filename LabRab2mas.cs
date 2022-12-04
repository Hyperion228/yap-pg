using System;
using static System.Console;



namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pipka = new int[] { 1,3,4,6,5 };
            int[] popka = new int[] { 1,3,5,7,9 };
            int jhopka = 0;
            for (int j = 0; j < popka.Length; ++j)
            {
                if (pipka[j] == popka[j])
                {
                    jhopka++;
                } 
            }
            WriteLine($"Совпадение {jhopka} элементов");
        }
        
    }
}
