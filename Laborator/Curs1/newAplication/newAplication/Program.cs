
using System;


public class Program
{
    public static void Main(string[] args)
    {
        SenzorTemperatura senzor = new SenzorTemperatura();

        senzor.AlarmaPornita += TemperaturaPericuloasa;

        senzor.VerificaTemperatura(85);
        senzor.VerificaTemperatura(102);
    }

    public static void TemperaturaPericuloasa(double temp)
    {
        Console.WriteLine($"Alera! Temperatura periculoasa {temp}");
    }
}

public class SenzorTemperatura
{
    public delegate void AlarmHandler(double temperatura);
    public event AlarmHandler AlarmaPornita;

    public void VerificaTemperatura(double temperatura)
    {
        Console.WriteLine($"Temperatura citita :  {temperatura}");
        if(temperatura > 100)
            AlarmaPornita?.Invoke(temperatura);
    }
}
