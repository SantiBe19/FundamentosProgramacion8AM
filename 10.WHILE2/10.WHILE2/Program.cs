namespace _10.WHILE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)

            int num1;
            int factorial = 1;
            int i = 1;

            Console.WriteLine("Ingresa un número y te lo factoreo");
            num1 = int.Parse(Console.ReadLine());


            while (i <= num1)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"El factorial de este número {num1} es {factorial}");
        }
    }
}
