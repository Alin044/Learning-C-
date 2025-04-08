// See https://aka.ms/new-console-template for more information

public delegate void AfisareMesaj(string mesaj);

class Program
{
    static void Main(string[] args)
    {
        AfisareMesaj delegat = AfiseazaPeEcran;
        delegat("Salut din C#!");
    }

    private static void AfiseazaPeEcran(string mesaj)
    {
        Console.WriteLine(mesaj);
    }
}