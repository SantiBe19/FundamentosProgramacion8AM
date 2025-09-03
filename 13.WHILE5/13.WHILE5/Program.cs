namespace _13.WHILE5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13.Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.
             El algoritmo debe escribir en pantalla:
                La cantidad de números introducidos que son mayores que 0
                La cantidad de números introducidos menores que 0
                La cantidad de números iguales a 0.*/
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorCero = 0;
            int CantidadNumeros;
            int numero;
            int i= 0;

            Console.WriteLine($"¿Cuántos números vas a introducir?");
            CantidadNumeros = int.Parse( Console.ReadLine() );

            while (i < CantidadNumeros)
            {
                Console.WriteLine($"Ingresa un dato:");
                numero = int.Parse( Console.ReadLine() );
                if (numero == 0)
                {
                    contadorCero++;
                }
                if (numero > 0)
                {
                    contadorPositivos++;
                }
                if (numero < 0)
                { 
                    contadorNegativos++;
                }
                i++;
            }
            Console.WriteLine($"La cantidad de números mayores a 0 son {contadorPositivos}, de números menores a 0 son {contadorNegativos} y de ceros ingresados son {contadorCero}");
        }
    }
}
