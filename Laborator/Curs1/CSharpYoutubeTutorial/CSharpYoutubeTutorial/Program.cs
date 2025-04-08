using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpYoutubeTutorial;

class Program
{
    static void Main(string[] args)
    {
        
    }
}

class Animal
{
    private string nume;
    private string specie;
    private int greutate;

    public Animal(string n, string s, int g)
    {
        nume = n;
        specie = s;
        greutate = g;
    }
    
    public void Sunet()
    {
        Console.WriteLine(nume);
    }
}

class Pisica : Animal
{
    private int varsta;
    private int nrMembre;
    public Pisica(string n, string s, int g, int v, int nr) : base(n, s, g)
    {
        varsta = v;
        nrMembre = nr;
    }
}