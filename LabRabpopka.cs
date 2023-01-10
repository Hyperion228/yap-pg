namespace codewars;
class Date
{
    public int day;
    public int month;
    public int year;

    public Date(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    public void Next()
    {
        day += 1;
        if(month == 4 && month  == 6 && month == 9 && month == 11)
        {
            if(day > 30)
            {
                day = day - 30;
            }
            else
            {
                day = day;
            }
        }
        else if(month == 2)
        {
            if (year % 4 != 0)
            {
                if(day > 28)
                {
                    day = day - 28;
                }
                else
                {
                    day = day;
                }
            }
            else
            {
                if(day > 29)
                {
                    day = day - 29;
                }
                else
                {
                    day = day;
                }
            }
        }
        else
        {
            if(day > 31)
            {
                day = day - 31;
            }
            else
            {
                day = day;
            }
        }
        Console.WriteLine(day);
    }
    public void Previous()
    {
        day -= 1;
        if (month == 4 && month == 6 && month == 9 && month == 11)
        {
            if (day == 0)
            {
                day = 31;
            }
            else
            {
                day = day;
            }
        }
        else if (month == 2)
        {
            if (year % 4 != 0)
            {
                if (day == 0)
                {
                    day = 31;
                }
                else
                {
                    day = day;
                }
            }
            else
            {
                if (day == 0)
                {
                    day = 31;
                }
                else
                {
                    day = day;
                }
            }
        }
        else
        {
            if (day == 0)
            {
                day = 31;
            }
            else
            {
                day = day;
            }
        }
        Console.WriteLine(day);
    }
    public void Print()
    {
        if (month > 12)
        {
            month = month - 12;
            year += 1;
        }
        if (month == 4 && month == 6 && month == 9 && month == 11)
        {
            if (day > 30)
            {
                day = day - 30;
                month += 1;
            }
            else
            {
                day = day;
            }
        }
        else if (month == 2)
        {
            if (year % 4 != 0)
            {
                if (day > 28)
                {
                    day = day - 28;
                    month += 1;
                }
                else
                {
                    day = day;
                }
            }
            else
            {
                if (day > 29)
                {
                    day = day - 29;
                    month += 1;
                }
                else
                {
                    day = day;
                }
            }
        }
        else
        {
            if (day > 31)
            {
                day = day - 31;
                month += 1;
            }
            else
            {
                day = day;
            }
        }
        string thisMonth = "";
        string[] mas = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        for(int i = 0; i < month; i++)
        {
            thisMonth = mas[i];
        }
        Console.WriteLine($"The {day} of {thisMonth} {year}");
    }
    public void PrintForward()
    {
        if(month == 4 && month == 6 && month == 9 && month == 11)
        {
            for (int i = day; i <= 30; i++)
            {
                day += 1;
                Console.WriteLine($"Day {day}.");
            }
        }
        else if (month == 2)
        {
            if (year % 4 != 0)
            {
                for (int j = day; j <= 28; j++)
                {
                    day += 1;
                    Console.WriteLine($"Day {day}.");
                }
            }
            else
            {
               for (int q = day; q <= 29; q++)
               {
                    day += 1;
                   Console.WriteLine($"Day {day}.");
               }
            }
        }
        else
        {
            for (int a = day; a < 31; a++)
            {
                day += 1;
                Console.WriteLine($"Day {day}.");
            }
        }
    }
    public void PrintBackward()
    {
        if (month == 4 && month == 6 && month == 9 && month == 11)
        {
            for (int i = day; i != 1; i--)
            {
                day -= 1;
                Console.WriteLine($"Day {day}.");
            }
        }
        else if (month == 2)
        {
            if (year % 4 != 0)
            {
                for (int j = day; j != 1; j--)
                {
                    day -= 1;
                    Console.WriteLine($"Day {day}.");
                }
            }
            else
            {
                for (int q = day; q != 1 ; q--)
                {
                    day -= 1;
                    Console.WriteLine($"Day {day}.");
                }
            }
        }
        else
        {
            for (int a = day; a != 1; a--)
            {
                day -= 1;
                Console.WriteLine($"Day {day}.");
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Date data = new Date(16, 04, 2004);
        data.PrintBackward();
    }
}

