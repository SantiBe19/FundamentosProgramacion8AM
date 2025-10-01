namespace TallerPreparacionMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2. Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa 
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la 
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la 
            matriz con el intercambio de filas.*/
            /*int columnas;
            int filas;

            Console.WriteLine("¿Cuántas columnas quieres que tenga la matriz?");
            columnas = int.Parse(Console.ReadLine());
            Console.WriteLine("Y cuántas filas?");
            filas = int.Parse(Console.ReadLine());

            char[,] matriz = new char[filas, columnas];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el caracter para la posición {i},{j}");
                    matriz[i,j] = char.Parse(Console.ReadLine());
                }
            }
            Console.Clear();

            Console.WriteLine("----MATRIZ ORIGINAL----");

            for (int i = 0;i < matriz.GetLength(0);i++)
            {
                for(int j = 0;j < matriz.GetLength(1);j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < columnas; j++)
            {
                char temp = matriz[0, j];
                matriz[0, j] = matriz[filas - 1, j];
                matriz[filas - 1, j] = temp;
            }

            Console.WriteLine("----MATRIZ CON PRIMER Y UTLIMA FILA INTERCAMBIADAS----");
            for(int i = 0; i < filas; i++)
            {
                for(int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }*/

            /*Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de 
            5x5 llena de números aleatorios. 
            El algoritmo debe permitir:
                 Usa la función Random para generar los números aleatorios. 
                 Crea un arreglo adicional para almacenar la frecuencia de cada número. 
                 Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número */

            int[,] numeros = new int[5, 5];
            Random rand = new Random();
            int[] frecuencia = new int[10];

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    numeros[i, j] = rand.Next(1, 11);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int num = numeros[i, j];
                    frecuencia[num - 1]++;
                }
            }

            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write($"{numeros[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Frecuencia de cada número del 1 al 10:");
            for (int i = 0; i < frecuencia.Length; i++)
            {
                Console.WriteLine($"Número {i + 1}: {frecuencia[i]} veces");
            }
        }
    }
}
