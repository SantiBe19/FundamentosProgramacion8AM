namespace _1.InicioVisualStudio_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración e inicialización de variables
            string nombre = "Santiago";
            const string iva = "19%";
            string apellidos = "Bayona Acevedo";
            Console.Write(nombre + " bienvenido al curso de Fundamentos Programación\n");
            nombre = "Leonardo";
            //iva = 20%; No puedo cambiar el valor de 'iva' por ser una constante
            Console.Write("\t" + nombre + " " + apellidos + " " + iva);
            Console.ReadKey();
        }
    }
}
