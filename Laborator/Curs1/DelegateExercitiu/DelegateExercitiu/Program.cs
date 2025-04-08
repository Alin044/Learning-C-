// See https://aka.ms/new-console-template for more information

public delegate void NotificareDelegate(string mesaj);

class Program
{
    static void Main()
    {
        Magazin magazin = new Magazin();
        magazin.Notificare += TrimiteEmail;
        magazin.Notificare += TrimiteSMS;
        magazin.PlaseazaComanda("Laptop", "Ion Popescu");
    }

    static void TrimiteEmail(string mesaj)
    {
        Console.WriteLine($"[EMAIL] {mesaj}");
    }

    static void TrimiteSMS(string mesaj)
    {
        Console.WriteLine($"[SMS] {mesaj}");
    }
}

class Magazin
{
    public event NotificareDelegate Notificare;

    public void PlaseazaComanda(string produs, string client)
    {
        Console.WriteLine($"Comanda pentru {produs} a fost plasata de {client}");
        if (Notificare != null)
        {
            Notificare($"Comanda pentru {produs} este in procesare.");
        }
    }
}