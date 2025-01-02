// See https://aka.ms/new-console-template for more information
using FundamentosCsharp.Models;

internal class Program
{

    private static void Main(string[] args)
    {
        var bebidaRoja = new Vino(100);
        var bebidaNegra = new Cerveza(100);
        MostraReco(bebidaRoja, bebidaRoja.Nombre);
        MostraReco(bebidaNegra, bebidaNegra.Nombre );
        

    }

    static void MostraReco(IbebidaAlcoholica bebida, string? nombre)
    {
        Console.WriteLine(nombre); 
        bebida.MaxRecomendado();
    }

}