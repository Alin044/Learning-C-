// See https://aka.ms/new-console-template for more information

class Utilizator
{
    public string Nume { get; set; }
    public string Email { get; set; }
}

class SistemUtilizatori
{
    private List<Utilizator> utilizatori = new();

    public void AdaugaUtilizatori()
    {
        Console.Write("Introduceti numele utilizatorului : ");
        string nume = Console.ReadLine();
        Console.Write("Introduceti email : ");
        string email = Console.ReadLine();
        utilizatori.Add(new Utilizator { Nume = nume, Email = email });
        Console.WriteLine("Utilizator adaugat cu succes")
    }

    public void StergeUtilizatori()
    {
        Console.Write("Introduceti emailul utilizatorului de sters : ");
        string email = Console.ReadLine();
        utilizatori.RemoveAll(u => u.Email == email);
        Console.WriteLine("Utilizator sters cu succes");
    }

    public void AfiseazaUtilizatori()
    {
        Console.WriteLine("Lista utilizatorilor : ");
        foreach (var u in utilizatori)
        {
            Console.WriteLine($"{u.Nume} {u.Email}");
        }
    }
}

class Program
{
    static void Main()
    {
        SistemUtilizatori sistem = new SistemUtilizatori();
        while (true)
        {
            Console.WriteLine("1. Adauga utilizatori");
            Console.WriteLine("2. Stergeutilizatori");
            Console.WriteLine("3. Afiseazautilizatori");
            Console.WriteLine("4. Iesire");
            Console.Write("Alege o optiune : ");
            string optiune = Console.ReadLine();
            switch (optiune)
            {
                case "1": sistem.AdaugaUtilizatori(); break;
                case "2": sistem.StergeUtilizatori(); break;
                case "3": sistem.AfiseazaUtilizatori(); break;
                case "4": return;
                default: Console.WriteLine("Optiune un optiune valid"); break;
            }
        }
    }
}














