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
        Console.WriteLine();
    }

    public void GetConsolidado(){
        Console.WriteLine("\t\t\t\t\t\tCONSOLIDADO DE VENTAS AÑO 2020");
        Console.WriteLine("\t\tENE\tFEB\tMAR\tABR\tMAY\tJUN\tJUL\tAGO\tSEP\tOCT\tNOV\tDIC");
        for (int fila = 0; fila < consolidado.GetLength(0); fila++)
        {
            for (int col = 0; col < consolidado.GetLength(1); col++)
            {
                if(col == 0){
                    Console.Write("Semana " + (fila+1) + ":\t");
                }

                Console.Write(consolidado[fila, col].Nombre+ "-" + consolidado[fila, col].Ventas + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
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

        Console.WriteLine("Ventas anuales de cada vendedor: " + " A:"+a+ " B:"+b + " C:"+c+ " D:" + d + "\n");

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
                Console.WriteLine("1. El mejor vendedor anual es A con " + a + " Ventas");
                break;

            case 1:
                Console.WriteLine("1. El mejor vendedor anual es B con " + b + " Ventas");
                break;

            case 2:
                Console.WriteLine("1. El mejor vendedor anual es C con " + c + " Ventas");
                break;

            case 3:
                Console.WriteLine("1. El mejor vendedor anual es D con " + d + " Ventas");
                break;
        }
        Console.WriteLine();
    }

    public void GetMesMejorVenta(){
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
                Console.WriteLine("2. Enero fue el mes de la mejor venta del año.");
                break;

            case 1:
                Console.WriteLine("2. Febrero fue el mes de la mejor venta del año.");
                break;

            case 2:
                Console.WriteLine("2. Marzo fue el mes de la mejor venta del año.");
                break;

            case 3:
                Console.WriteLine("2. Abril fue el mes de la mejor venta del año.");
                break;

            case 4:
                Console.WriteLine("2. Mayo fue el mes de la mejor venta del año.");
                break;

            case 5:
                Console.WriteLine("2. Junio fue el mes de la mejor venta del año.");
                break;

            case 6:
                Console.WriteLine("2. Julio fue el mes de la mejor venta del año.");
                break;

            case 7:
                Console.WriteLine("2. Agosto fue el mes de la mejor venta del año.");
                break;

            case 8:
                Console.WriteLine("2. Septiembre fue el mes de la mejor venta del año.");
                break;

            case 9:
                Console.WriteLine("2. Octubre fue el mes de la mejor venta del año.");
                break;

            case 10:
                Console.WriteLine("2. Noviembre fue el mes de la mejor venta del año.");
                break;

            case 11:
                Console.WriteLine("2. Diciembre fue el mes de la mejor venta del año.");
                break;
        }
        Console.WriteLine();
    }

    public void getVendedoresCuartaSemanaMensual(){
        Console.WriteLine("3. Vendedores de la cuarta semana de cada mes: ");
        Console.WriteLine("ENE\tFEB\tMAR\tABR\tMAY\tJUN\tJUL\tAGO\tSEP\tOCT\tNOV\tDIC");
        for (int col = 0; col < consolidado.GetLength(1); col++)
        {
            Console.Write(consolidado[3, col].Nombre + "\t");
        }
        Console.WriteLine("\n");
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
        Console.Write("4. Mejor vendedor de diciembre es " + vendedor + " con " + venta + " ventas");
        Console.WriteLine("\n");
    }
}