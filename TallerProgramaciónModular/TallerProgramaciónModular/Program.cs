namespace TallerProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. Desarrolla un programa que permita: 
                 Ingresar una palabra 
                 LLevar la palabra ingresada a un vector de caracteres 
                 Contar la cantidad de vocales y consonantes en la palabra proporcionada por el 
                usuario.*/
            /*string palabra = ObtenerPalabra();
            char[] letras = ConvertirAPalabraChar(palabra);
            int vocales = ContarVocales(letras);
            int consonates = ContarConsonantes(letras);

            Console.WriteLine($"\nLa palabra ingresada tiene:");
            Console.WriteLine($"Vocales:{vocales}");
            Console.WriteLine($"Consonantes: {consonates}");*/

            /*2. Crear un programa que permita gestionar una lista de tareas: 
                 Agregar tareas. 
                 Eliminar tareas 
                 Mostrar la lista de tareas. */

            List<string> tareas = new List<string>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nMenú - Gestor de Tareas");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Eliminar Tarea");
                Console.WriteLine("3. Mostrar Tareas");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción (1-4): ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Program.AgregarTarea(tareas);
                        break;

                    case "2":
                        Program.EliminarTarea(tareas);
                        break;

                    case "3":
                        Program.MostrarTareas(tareas);
                        break;

                    case "4":
                        continuar = false;
                        Console.WriteLine("Programa finalizado");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo");
                        break;
                }
            }
        }

        //1
        /*static string ObtenerPalabra()
        {
            Console.Write("Ingresa una palabra:");
            return Console.ReadLine().ToLower();
        }

        static char[] ConvertirAPalabraChar(string palabra)
        {
            return palabra.ToCharArray();
        }

        static int ContarVocales(char[] caracteres)
        {
            int contador = 0;
            foreach (char c in caracteres)
            {
                if ("aeiou".Contains(c))
                {
                    contador++;
                }
            }
            return contador;
        }

        static int ContarConsonantes(char[] caracteres)
        {
            int contador = 0;
            foreach (char c in caracteres)
            {
                if(Char.IsLetter(c) && !"aeiou".Contains(c))
                {
                    contador++;
                }
            }
            return contador;
        }*/

        //2
        public static void AgregarTarea(List<string> tareas)
        {
            Console.Write("Escribe la nueva tarea:");
            string tarea = Console.ReadLine();
            if (!string.IsNullOrEmpty(tarea))
            {
                tareas.Add(tarea);
                Console.WriteLine("Tarea agregada con éxito");
            }
            else
            {
                Console.WriteLine("La trea no puede estar vacía");
            }
        }

        public static void EliminarTarea(List<string> tareas)
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas para eliminar");
                return;
            }

            MostrarTareas(tareas);

            Console.Write("Escribe el número de la tarea que deseas eliminar: ");
            if (int.TryParse(Console.ReadLine(), out int indice))
            {
                if (indice >= 1 && indice <= tareas.Count)
                {
                    string tareaEliminada = tareas[indice-1];
                    tareas.RemoveAt(indice - 1);
                    Console.WriteLine($"Tarea eliminada: \"{tareaEliminada}\"");
                }
                else
                {
                    Console.WriteLine("Número fuera de rango");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número.");
            }
        }

        public static void MostrarTareas(List<string> tareas)
        {
            if (tareas.Count == 0)
            {
                Console.WriteLine("no hay tareas en la lista");
            }
            else
            {
                Console.WriteLine("\nLista de tareas");
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {tareas[i]}");
                }
            }
        }
    }
}
