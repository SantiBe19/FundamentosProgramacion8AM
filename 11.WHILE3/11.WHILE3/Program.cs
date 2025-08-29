namespace _11.WHILE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que pida números enteros positivos y los sume hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados. */

            int numero;
            int suma = 0;

            Console.WriteLine("Esta es la dinámica: Vas a ingresar números positivos y yo los sumo, ingresa un número negativo si quieres parar");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                suma += numero;
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"La suma total de números ingresados es {suma}");
        }
    }
}
