namespace _14.WHILE6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.
            int contadorPares = 0;
            int finalRango = 0;
            int contador = 1;

            Console.WriteLine($"¿Hasta qué número va a llegar el conteo?");
            finalRango = int.Parse( Console.ReadLine() );

            while (contador <= finalRango)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                }

                contador++;
            }
            Console.WriteLine($"La cantidad de números pares desde 1 hasta {finalRango} es {contadorPares}");
        }
    }
}
