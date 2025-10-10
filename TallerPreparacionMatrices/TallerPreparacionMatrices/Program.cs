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

            /*int[,] numeros = new int[5, 5];
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
            }*/

            /*Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en
            posiciones aleatorias. Luego, el algoritmo le debe permitir al usuario intentar adivinar la
            posición de una "X".
            El algoritmo debe permitir:
                 Usar la función Random para colocar las "X" en la matriz.
                 Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado.
                 Al final sacar un mensaje de éxito o error. Si el mensaje es de éxito mostrar la
                posición de la X en la matriz. Si el mensaje es de error, mostrar la matriz. */

            /*char[,] tablero = new char[5, 5];
            Random rand = new Random();
            int colocadas = 0;
           
            for(int i = 0; i < tablero.GetLength(0); i++)
            {
                for(int j = 0; j < tablero.GetLength(1); j++)
                {
                    tablero[i, j] = 'o';
                }
            }

            while(colocadas < 3)
            {
                int fila = rand.Next(0, 5);
                int columna = rand.Next(0, 5);

                if (tablero[fila, columna] != 'x')
                {
                    tablero[fila, columna] = 'x';
                    colocadas++;
                }
            }

            bool acierto = false;

            for(int intento = 1; intento <= 3; intento++)
            {
                Console.WriteLine($"\nIntento {intento} de 3");

                int fila = -1;
                int columna = -1;

                while (true)
                {
                    Console.Write("Ingresa la fila (0-4):");
                    if (int.TryParse(Console.ReadLine(), out fila) && fila >= 0 && fila < 5)
                        break;
                    Console.WriteLine("Entrada inválida. Debe ser un número entre 0 y 4");
                }
                
                while (true)
                {
                    Console.Write("Ingresa la columna (0-4): ");
                    if (int.TryParse(Console.ReadLine(), out columna) && columna >= 0 && columna < 5)
                        break;
                    Console.WriteLine("Entrada inválida. Debe ser un número entre 0 y 4");
                }

                if (tablero[fila, columna] == 'x')
                {
                    Console.WriteLine("\n ¡Felicidades! Encontraste una x");
                    Console.WriteLine($"Efectivamente, estaba en la posición ({fila},{columna})");
                    acierto = true;
                    break;
                }
                else
                {
                    Console.WriteLine("No hay una x en esa posición :(");
                }

            }
            if (!acierto)
            {
                Console.WriteLine("No lograste encontrar ninguna x. Aquí está el tablero completo: \n");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(tablero[i, j]+ "|");
                    }
                    Console.WriteLine();
                }
            }*/

            /*Desarrollar un programa e C# que:
             Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz
            de enteros
             Cargue los datos de la matriz ingresándolos por teclado
             Muestre la matriz ingresada
             Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser
            ahora la columna 1.
             Mostrar la nueva matriz */

            /*int columnas;
            int filas;

            Console.WriteLine("¿Cuántas filas quieres que tenga el arreglo? (Solo números enteros)");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántas columnas quiere que tenga el arreglo? (Solo números enteros)");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el número en la posición ({i},{j}) plis");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("---ARREGLO NORMAL---");

            for(int i = 0;i < filas; i++)
            {
                for(int j = 0;j < columnas; j++)
                {
                    Console.Write($"{matriz[i,j]} |");
                }
                Console.WriteLine();
            }

            int filasOM = filas;
            int columnasOM = columnas;

            int[,] OtraMatriz = new int[columnasOM, filasOM];
            
            for(int i = 0;i<columnasOM; i++)
            {
                for(int j = 0;j<filasOM; j++)
                {
                    OtraMatriz[i, j] = matriz[j, i]; 
                }
            }

            Console.WriteLine("---ARREGLO VOLTIAO---");
            for (int i = 0; i < columnasOM; i++)
            {
                for (int j = 0; j < filasOM; j++)
                {
                    Console.Write($"{OtraMatriz[i, j]} |");
                }
                Console.WriteLine();
            }*/
            /*Crear una aplicación en C# que permita realizar las siguientes acciones:
             Crear una matriz de n filas por m columnas
             Llenar la matriz con números aleatorios del 1 al 3 (investigar la función random en C#)
             Mostrar la matriz generada
             Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el
            número 3, y cuál de los tres números fue repetido más veces.*/

            int columnas;
            int filas;
            Random random = new Random();
            int frecuencia1 = 0;
            int frecuencia2 = 0;
            int frecuencia3 = 0;

            Console.WriteLine("¿Cuántas filas quieres que tenga el arreglo? (Solo números enteros)");
            filas = int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántas columnas quiere que tenga el arreglo? (Solo números enteros)");
            columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 4);

                    if (matriz[i, j] == 1)
                    {
                        frecuencia1++;
                    }
                    else if (matriz[i, j] == 2)
                    {
                        frecuencia2++;
                    }
                    else frecuencia3++;

                    if(frecuencia1>frecuencia2)
                    {
                        if (frecuencia2 > frecuencia3)
                        { 
                        
                        }
                    }
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nEl número 1 fue ingresado: {frecuencia1} veces \nEl número 2 fue ingresado: {frecuencia2} veces \nEl número 3 fue ingresado: {frecuencia3} veces");
            
            if(frecuencia1 > frecuencia2 && frecuencia1 > frecuencia3)
            {
                Console.WriteLine("El número que más se repitió fue el 1");
            }
            else if(frecuencia2 > frecuencia1 && frecuencia2 > frecuencia3)
            {
                Console.WriteLine("El número que más se repitió fue el 2");
            }
            else if (frecuencia3 >frecuencia1 && frecuencia3 > frecuencia2)
            {
                Console.WriteLine("El número que más se repitió fue el 3");
            }
            else
            {
                Console.WriteLine("Hay un empate entre dos o más números");
            }
        }
    }
}
