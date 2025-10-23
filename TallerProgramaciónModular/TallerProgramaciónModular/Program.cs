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
            /*int maxTareas = 100;
            string[] tareas = new string[maxTareas];
            int cantidadTareas = 0;
            int opcion;

            do
            {
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();

                if (opcion ==1)
                {
                    cantidadTareas = AgregarTarea(tareas, cantidadTareas, maxTareas);
                }
                else if (opcion ==2)
                {
                    cantidadTareas = EliminarTarea(tareas, cantidadTareas);
                }
                else if (opcion == 3)
                {
                    MostrarTareas(tareas, cantidadTareas);
                }
                else if (opcion ==4)
                {
                    Console.WriteLine("Saliendo del programa...");
                }
                else
                {
                    Console.WriteLine("Opción no válida");
                }
                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);*/

            /*3. Desarrolla un programa que permita:
                 Elegir un tipo de unidad de medida
                    o Masa
                    o Capacidad
                    o Longitud
                    o Tiempo
                 Elegir una unidad de medida para convertir.
                    o Masa
                         De kilogramos a gramos
                         De gramos a Kilogramos
                    o Capacidad
                         De litro a mililitro
                         De mililitro a litro
                    o Longitud
                         De kilometro a metro
                         De metro a kilometro
                    o Tiempo
                         De hora a segundos
                         De segundos a hora
                 Ingresar un valor para convertir.
                 Al final mostrar el valor y la unidad a convertir, y el valor y la unidad a la que se
                convirtió. Ej: “1 kilometro son 1000 metros”*/
            /*int opcionPrincipal;
            do
            {
                Console.Clear();
                MostrarMenuPrincipal();
                opcionPrincipal = CapturarOpcion();

                if (opcionPrincipal == 1)
                    MenuMasa();
                else if (opcionPrincipal == 2)
                    MenuCapacidad();
                else if (opcionPrincipal == 3)
                    MenuLongitud();
                else if (opcionPrincipal == 4)
                    MenuTiempo();
                else if (opcionPrincipal == 5)
                    Console.WriteLine("Saliendo del programa...");
                else
                    Console.WriteLine("Opción no válida.");

                if (opcionPrincipal != 5)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcionPrincipal != 5);*/

            /*4. Utiliza programación modular para crear un programa que permita:
                 Recorrer una matriz y llenarla con nombres de contactos.
                 Ingresar un nombre y buscarlo en la matriz
                 Si se encuentra el nombre, cambiarlo en la matriz por un nuevo nombre que ingresa
                el usuario
                 Mostrar por pantalla el nombre encontrado, su posición en la matriz (f,c), y el nuevo
                nombre ingresado.*/
            /*int filas = 5, columnas = 5;
            string[,] contactos = new string[filas, columnas];

            int opcion;
            do
            {
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpcion();

                if (opcion == 1)
                    LlenarMatriz(contactos, filas, columnas);
                else if (opcion == 2)
                    BuscarYCambiarNombre(contactos, filas, columnas);
                else if (opcion == 3)
                    MostrarMatriz(contactos, filas, columnas);
                else if (opcion == 4)
                    Console.WriteLine("Saliendo del programa...");
                else
                    Console.WriteLine("Opción no válida.");

                if (opcion != 4)
                {
                    Console.WriteLine("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 4);*/

            /*5. Crear un programa que implemente el juego de tres en raya (triqui o gato), para dos
            jugadores. El programa debe:
                 Dibujar el tablero
                 Permitir realizar movimientos.
                 Verificar ganadores */
            /*char[,] tablero = new char[3, 3];
            InicializarTablero(tablero);

            char jugadorActual = 'X';
            bool hayGanador = false;
            int movimientos = 0;
            int fila, columna;

            while (!hayGanador && movimientos < 9)
            {
                Console.Clear();
                DibujarTablero(tablero);

                Console.WriteLine($"\nTurno del jugador {jugadorActual}");
                fila = CapturarPosicion("Fila (0, 1 o 2): ");
                columna = CapturarPosicion("Columna (0, 1 o 2): ");

                if (tablero[fila, columna] == ' ')
                {
                    tablero[fila, columna] = jugadorActual;
                    movimientos++;

                    if (VerificarGanador(tablero, jugadorActual))
                    {
                        Console.Clear();
                        DibujarTablero(tablero);
                        Console.WriteLine($"\n¡El jugador {jugadorActual} ha ganado!");
                        hayGanador = true;
                    }
                    else
                    {
                        jugadorActual = (jugadorActual == 'X') ? 'O' : 'X'; // Cambia de jugador
                    }
                }
                else
                {
                    Console.WriteLine("\nEsa casilla ya está ocupada. Intenta de nuevo.");
                    Console.ReadKey();
                }
            }

            if (!hayGanador)
            {
                Console.Clear();
                DibujarTablero(tablero);
                Console.WriteLine("\nEmpate.");
            }*/
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
        /*static void MostrarMenu()
    {
        Console.WriteLine("-----GESTOR DE TAREAS-----");
        Console.WriteLine("1.Agregar tarea");
        Console.WriteLine("2.Eliminar tarea");
        Console.WriteLine("3.Mostrar tareas");
        Console.WriteLine("4.Salir");
        Console.WriteLine("--------------------------");
    }

    static int CapturarOpcion()
    {
        Console.Write("ingrese una opción: ");
        int opcion;
        int.TryParse(Console.ReadLine(), out opcion);
        return opcion;
    }

    static int AgregarTarea(string[] tareas, int cantidad, int max)
    {
        if (cantidad >= max)
        {
            Console.WriteLine("No se pueden agregar más tareas (límite alcanzado)");
            return cantidad;
        }

        Console.Write("Ingrese la descripción de la nueva tarea: ");
        string nuevaTarea = Console.ReadLine();

        if (!string.IsNullOrEmpty(nuevaTarea))
        {
            tareas[cantidad] = nuevaTarea;
            cantidad++;
            Console.WriteLine("Tarea agregada correctamente.");
        }
        else
        {
            Console.WriteLine("No se agregó ninguna tarea (entrada vacía).");
        }
        return cantidad;
    }

    static int EliminarTarea(string[] tareas, int cantidad)
    {
        if(cantidad==0)
        {
            Console.WriteLine("No hay tareas para eliminar.");
            return cantidad;
        }

        MostrarTareas(tareas, cantidad);

        Console.Write("Ingrese el número de la tarea a eliminar: ");
        int indice;
        int.TryParse(Console.ReadLine(), out indice);
        indice--;

        if (indice >= 0 && indice < cantidad)
        {
            for(int i = indice; i < cantidad; i++)
            {
                tareas[i] = tareas[i + 1];
            }

            cantidad--;
            Console.WriteLine("Tarea eliminada correctamente.");
        }
        else
        {
            Console.WriteLine("Número de tarea inválido.");
        }
        return cantidad;
    }

    static void MostrarTareas(string[] tareas, int cantidad)
    {
        Console.WriteLine("\n-----LISTA DE TAREAS-----");
        if(cantidad == 0)
        {
            Console.WriteLine("no hay tareas registradas.");
        }
        else
        {
            for(int i = 0; i< cantidad; i++)
            {
                Console.WriteLine($"{i + 1}. {tareas[i]}");
            }
        }
    }*/
        //3
        /*static void MostrarMenuPrincipal()
    {
        Console.WriteLine("===== CONVERSOR DE UNIDADES =====");
        Console.WriteLine("1. Masa");
        Console.WriteLine("2. Capacidad");
        Console.WriteLine("3. Longitud");
        Console.WriteLine("4. Tiempo");
        Console.WriteLine("5. Salir");
        Console.WriteLine("=================================");
    }

    static int CapturarOpcion()
    {
        Console.Write("Ingrese una opción: ");
        int opcion;
        int.TryParse(Console.ReadLine(), out opcion);
        return opcion;
    }

    static void MenuMasa()
    {
        Console.Clear();
        Console.WriteLine("== Conversión de Masa ==");
        Console.WriteLine("1. De kilogramos a gramos");
        Console.WriteLine("2. De gramos a kilogramos");

        int opcion = CapturarOpcion();
        double valor, resultado;

        if (opcion == 1)
        {
            valor = CapturarValor("Ingrese los kilogramos: ");
            resultado = valor * 1000;
            Console.WriteLine($"{valor} kilogramos son {resultado} gramos");
        }
        else if (opcion == 2)
        {
            valor = CapturarValor("Ingrese los gramos: ");
            resultado = valor / 1000;
            Console.WriteLine($"{valor} gramos son {resultado} kilogramos");
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }

    static void MenuCapacidad()
    {
        Console.Clear();
        Console.WriteLine("== Conversión de Capacidad ==");
        Console.WriteLine("1. De litros a mililitros");
        Console.WriteLine("2. De mililitros a litros");

        int opcion = CapturarOpcion();
        double valor, resultado;

        if (opcion == 1)
        {
            valor = CapturarValor("Ingrese los litros: ");
            resultado = valor * 1000;
            Console.WriteLine($"{valor} litros son {resultado} mililitros");
        }
        else if (opcion == 2)
        {
            valor = CapturarValor("Ingrese los mililitros: ");
            resultado = valor / 1000;
            Console.WriteLine($"{valor} mililitros son {resultado} litros");
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }
    static void MenuLongitud()
    {
        Console.Clear();
        Console.WriteLine("== Conversión de Longitud ==");
        Console.WriteLine("1. De kilómetros a metros");
        Console.WriteLine("2. De metros a kilómetros");

        int opcion = CapturarOpcion();
        double valor, resultado;

        if (opcion == 1)
        {
            valor = CapturarValor("Ingrese los kilómetros: ");
            resultado = valor * 1000;
            Console.WriteLine($"{valor} kilómetros son {resultado} metros");
        }
        else if (opcion == 2)
        {
            valor = CapturarValor("Ingrese los metros: ");
            resultado = valor / 1000;
            Console.WriteLine($"{valor} metros son {resultado} kilómetros");
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }
    static void MenuTiempo()
    {
        Console.Clear();
        Console.WriteLine("== Conversión de Tiempo ==");
        Console.WriteLine("1. De horas a segundos");
        Console.WriteLine("2. De segundos a horas");

        int opcion = CapturarOpcion();
        double valor, resultado;

        if (opcion == 1)
        {
            valor = CapturarValor("Ingrese las horas: ");
            resultado = valor * 3600;
            Console.WriteLine($"{valor} horas son {resultado} segundos");
        }
        else if (opcion == 2)
        {
            valor = CapturarValor("Ingrese los segundos: ");
            resultado = valor / 3600;
            Console.WriteLine($"{valor} segundos son {resultado} horas");
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }

    static double CapturarValor(string mensaje)
    {
        Console.Write(mensaje);
        double valor;
        double.TryParse(Console.ReadLine(), out valor);
        return valor;
    }*/
        //4
        /*static void MostrarMenu()
        {
            Console.WriteLine("===== GESTOR DE CONTACTOS =====");
            Console.WriteLine("1. Llenar matriz con nombres");
            Console.WriteLine("2. Buscar y cambiar un nombre");
            Console.WriteLine("3. Mostrar matriz de contactos");
            Console.WriteLine("4. Salir");
            Console.WriteLine("================================");
        }

        static int CapturarOpcion()
        {
            Console.Write("Ingrese una opción: ");
            int opcion;
            int.TryParse(Console.ReadLine(), out opcion);
            return opcion;
        }

        static void LlenarMatriz(string[,] matriz, int filas, int columnas)
        {
            Console.WriteLine("\n--- Llenar la matriz con nombres ---");
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write($"Ingrese el nombre para la posición ({f},{c}): ");
                    matriz[f, c] = Console.ReadLine();
                }
            }
            Console.WriteLine("\nMatriz llenada correctamente.");
        }

        static void BuscarYCambiarNombre(string[,] matriz, int filas, int columnas)
        {
            Console.Write("Ingrese el nombre que desea buscar: ");
            string nombreBuscado = Console.ReadLine();
            bool encontrado = false;

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    if (matriz[f, c] != null && matriz[f, c].Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"\nNombre encontrado en la posición ({f},{c}).");
                        Console.Write("Ingrese el nuevo nombre para reemplazarlo: ");
                        string nuevoNombre = Console.ReadLine();

                        matriz[f, c] = nuevoNombre;
                        Console.WriteLine($"\nEl nombre '{nombreBuscado}' fue reemplazado por '{nuevoNombre}'.");
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"\nEl nombre '{nombreBuscado}' no se encontró en la matriz.");
            }
        }
        static void MostrarMatriz(string[,] matriz, int filas, int columnas)
        {
            Console.WriteLine("\n--- Lista de contactos ---");
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write($"{matriz[f, c],-15}");
                }
                Console.WriteLine();
            }
        }*/
        //5
        /*static void InicializarTablero(char[,] tablero)
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    tablero[f, c] = ' ';
                }
            }
        }
        static void DibujarTablero(char[,] tablero)
        {
            Console.WriteLine("=== TRES EN RAYA ===\n");
            for (int f = 0; f < 3; f++)
            {
                Console.Write(" ");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($" {tablero[f, c]} ");
                    if (c < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (f < 2) Console.WriteLine(" ---+---+---");
            }
        }
        static int CapturarPosicion(string mensaje)
        {
            int valor;
            do
            {
                Console.Write(mensaje);
                int.TryParse(Console.ReadLine(), out valor);
            } while (valor < 0 || valor > 2);
            return valor;
        }
        static bool VerificarGanador(char[,] t, char jugador)
        {
            for (int f = 0; f < 3; f++)
            {
                if (t[f, 0] == jugador && t[f, 1] == jugador && t[f, 2] == jugador)
                    return true;
            }

            for (int c = 0; c < 3; c++)
            {
                if (t[0, c] == jugador && t[1, c] == jugador && t[2, c] == jugador)
                    return true;
            }

            if (t[0, 0] == jugador && t[1, 1] == jugador && t[2, 2] == jugador)
                return true;

            if (t[0, 2] == jugador && t[1, 1] == jugador && t[2, 0] == jugador)
                return true;

            return false;
        }*/
    }
}
