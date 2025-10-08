namespace ParcialArreglos_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Ventas = new int[5, 7];
            string[] dias = { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };

            for (int i = 0; i < Ventas.GetLength(0); i++)
            {
                for (int j = 0; j < Ventas.GetLength(1); j++)
                {
                    Console.WriteLine($"Por favor ingresa las ventas del almácen {i + 1} el día {dias[j]}");
                    while (!int.TryParse(Console.ReadLine(), out Ventas[i, j]) || Ventas[i, j] < 1)
                    {
                        Console.WriteLine("Por favor, ingrese un valor entero positivo. ¡Muchas gracias!");
                    }
                }
            }
            Console.Clear();

            for (int i = 0; i < Ventas.GetLength(0); i++)
            {
                Console.Write($"Almacén{i + 1}:");
                for (int j = 0; j < Ventas.GetLength(1); j++)
                {
                    Console.Write($"| {Ventas[i, j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n---Promedio semanal de ventas por almacén---");
            for (int i = 0; i < Ventas.GetLength(0); i++)
            {
                int sumatoriaFila = 0;
                for (int j = 0; j < Ventas.GetLength(1); j++)
                {
                    sumatoriaFila += Ventas[i, j];
                }
                double promedio = (double)sumatoriaFila / Ventas.GetLength(1);
                Console.WriteLine(($"Almacén {i + 1}: {promedio:F2}"));
            }
            Console.WriteLine("\n---Promedio de ventas por día (del día lunes y Viernes)---");
            int sumaLunes = 0;
            for(int i = 0;i < Ventas.GetLength(0);i++)
            {
                sumaLunes += Ventas[i, 0];
            }
            Console.WriteLine($"Promedio de ventas el lunes: {(double)sumaLunes/Ventas.GetLength(0):F2}");
            int sumaViernes = 0;
            for (int i = 0; i<Ventas.GetLength(0) ; i++)
            {
                sumaViernes += Ventas[i, 4];
            }
            Console.WriteLine($"Promedio de ventas el viernes: {(double)sumaViernes/Ventas.GetLength(0):F2}");

            Console.WriteLine("\n---Valor mínimo y máximo de ventas:---");

            int min = Ventas[0, 0];
            int max = Ventas[0, 0];
            int minAlmacen = 0;
            int minDia = 0;
            int maxDia = 0;
            int maxAlmacen = 0;

            for (int i = 0; i<Ventas.GetLength(0) ; i++)
            {
                for (int j = 0; j < Ventas.GetLength(1) ; j++)
                {
                    if (Ventas[i,j] < min)
                    {
                        min = Ventas[i,j];
                        minAlmacen = i;
                        minDia = j;
                    }
                    if (Ventas[i, j] > max)
                    {
                        max = Ventas[i,j];
                        maxAlmacen = i;
                        maxDia = j;
                    }
                }
            }

            Console.WriteLine($"Valor mínimo: {min}. En el almacén {minAlmacen+1}, en el día {dias[minDia]}");
            Console.WriteLine($"Valor máximo: {max}. En el almacén {maxAlmacen + 1}, en el día {dias[maxDia]}");

            Console.WriteLine("\n---Almacen con mayor promedio semanal de ventas:---");

            double mayorPromedio = 0;
            int almacenMayorPromedio = 0;

            for (int i = 0;i<Ventas.GetLength(0) ; i++)
            {
                int suma = 0;
                for (int j = 0; j < Ventas.GetLength(1); j++)
                {
                    suma += Ventas[i, j];
                }
                double promedio = (double)suma/Ventas.GetLength(1);
                if (promedio > mayorPromedio)
                {
                    mayorPromedio = promedio;
                    almacenMayorPromedio = i;
                }
            }

            Console.WriteLine($"El almacen con mayor promedio semanal de ventas es el Almacén {almacenMayorPromedio + 1} con un promedio de {mayorPromedio:F2}");

            Console.WriteLine("\n---Día de la semana con mayores ventas totales---");

            int mayorSumaDia = 0;
            int DiaMayorVentas = 0;

            for (int j = 0; j < Ventas.GetLength(1); j++)
            {
                int sumaDia = 0;
                for (int i = 0;  i < Ventas.GetLength(0); i++)
                {
                    sumaDia += Ventas[i, j];
                }

                if(sumaDia > mayorSumaDia)
                {
                    mayorSumaDia = sumaDia;
                    DiaMayorVentas = j;
                }
            }

            Console.WriteLine($"El día con mayores ventas totales fue el {dias[DiaMayorVentas]} con un total de {mayorSumaDia} ventas.");
        }
    }
}
