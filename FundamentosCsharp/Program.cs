// See https://aka.ms/new-console-template for more information
using FundamentosCsharp.Models;

internal class Program
{

    private static void Main(string[] args)
    {
        CervezaBD cervezaBd = new CervezaBD();
        var cervezas = cervezaBd.Get();

        foreach( var cerveza in cervezas )
        {
            Console.WriteLine(cerveza.Nombre);  
        }


    }

   
}