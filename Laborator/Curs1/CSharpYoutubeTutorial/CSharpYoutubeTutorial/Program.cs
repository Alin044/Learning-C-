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
        Vehicul masina = new Masina(1200, "Masina", "Autovehicul", 4, "4WeelDrive", 1040, 5);
        masina.Porneste();
    }
}

class Vehicul
{
    private int greutate;
    private string clasa;
    private string tipTransport;

    public Vehicul(int g, string cla, string tip)
    {
        greutate = g;
        clasa = cla;
        tipTransport = tip;
    }

    public virtual void Porneste()
    {
        Console.WriteLine("Porneste Vehiculul");
        Console.WriteLine("Greutate " + greutate);
        Console.WriteLine("Clasa " + clasa);
        Console.WriteLine("Tip Transport " + tipTransport);
    }
}

class Masina : Vehicul
{
    private int tractiune;
    private string tractiuneTip;
    private int caiPutere;
    private int nrUsi;

    public Masina(int g, string cla, string tip, int tractiune, string tractiuneTip, int caiPutere, int nrUsi) : base(g, cla, tip)
    {
        this.tractiune = tractiune;
        this.tractiuneTip = tractiuneTip;
        this.caiPutere = caiPutere;
        this.nrUsi = nrUsi;
    }

    public override void Porneste()
    {
        Console.WriteLine("Porneste Masina");
        Console.WriteLine("Tractiune " + tractiune);
        Console.WriteLine("Tractiune " + tractiuneTip);
        Console.WriteLine("Cai Putere " + caiPutere);
        Console.WriteLine("Nr Usi " + nrUsi);
    }
}

class MasinaElectrica : Masina
{
    private int mah;
    private int vitezaDeIncarcare;
    private string culoare;

    public MasinaElectrica(int g, string cla, string tip, int tractiune, string tractiuneTip, int caiPutere, int nrUsi, int mah, int vitezaDeIncarcare, string culoare) : base(g, cla, tip, tractiune, tractiuneTip, caiPutere, nrUsi)
    {
        this.mah = mah;
        this.vitezaDeIncarcare = vitezaDeIncarcare;
        this.culoare = culoare;
    }

    public override void Porneste()
    {
        Console.WriteLine("Porneste Masina Electrica");
        Console.WriteLine("Mah " + mah);
        Console.WriteLine("Viteza de inccarcare : " + vitezaDeIncarcare);
        Console.WriteLine("Coloare : " + culoare);
    }
}

/*class Animal
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
    
}*/