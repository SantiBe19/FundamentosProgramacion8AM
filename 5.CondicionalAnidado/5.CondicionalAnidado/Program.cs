namespace _5.CondicionalAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;

            Console.WriteLine("Ingrese el número 1:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2:");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3:");
            num3 = float.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El número {num1} es el mayor");
                }
                else
                {
                    Console.WriteLine($"El número {num3} es el mayor");
                }
                {

                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El número {num2} es el mayor");
                }
                else
                {
                    Console.WriteLine($"El número {num3} es el mayor");
                }

            }
            float promedio = (num1 + num2 + num3) / 3f;

            if (promedio >= 9.5f)
            {
                Console.WriteLine($"Promedio {promedio}, Excelente bro");
            }
            else if (promedio >= 8.5f && promedio <= 9.4f)
            {
                Console.WriteLine($"Promedio {promedio}, Muy bien rey");
            }
            else if (promedio >= 7.5f && promedio <= 8.4f)
            {
                Console.WriteLine($"Promedio {promedio}, Bien bien");
            }
            else
            {
                Console.WriteLine("Error. El valor no está en el rango de valores esperado");
            }
        }
    }
}
