using System;
using System.Collections.Generic;

public delegate bool ValidareNumar(int numar);

public class Program
{
    public static void Main(string[] args)
    {
        
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
}






















