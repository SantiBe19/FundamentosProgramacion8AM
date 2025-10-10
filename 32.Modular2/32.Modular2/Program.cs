namespace _32.Modular2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que muestra un menú con operaciones (+,-,*,/) y permita realizar la operación que el usuario ingrese por teclado. Si es suma
            o multiplicación, permitirle al usuario realizar estas operaciones con la cantidad de números que él desee ingresar. Si es divisón
            o resta solo dejar realizar la operación con dos números*/
            MostrarMenú();
        }

        static void MostrarMenú()
        {
            Console.WriteLine("Las operaciones disponibles para realizar son \n-Suma \n-Resta \n-Multiplicación \n-División");
        }

        static void CapturarOpción()
        {

        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }
    }
}
