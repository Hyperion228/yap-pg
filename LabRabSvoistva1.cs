class Tree
{
    string drevo;
    int chislo;
    public Tree(string drevo, int chislo)
    {
        this.drevo = drevo;
        this.chislo = chislo;
    }

    public void Derevya()
    {
        Console.WriteLine($"{drevo},{chislo}");
    }
}
class Program
{
    public static void Main()
    {
        var tree1 = new Tree("сосна", -6);
        var tree2 = new Tree("береза", 80);
        tree1.Derevya();
        tree2.Derevya();
    }
}
