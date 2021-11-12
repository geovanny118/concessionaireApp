using System;

namespace concessionaireApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Consolidado c = new Consolidado();
            c.SetConsolidado();
            c.GetConsolidado();
            c.GetVendedorAnual();
            c.GetMesMejorVenta();
            c.getVendedoresCuartaSemanaMensual();
            c.getVendedorDiciembre();
        }
    }
}
