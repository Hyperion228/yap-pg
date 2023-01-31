namespace lab6_finish;
class Student
{
    public string FirstName;
    public string LastName;
    public string Gender;
    public List<string> CoursesTaken;
    public List<double> GradeforHomework;
    public Dictionary<string, double> Grades;
    public List<string> CurrentCourses;
    public List<double> GradeToLections;

    public Student(string firstName, string lastName, string gender)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        CoursesTaken = new List<string>();
        Grades = new Dictionary<string, double>();
        CurrentCourses = new List<string>();
        GradeforHomework = new List<double>();
        GradeToLections = new List<double>();
    }
    public void AddCompletedCourse(List<string>CurrentCourses)
    {
        for(int i = 0; i < CurrentCourses.Count; i++)
        {
            CoursesTaken.Add(CurrentCourses[i]);
            CurrentCourses.Remove(CurrentCourses[i]);
        }
    }
    public void AverageRatingstd()
    {
        double Avg = 0;
        foreach(double num in GradeforHomework)
        {
            Avg += num;
        }
        Avg /= GradeforHomework.Count;
        Console.WriteLine($"\nСтудент\nИмя: {FirstName}\nФамилия: {LastName}\nСредняя оценка за домашние задания: {Avg}");
        Console.Write("Курсы в процессе изучения: ");
        for(int i = 0; i < CurrentCourses.Count; i++)
        {
            Console.Write(CurrentCourses[i] + " ");
        }
        Console.WriteLine();
        Console.Write("Завершенные курсы: ");
        for (int j = 0; j < CoursesTaken.Count; j++)
        {
            Console.Write(CoursesTaken[j] + " ");
        }
    }
}
class Mentor
{
    public string Name;
    public string Surname;
    public List<string> Courses;
}
class Rewiever : Mentor
{
    public Rewiever(string name, string surname)
    {
        Name = name;
        Surname = surname;
    }
    public void addGrade(Student student,List<double>GradeForHome)
    {
        for(int i = 0; i < GradeForHome.Count; i++)
        {
            student.GradeforHomework.Add(GradeForHome[i]);
        }
        Console.WriteLine($"Ревьюер\nИмя: {Name}\nФамилия: {Surname}\n");
    }
}
class Lecturer : Mentor
{
    public List<double> GradeForLEctions;

    public Lecturer(string name, string surname)
    {
        Name = name;
        Surname = surname;
        GradeForLEctions = new List<double>();
    }
    public void AverageRatingRwr()
    {
        double Avg = 0;
        foreach(double num in GradeForLEctions)
        {
            Avg += num;
        }
        Avg /= GradeForLEctions.Count;
        Console.WriteLine($"Лектор\nИмя: {Name}\nФамилия: {Surname}\nСредняя оценка за лекции: {Avg}");

    }
}
class Program
{
    static void Main(string[] args)
    {
        Lecturer lecturer = new Lecturer("Zhopa","Popa");
        lecturer.GradeForLEctions.Add(7.6);
        lecturer.GradeForLEctions.Add(5.4);
        Rewiever rewiever = new Rewiever("Bob","Dob");
        List<double> RewGrade = new List<double>{8.3,2.6,5.6};
        Student student = new Student("Pol","Walker","Man");
        List<string> Acc = new List<string> { "Python", "C#" };
        student.Grades.Add("Python", 8.9);
        student.Grades.Add("C#", 9.9);
        student.CurrentCourses.Add("Python");
        student.CurrentCourses.Add("C#");
        student.GradeToLections.Add(8.5);
        student.GradeToLections.Add(7.1);
        rewiever.addGrade(student,RewGrade);
        lecturer.AverageRatingRwr();
        student.AddCompletedCourse(Acc);
        student.AverageRatingstd();
    }
}

