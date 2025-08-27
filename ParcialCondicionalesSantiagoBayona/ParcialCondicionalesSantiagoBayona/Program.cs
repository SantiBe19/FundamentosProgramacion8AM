namespace ParcialCondicionalesSantiagoBayona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char género = ' ';
            int edad;
            int documento;
            bool ingles;

            Console.WriteLine("Bienvenido al programa");
            Console.WriteLine("¿Con qué género se identifica?: F para femenino, M para masculino");
            género = Char.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántos años tiene?");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("¿En que número termina su documento de identidad?");
            documento= int.Parse(Console.ReadLine());

            switch (género)
            {
                case 'F':
                    if (edad >= 16 && edad <= 20 && (documento == 0 || documento == 4 || documento == 8))
                    {
                        Console.WriteLine("Pertenece al grupo A");
                    }
                    else if (edad >= 21 && edad <= 25 && (documento == 3 || documento == 7))
                    {
                        Console.WriteLine("Pertenece al grupo B");
                    }
                    else if (edad == 15)
                    {
                        Console.WriteLine("¿Domina el idioma ingles?: true para sí, false para no");
                        ingles = bool.Parse(Console.ReadLine());
                        if (ingles == true)
                        Console.WriteLine("Pertenece al grupo C");
                        else
                        Console.WriteLine("Pertenece al grupo D");
                    }
                    else
                    {
                        Console.WriteLine("Pertenece al grupo D");
                    }
                    break;
                case 'M':
                    if (edad >= 18 && edad <= 22 && (documento == 1 || documento == 5 || documento == 9))
                    {
                        Console.WriteLine("Pertenece al grupo A");
                    }
                    else if (edad >= 23 && edad <= 26 && (documento == 2 || documento == 6))
                    {
                        Console.WriteLine("Pertenece al grupo B");
                    }
                    else if (edad == 15)
                    {
                        Console.WriteLine("¿Domina el idioma ingles?: true para sí, false para no");
                        ingles = bool.Parse(Console.ReadLine());
                        if (ingles == true)
                            Console.WriteLine("Pertenece al grupo C");
                        else
                            Console.WriteLine("Pertenece al grupo D");
                    }
                    else
                    {
                        Console.WriteLine("Pertenece al grupo D");
                    }
                    break;
            }
        }
    }
}

