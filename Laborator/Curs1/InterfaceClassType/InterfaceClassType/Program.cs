
using System;


namespace InterfaceClassType;

public class Program
{
    public static void Main(string[] args)
    {
        
    }
}

public interface ICalculeaza
{
    decimal CalculeazaSalariu();
}

public class AngajamPartTime : ICalculeaza
{
    public string Nume { get; set; }
    public decimal TarifPeOra { get; set; }
    public int OreLucrate { get; set; }

    public AngajamPartTime(string nume, decimal tarifPeOra, int oreLucrate)
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




















