namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<string> pop = new List<string>();
            Console.WriteLine("Введите текст: ");
            string s = Console.ReadLine();
            pop = s.Split(' ').ToList();
            pop[0] = pop[0].Remove(pop[0].Length -1);
            pop[1] = pop[1] + ",";
            foreach(var pip in pop)
            {
                Console.Write(pip + ' ');

            }
        }
    }
}
