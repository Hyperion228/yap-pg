class vasya
{
    public string name;
    public int age;
    public vasya(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Metod()
    {
        string leta;
        if (name != "Василий")
        {
            Console.WriteLine("Я не Максим, а Василий!");
        }
        if (age < 0)
        {
            age = 0;
        }
        else if (age > 122)
        {
            age = 122;
        }
        if (age >= 10 && age <= 20)
            Console.WriteLine("{0} лет", age);
        else
        {
            int lastNumberAge = age % 10;
            switch (lastNumberAge)
            {
                case 1:
                    Console.WriteLine("{0} год", age);
                    break;
                case 2:
                case 3:
                case 4: Console.WriteLine("{0} годa", age);
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0: Console.WriteLine("{0} лет", age);
                    break;
            }
        }
    
    }
}
class Program
{
    public static void Main()
    {
        var vaska = new vasya("Василий", 19);
        vaska.Metod();
            
