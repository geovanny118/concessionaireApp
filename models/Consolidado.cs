using System;

public class Consolidado {

    public const int MESES = 12;
    public const int SEMANAS = 4;
    public string[] nombres = { "A", "B", "C", "D" };
    public Vendedor[,] consolidado = new Vendedor[SEMANAS, MESES];
  
    public void SetConsolidado(){
        var seed = Environment.TickCount;
        var random = new Random(seed);

        for(int s=0; s< SEMANAS; s++){
            for(int m=0; m< MESES; m++){
                
                var nombre = random.Next(0, 4);

                Vendedor v = new Vendedor();
                v.Nombre = nombres[nombre];
                v.Ventas = random.Next(1, 100);
                consolidado[s, m] = v;
            }
        }
    }

    public void GetConsolidado(){
        for (int fila = 0; fila < consolidado.GetLength(0); fila++)
        {
            for (int col = 0; col < consolidado.GetLength(1); col++)
            {
                if(col == 0){
                    Console.Write("Semana " + (fila+1) + ": ");
                }

                Console.Write(consolidado[fila, col].Nombre+ "-" + consolidado[fila, col].Ventas + "\t");
            }
            Console.WriteLine();
        }
    }

    public void GetVendedorAnual(){
        int a=0, b=0, c=0, d=0, max=0, ventas=0;
        //ventasAnuales = [ventas de A, ventas de B, ventas de C, ventas de D]
        int[] ventasAnuales = new int[4];

        for (int fila = 0; fila < consolidado.GetLength(0); fila++)
        {
            for (int col = 0; col < consolidado.GetLength(1); col++)
            {
               switch(consolidado[fila, col].Nombre){
                case "A": 
                    a+= consolidado[fila, col].Ventas;
                    ventasAnuales[0] = a;
                    break;

                case "B":
                    b+= consolidado[fila, col].Ventas;
                    ventasAnuales[1] = b;
                    break;

                case "C":
                    c+= consolidado[fila, col].Ventas;
                    ventasAnuales[2] = c;
                    break;

                case "D":
                    d+= consolidado[fila, col].Ventas;
                    ventasAnuales[3] = d;
                    break;
               }
            }
        }

        Console.WriteLine("Ventas anuales de cada vendedor: " + " A:"+a+ " B:"+b + " C:"+c+ " D:" + d);

        for (int i = 0; i < 4; i++)
        {
            if (ventasAnuales[i] > ventas){
                max = i;
                ventas = ventasAnuales[i];
            }  
        }
        
        switch (max)
        {
            case 0:
                Console.WriteLine("El mejor vendedor anual es A con " + a + " Ventas");
                break;

            case 1:
                Console.WriteLine("El mejor vendedor anual es B con " + b + " Ventas");
                break;

            case 2:
                Console.WriteLine("El mejor vendedor anual es C con " + c + " Ventas");
                break;

            case 3:
                Console.WriteLine("El mejor vendedor anual es D con " + d + " Ventas");
                break;
        }
    }

    public void GetMesMejorVenta()
    {
        int ventas = 0, mes=0;
        for (int fila = 0; fila < consolidado.GetLength(0); fila++)
        {
            for (int col = 0; col < consolidado.GetLength(1); col++)
            {
                if (consolidado[fila, col].Ventas > ventas)
                {
                    mes = col;
                    ventas = consolidado[fila, col].Ventas;
                }
            }
        }

        switch (mes)
        {
            case 0:
                Console.WriteLine("Enero fue el mes de la mejor venta del año.");
                break;

            case 1:
                Console.WriteLine("Febrero fue el mes de la mejor venta del año.");
                break;

            case 2:
                Console.WriteLine("Marzo fue el mes de la mejor venta del año.");
                break;

            case 3:
                Console.WriteLine("Abril fue el mes de la mejor venta del año.");
                break;

            case 4:
                Console.WriteLine("Mayo fue el mes de la mejor venta del año.");
                break;

            case 5:
                Console.WriteLine("Junio fue el mes de la mejor venta del año.");
                break;

            case 6:
                Console.WriteLine("Julio fue el mes de la mejor venta del año.");
                break;

            case 7:
                Console.WriteLine("Agosto fue el mes de la mejor venta del año.");
                break;

            case 8:
                Console.WriteLine("Septiembre fue el mes de la mejor venta del año.");
                break;

            case 9:
                Console.WriteLine("Octubre fue el mes de la mejor venta del año.");
                break;

            case 10:
                Console.WriteLine("Noviembre fue el mes de la mejor venta del año.");
                break;

            case 11:
                Console.WriteLine("Diciembre fue el mes de la mejor venta del año.");
                break;
        }
    }

    public void getVendedoresCuartaSemanaMensual(){
        Console.WriteLine("Vendedores de la cuarta semana de cada mes: ");
        for (int col = 0; col < consolidado.GetLength(1); col++)
        {
            Console.Write(consolidado[3, col].Nombre + " ");
        }
        Console.WriteLine();
    }

    public void getVendedorDiciembre(){
        int venta= 0;
        string vendedor="";
        for (int fila = 0; fila < consolidado.GetLength(0); fila++)
        {
            if(consolidado[fila, 11].Ventas > venta){
                venta = consolidado[fila, 11].Ventas;
                vendedor = consolidado[fila, 11].Nombre;
            }   
        }
        Console.Write("Mejor vendedor de diciembre es " + vendedor + " ventas: " + venta);
    }
}