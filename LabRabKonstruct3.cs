using System;
using static System.Math;
class tochki
{
    public double xp;
    public double yp;
    public double zp;
    public double xm;
    public double ym;
    public double zm;
    public tochki(double xp, double yp, double zp, double xm, double ym, double zm)
    {
        this.xp = xp;
        this.yp = yp;
        this.zp = zp;
        this.xm = xm;
        this.ym = ym;
        this.zm = zm;
    }
    public void zhivotnie()
    {
        double pipka = Math.Sqrt(Math.Pow(xp - xm, 2) + Math.Pow(yp - ym, 2));
        Console.WriteLine("Расстояние по плоскости- " + Math.Round(pipka, 5));
        double popka = Math.Sqrt(Math.Pow(xp - xm, 2) + Math.Pow(yp - ym, 2) + Math.Pow(zp - zm, 2));
        Console.WriteLine("Расстояние по прямой между мехой и пауком- " + Math.Round(popka, 5));
    }
}
class Program
{
    public static void Main()
    {
        var tupienasekomie = new tochki(3,5.6,7,9,0,1.4);
        tupienasekomie.zhivotnie();
    }
}

