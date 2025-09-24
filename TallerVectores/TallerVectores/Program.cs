namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] vector;//Declarando

            vector = new int[15];//Inicializando
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Ingrese el número entero para la posición {i + 1}, con índice {i}");
                vector[i] = int.Parse(Console.ReadLine());

                if (i==0)
                {
                    mayor = vector[i];
                    menor = vector[i];
                }
                else
                {
                    if (vector[i] > mayor)
                    {
                        mayor = vector[i];
                    }

                    if (vector[i] < menor)
                    {
                        menor = vector[i];
                    }
                }
            }
            Console.Clear();

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "|");
            }
            Console.WriteLine($"\nEl número mayor es: {mayor}, el número menor es: {menor}");*/

            //2.Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el orden de los elementos del vector. Se deben mostrar los dos vectores.

            /*int cosito;
            Console.WriteLine("¿De cuántos caracteres va a ser el vector?");
            cosito = int.Parse(Console.ReadLine());

            string[] vector = new string[cosito];
            string[] vectorInverso = new string[cosito];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"Escribe el caracter para la posición {i + 1}, con índice {i}");
                vector[i] = Console.ReadLine();

            }

            for (int i = 0; i < vectorInverso.Length; i++)
            {
                vectorInverso[i] = vector[vector.Length - 1 - i];
            }
            Console.Clear();

            Console.WriteLine("Vector original:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "|");
            }
            Console.WriteLine("\nVector invertido:");
            for (int i = 0; i < vectorInverso.Length; i++)
            {
                Console.Write(vectorInverso[i] + "|");
            }*/

            //3. Crea un algoritmo que llene un vector[20] cn números enteros positivos aleatorios entre 0 y 50. Luego le debe pedir al usuaro un número para buscar en el vector. Si encuentra el número se debe mostrar en pantalla: la posici+on que se encuentra el número, y el vector resaltando el número en un color diferente. Si no se encuentra el número, se debe devolver y mostrar -1.

            int[] vector = new int[20];

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = new Random().Next(0,51);
            }

        }
    }
}
