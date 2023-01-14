namespace Laba6;
using System.Security.Cryptography.X509Certificates;

class Mentor
{
    public string MentorName;
    public string MentorLastName;
    public string listKursZ;
    public string ZakrepSpisokKursov;
}
class Lecturer : Mentor
{
    public double RatingL;
    public Lecturer(string MentorName, string MentorLastName, double RatingL, string listKursZ)
    {
        this.MentorName = MentorName;
        this.MentorLastName = MentorLastName;
        this.RatingL = RatingL;
        this.listKursZ = listKursZ;
    }

    public void Lectorurers()
    {
        Console.WriteLine($"\nИмя: {MentorName}\nФамилия: {MentorLastName}\nОценка: {RatingL}\nКурсы: {listKursZ}\n");
    }

}
class Reviewer : Mentor
{
    public Reviewer(string MentorName, string MentorLastName)
    {

    }
}
class Student
{
    public string Name;
    public string LastName;
    public string Gender;
    public string Kurs;
    public double Rating;
    public string ProidenKurs;
    public string SpisokKurs;
    public Student(string Name, string LastName, string Gender, string Kurs, double Rating, string ProidenKurs, string SpisokKurs)
    {
        this.Name = Name;
        this.LastName = LastName;
        this.Gender = Gender;
        this.Kurs = Kurs;
        this.Rating = Rating;
        this.ProidenKurs = ProidenKurs;
        this.SpisokKurs = SpisokKurs;
    }

    public void students()
    {
        Student student = new Student("Some", "Buddy", "Muzhik", "Python", 9.6, "Go", "Python,Go");
        Console.WriteLine($"Имя:{Name}\nФамилия: {LastName}\nПол:{Gender}\nКурс: {Kurs}\nОценка: {Rating}\nПройден курс: {ProidenKurs}\nСписок курсов: {SpisokKurs}\n");
    }
}
class Versus
{
    public double lectorR;
    public double studentR;
    public Versus(double Rating, double RatingL)
    {
        lectorR = Rating;
        studentR = RatingL;
    }
    public void Vs()
    {
        double result;
        if(lectorR > studentR)
        {
            result = (lectorR / studentR) * 100 - 100;
            Console.WriteLine($"Оценка Лектора лучше оценки студентаа! На {result}%");
        }
        else
        {
            result = (studentR / lectorR) * 100 - 100;
            Console.WriteLine($"Оценка студента лучше оценки Лектора! На {result}%");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Versus versus = new Versus(8.6,9.6);
        Student student = new Student("Some", "Buddy", "Muzhik", "Python", 9.6, "Go", "Python,Go");
        Lecturer lecs = new Lecturer("Some", "Buddy", 8.6, "Python,Go");
        lecs.Lectorurers();
        student.students();
        versus.Vs();
    }
}

