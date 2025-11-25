using System;

class Computador : Maquina, IEnviarMensaje
{
    public Computador(string nom, string tipo) : base(nom, tipo)
    {
    }
    public void IEnviarMensaje()
    {
        Console.WriteLine("Mensaje enviado");
    }
}
