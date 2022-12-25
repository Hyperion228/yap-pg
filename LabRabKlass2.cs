using System;
namespace laba;
class MyString
{
    public string s;
    public MyString(string s = "я не знаю что тут написать")
    {
        this.s = s;
    }
    public void UcFirst()
    {
        s = this.s.Substring(0, 1).ToUpper() + s.Substring(1);
    }
    public void UcWords()
    {
        string[] str = s.Split(' ');
        s = "";
        for (int i = 0; i < str.Length; i++)
        {
            s += str[i].Substring(0, 1).ToUpper() + str[i].Substring(1)+' ';
        }
    }
    public void Reverse()
    {
        string popchik = "";
        for (int i = s.Length - 1; i >=0; i--)
        {
            popchik += s[i];
        }
        this.s = popchik;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        MyString myString = new MyString("zhopa popa pipa");
        myString.UcWords();
        Console.WriteLine(myString.s);
    }
}
