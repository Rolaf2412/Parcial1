using System;

public abstract class Maquina
{
    string Nombre;
    string tipo;

    public Maquina(string nom,string tipo)
    {
        this.Nombre = nom;
        this.tipo = tipo;
    }
    public void Prender()
    {
        Console.WriteLine("Esta prendido");
    }
    public void Apagar()
    {
        Console.WriteLine("Esta Apagado");
    }
    public void MostrarInfo()
    {
        Console.WriteLine("----------MAQUINA------------");
        Console.WriteLine(Nombre);
        Console.WriteLine(tipo);
        
    }
}