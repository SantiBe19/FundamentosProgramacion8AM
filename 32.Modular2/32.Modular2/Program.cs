namespace _32.Modular2
{
    internal class Program
    {
            /*Algoritmo que muestra un menú con operaciones (+,-,*,/) y permita realizar la operación que el usuario ingrese por teclado. Si es suma
            o multiplicación, permitirle al usuario realizar estas operaciones con la cantidad de números que él desee ingresar. Si es divisón
            o resta solo dejar realizar la operación con dos números*/
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                BorrarPantalla();
                MostrarMenú();
                opcion = CapturarOpción();
                RealizarOperaciones(opcion);
            }
            while (opcion != 5);

            Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
        }

        static void MostrarMenú()
        {
            Console.WriteLine("-----MENÚ DE OPERACIONES-----");
            Console.WriteLine("Las operaciones disponibles para realizar son \n1.Suma \n2.Resta \n3.Multiplicación \n4.División \n5.Salir");
        }

        static int CapturarOpción()
        {
            Console.WriteLine("Ingrese una opcion:");
            int opcion = int.Parse(Console.ReadLine() ?? "0");
            return opcion;
        }

        static void RealizarOperaciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicación();
                    break;
                case 4:
                    División();
                    break;
                case 5:

                    break;
                default:
                    Console.WriteLine("Ópción no válida. Intente de nuevo");
                    break;
            }

            if(opcion >= 1 && opcion <= 4)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void Suma()
        {
            Console.Write("¿Cuántos números desea sumar?");
            int n = int.Parse(Console.ReadLine() ?? "0");

            double[] numeros = new double[n];
            for(int i=0; i<n; i++)
            {
                Console.Write($"Ingrese el número {i + 1}:");
                numeros[i] = double.Parse(Console.ReadLine() ?? "0");
            }

            double total = 0;
            for(int i=0; i<n;i++)
            {
                total += numeros[i];
            }

            Console.WriteLine($"El resultado de la suma es: {total}");
        }

        static void Resta()
        {
            Console.WriteLine("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine() ?? "0");

            double total = num1 - num2;
            Console.WriteLine($"El resultado de la resta es: {total}");
        }

        static void Multiplicación()
        {
            Console.Write("¿Cuántos números desea multiplicar?");
            int n = int.Parse(Console.ReadLine() ?? "0");

            double[] numeros = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese el número {i + 1}:");
                numeros[i] = double.Parse(Console.ReadLine() ?? "0");
            }

            double total = 0;
            for (int i = 0; i < n; i++)
            {
                total *= numeros[i];
            }

            Console.WriteLine($"El resultado de la multiplicación es: {total}");
        }
        static void División()
        {
            Console.WriteLine("Ingrese el numerador: ");
            double num1 = double.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Ingrese el denominador: ");
            double num2 = double.Parse(Console.ReadLine() ?? "0");

            if (num2 != 0)
            {
                double resultado = num1 / num2;
                Console.WriteLine($"El resultado de la división es {resultado}");
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero.");
            }
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }


    }
}
