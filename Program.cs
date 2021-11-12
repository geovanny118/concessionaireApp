using System;

namespace concessionaireApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Consolidado c = new Consolidado();
            c.SetConsolidado();
            Console.WriteLine();
            c.GetConsolidado();
            Console.WriteLine();
            c.GetVendedorAnual();
            Console.WriteLine();
            c.GetMesMejorVenta();
            Console.WriteLine();
            c.getVendedoresCuartaSemanaMensual();
            Console.WriteLine();
            c.getVendedorDiciembre();
            Console.WriteLine();  
        }
    }
}
