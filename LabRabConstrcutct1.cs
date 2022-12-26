namespace LabRab2Construct;
class Watch{
    string Mark;
    string mechanism;
    decimal qwerty;
    public Watch(string Mark, string mechanism, decimal qwerty)
    {
        this.Mark = Mark;
        this.mechanism = mechanism;
        this.qwerty = qwerty;
    }
    public void Print()
    {
        Console.WriteLine($"{Mark} классные часы сам ношу,{mechanism} говно, лучше механические, {qwerty}");

    }

}
class Program
{
    public static void Main()
    {
        var myWatch = new Watch("Casio", "electronic", 15.99M);
        myWatch.Print();
    }
}

