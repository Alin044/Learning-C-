using System;
using System.Collections.Generic;

public delegate bool ValidareNumar(int numar);

public class Program
{
    public static void Main(string[] args)
    {
        List<int> lista = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        List<int> numerePare = FiltreazaNumere(lista, EstePar);

        Console.WriteLine("Numerele pare sunt : ");
        foreach (int n in numerePare)
        {
            Console.WriteLine(n);
        }
    }

    public static List<int> FiltreazaNumere(List<int> numere, ValidareNumar validare)
    {
        List<int> rezultat = new List<int>();
        foreach (int numar in numere)
        {
            if (validare(numar))
            {
                rezultat.Add(numar);
            }
        }
        return rezultat;    
    }

    public static bool EstePar(int numar)
    {
        return numar % 2 == 0;
    }
}






















