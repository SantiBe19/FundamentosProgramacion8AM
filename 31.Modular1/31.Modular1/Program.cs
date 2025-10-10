namespace _31.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplosDe5 = new int[CapturarFilas(), CapturarColumnas()];
            LlenarMatriz(multiplosDe5);
            MostrarMatriz(multiplosDe5);
        }

        //Módulo - Borra la pantalla de la consola
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Módulo - Rellenar la matriz
        static int[,] LlenarMatriz(int[,] matriz)
        {
            int numero = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    do
                    {
                        BorrarPantalla();
                        Console.WriteLine("Digite un número para ingresar en la matriz");
                        numero = int.Parse(Console.ReadLine());
                    } while (EsMultiplode5(numero) == false);

                    matriz[i, j] = numero;
                }
            }
            return matriz;
        }

        //Módulo - Verificar si el número ingresado es múltiplo de 5
        static bool EsMultiplode5(int numero)
        {
            if(numero % 5 ==0 && numero !=0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error, debe digitar un número múltiplo de 5");
                return false;
            }
        }

        //Módulo - Le pregunta al usuario el número de filas de la matriz
        static int CapturarFilas()
        {
            BorrarPantalla();
            Console.WriteLine("Ingrese el número de filas de la matriz:");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        //Módulo - Le pregunta al usuario el número de columnas de la matriz
        static int CapturarColumnas()
        {
            BorrarPantalla();
            Console.WriteLine("Ingrese el número de columnas para la matriz:");
            int columnas = int.Parse(Console.ReadLine());
            return columnas;
        }

        //Módulo - Mostrar la matriz
        static void MostrarMatriz(int[,] matriz)
        {
            BorrarPantalla();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]}|");
                }
                Console.WriteLine();
            }
        }
    }
}
