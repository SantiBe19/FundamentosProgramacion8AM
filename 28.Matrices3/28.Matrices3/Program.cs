namespace _28.Matrices3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*28. Clasificación de números en una matriz 
                  Desarrolla una aplicación que realice las siguientes tareas: 
                    -Solicita al usuario que ingrese las dimensiones de una matriz (número de filas y columnas). 
                    -Recorre la matriz y permite al usuario ingresar un número entero en cada posición. 
                    -Una vez cargada la matriz, el programa debe contar cuántos de los números ingresados son positivos, cuántos son negativos y cuántos son ceros. 
                    -Finalmente, muestra por pantalla los totales obtenidos para cada categoría (positivos, negativos y ceros). */

            int filas;
            int columnas;
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            Console.WriteLine("¿Cuántas filas quiere que tenga la matriz?");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántas columnas quiere que tenga la matriz?");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posición {i},{j}");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] < 0)
                    {
                        negativos++;
                    }
                    else if (matriz[i, j] == 0)
                    {
                        ceros++;
                    }
                    else
                    {
                        positivos++;
                    }
                }
            }

            Console.WriteLine("---TOTALES OBTENIDOS---");
            Console.WriteLine($"Los números positivos ingresados son: {positivos}");
            Console.WriteLine($"Los números negativos ingresados son: {negativos}");
            Console.WriteLine($"Los ceros ingresados son: {ceros}");
        }
    }
}
