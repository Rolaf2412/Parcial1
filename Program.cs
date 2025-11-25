// See https://aka.ms/new-console-template for more information
using System;

class Examen1
{
static void Main(string[] arg)
    {
        Computador Alex = new Computador("Alex","Computador");
        Alex.MostrarInfo();
        Alex.Apagar();
        Alex.Prender();
        Alex.IEnviarMensaje();
        Televisor TV = new Televisor("Samsung TCL","Televisor");
        TV.MostrarInfo();
        TV.Apagar();
        TV.Prender();
    }    
}
