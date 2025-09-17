namespace _23.Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Arreglos Unidimensionales
            //Vectores

            int[] numeros = new int[5]; //El vector numeros tiene 5 posiciones
            string[] nombres = new string[4];

            //Asignar valores a las posiciones
            numeros[0] = 20;
            numeros[1] = 15;
            numeros[2] = 5;
            numeros[3] = 30;
            numeros[4] = 45;
            //numeros[5] = 85; Error porque el índice 5 no existe
            int[] numeros1 = new int[] { 5, 12, 4, 7, 9, 21 };
            int[] numeros2 = { 5, 12, 4, 7, 9 };
            //Yo puedo reccorer el vector para llenarlo de datos o para recuperar los datos
            char[] caracter = new char[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese con el caracter para la posición {i + 1}, con índice {i}:");
                caracter[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine($"El vector caracter, en la posición 3, tiene almacenado el dato: {caracter[2]}");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"El vector caracter en la posición {i + 1}, tiene almacenado el dato: {caracter[i]}");
            }

            for (int i = 0;i < caracter.Length; i++)//.Length devuelve el rango del vector
            {
                Console.Write(caracter[i] + " | ");
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingrese un nombre para la posición {i + 1}, con índice {i}:");
                nombres[i] = Console.ReadLine();
            }
            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"El vector nombre en la posición {i+1}, tiene almacenado el nombre: {nombres[i]}");
            }*/

            int[] numeros = new int[100];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
                Console.WriteLine($"El número en la posición {i + 1} es {numeros[i]}");
            }
        }

    }
}
