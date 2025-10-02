using System.ComponentModel.Design;

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

            /*3. Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre 
             0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el 
            número se debe mostrar en pantalla: la posición que se encuentra el número, y el vector 
            resaltando el número en un color diferente. Si no se encuentra el número, se debe devolver y 
            mostrar -1.*/

            /*int[] vector = new int[20];
            Random random = new Random();

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next(0, 51);
            }

            while (true)
            {
                Console.WriteLine("\nIngrese un número para buscar en el vector (o escriba -1 para salir):");
                int numeroBuscado = int.Parse(Console.ReadLine()); // SIN VALIDACIONES

                if (numeroBuscado == -1)
                {
                    Console.WriteLine("Fin del programa. ¡Hasta luego!");
                    break;
                }

                int posicion = -1;
                for (int i = 0; i < vector.Length; i++)
                {
                    if (vector[i] == numeroBuscado)
                    {
                        posicion = i;
                        break;
                    }
                }

                if (posicion != -1)
                {
                    Console.WriteLine($"\nEl número {numeroBuscado} se encontró en la posición: {posicion}");
                    Console.WriteLine("Vector con el número resaltado:");

                    for (int i = 0; i < vector.Length; i++)
                    {
                        if (i == posicion)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write($"[{vector[i]}] ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write($"{vector[i]} ");
                        }
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("-1 (El número no se encontró en el vector)");
                }
            }*/
            /*Escribir un algoritmo que permita:
                 Crear un vector con rango impar, exceptuando el 1,
                 Pedirle al usuario un número entero y almacenarlo en la mitad del vector.
                 Llenar la primera mitad del vector, con los números menores al número almacenado
                en la posición de la mitad.
                 Llenar la parte inicial del vector, con los números menores al número almacenado en
                la posición de la mitad.
                 Llenar la parte final del vector, con los números mayores al número almacenado en la
                posición de la mitad.
                 Mostrar el vector en pantalla.*/

            /*int rango;
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Coloque un número impar, excepto el 1");
                rango = int.Parse(Console.ReadLine());
                if (rango % 2 == 0 || rango == 1 || rango < 0)
                {
                    Console.WriteLine("no es válido, paila");
                    break;
                }
                else
                {
                    Console.WriteLine("Perfecto, este va a ser el rango del vector");
                }

                int[] vector = new int[rango];

                Console.WriteLine("Ingrese un número entero para almacenar en la mitad del vector");
                int numeroCentral = int.Parse(Console.ReadLine());

                int mitad = rango / 2;
                vector[mitad] = numeroCentral;

                for (int j = 0; j < mitad; j++)
                {
                    vector[j] = numeroCentral - (mitad - j);
                }

                for (int j = mitad +1; j < rango; j++)
                {
                    vector[j] = numeroCentral + (j - mitad);
                }

                Console.WriteLine("\nVector generado:");
                for(int j = 0;j < rango; j++)
                {
                    Console.Write(vector[j] + " ");
                }
            }*/

            /*Escribir un algoritmo que permita:
             Crear dos vectores, el rango para cada uno de los vectores los debe ingresar el usuario.
             LLenar el primer vector con números aleatorios entre 0 y su rango+1
             LLenar el segundo vector con números aleatorios entre rango y rango*2
             Combinar los dos vectores en uno solo.
             Mostrar en pantalla los tres vectores*/

            int rango1;
            int rango2;
            Random random = new Random();

            Console.WriteLine("Ingresa el rango del primer vector");
            rango1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el rango del segundo vector");
            rango2 = int.Parse(Console.ReadLine());

            int[] vector1 = new int[rango1];
            int[] vector2 = new int[rango2];
            int[] vector3 = new int[vector1.Length + vector2.Length];

            for (int i = 0; i < vector1.Length; i++)
            {
                vector1[i] = random.Next(0, rango1+1);
            }
            for(int i = 0;i < vector2.Length; i++)
            {
                vector2[i] = random.Next(rango2, rango2 * 2);
            }

            for (int i = 0; i < vector1.Length; i++)
            {
                vector3[i] = vector1[i];
            }

            for (int i = 0; i < vector2.Length; i++)
            {
                vector3[vector1.Length + i] = vector2[i];
            }

            Console.WriteLine("PRIMER VECTOR:");
            for (int i = 0; i < vector1.Length; i++)
            {
                Console.Write(vector1[i] + " ");
            }
            Console.WriteLine("\nSEGUNDO VECTOR:");
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.Write(vector2[i] + " ");
            }
            Console.WriteLine("\nVECTOR COMBINADO:");
            for (int i = 0; i < vector3.Length; i++)
            {
                Console.Write(vector3[i] + " ");
            }
        }

    }
}
