using System;
using System.Drawing;
using Excep.Ejecucion;
using Excep.ExcepcionesPers;
using Excep.Piezas;

Reina reina = new Reina();
Ejec soluc1 = new Ejec(reina);
soluc1.PosicionarReina(1);
Console.WriteLine("Posiciones de la Pieza " + reina.nombrePieza);
soluc1.ImpTab();
PiezaInventada pInv = new PiezaInventada();
Ejec pError = new Ejec(pInv);

try
{
    if (pError.pruebaExcep())
    {
        Console.WriteLine("Solución encontrada para Pieza " + pInv.nombrePieza);
        pError.ImpTab();
    }
    else
    {
        Console.WriteLine("No se encontró una solución.");
    }
}
catch (SinSolucionException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine("Ubicacion error Personalizado:");
    Console.WriteLine(e.StackTrace);

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
finally
{
    Console.WriteLine();
    Console.WriteLine(" - - - - - - - - - - - -");
    Console.WriteLine("Finalización de Partida");
}

Console.ReadLine();