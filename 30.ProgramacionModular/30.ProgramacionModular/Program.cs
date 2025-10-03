namespace _30.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Mi nombre es Ferney");
            //MostrarMensajes("Tengo 44 años");
            //Console.WriteLine($"Edad calculada: {CalcularEdad()}");
            MostrarMensajes($"Tengo {CalcularEdad(2025, 1981)} años");
        }

        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenidos a la clase de Programación modular");
            MostrarMensajes("Estoy desde Procedimiento sin parámetros");
        }

        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Módulo 3 - Funciones sin parámetros

        static int CalcularEdad()
        {
            int edad = 2025 - 1981;
            return edad;
        }

        //modulo 4 - Funciones con parámetros
        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }
    }
}
