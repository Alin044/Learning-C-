
using System;


namespace InterfaceClassType;

public class Program
{
    public static void Main()
    {
        AngajatPartTime angajatPartTime = new AngajatPartTime("Ion Popescu", 25.5m, 80);
        Console.WriteLine($"Salariul lui {angajatPartTime.Nume} este: {angajatPartTime.CalculeazaSalariu()} lei");

        AngajatFullTime angajatFullTime = new AngajatFullTime("Maria Ionescu", 3500m);
        Console.WriteLine($"Salariul lui {angajatFullTime.Nume} este: {angajatFullTime.CalculeazaSalariu()} lei");

        ICalculeaza angajatPartTimeCalc = angajatPartTime;
        ICalculeaza angajatFullTimeCalc = angajatFullTime;

        Console.WriteLine($"Salariul angajatului part-time (prin ICalculeaza) este: {angajatPartTimeCalc.CalculeazaSalariu()} lei");
        Console.WriteLine($"Salariul angajatului full-time (prin ICalculeaza) este: {angajatFullTimeCalc.CalculeazaSalariu()} lei");
    }
}


public interface ICalculeaza
{
    decimal CalculeazaSalariu();
}

public class AngajatPartTime : ICalculeaza
{
    public string Nume { get; set; }
    public decimal TarifPeOra { get; set; }
    public int OreLucrate { get; set; }

    public AngajatPartTime(string nume, decimal tarifPeOra, int oreLucrate)
    {
        Nume = nume;
        TarifPeOra = tarifPeOra;
        OreLucrate = oreLucrate;
    }

    public decimal CalculeazaSalariu()
    {
        return TarifPeOra * OreLucrate;
    }
}

public class AngajatFullTime : ICalculeaza
{
    public string Nume { get; set; }
    public decimal SalariuFix { get; set; }

    public AngajatFullTime(string nume, decimal salariuFix)
    {
        Nume = nume;
        SalariuFix = salariuFix;
    }

    public decimal CalculeazaSalariu()
    {
        return SalariuFix;
    }
}




















