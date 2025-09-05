namespace _18.DoWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
                -Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
                -Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
              El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
              Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos. */
            string nombre;
            int NumCuenta;
            int Saldo;
            string bandera = "y";
            int NumUsuarios = 0;
            int SumaSaldos = 0;

            do
            {
                NumUsuarios++;
                Console.WriteLine("Ingresa tu nombre");
                nombre = (Console.ReadLine());
                Console.WriteLine("Ingresa tu número de cuenta");
                NumCuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa tu saldo");
                Saldo = int.Parse(Console.ReadLine());

                switch (Saldo)
                {
                    case > 3000000:
                        Console.WriteLine($"Nombre del usuario:{nombre}, Número de cuenta {NumCuenta}, Saldo: {Saldo}");
                        Console.WriteLine("Es apto para el crédito");
                        SumaSaldos += Saldo;
                        break;
                    case < 3000000:
                        Console.WriteLine($"Nombre del usuario:{nombre}, Número de cuenta {NumCuenta}, Saldo: {Saldo}");
                        Console.WriteLine("No es apto para el crédito");
                        SumaSaldos += Saldo;
                        break;
                }
                Console.WriteLine("¿Desea ingresar un nuevo usuario? y/n");
                bandera = Console.ReadLine().ToLower();
            } while (bandera == "y");

            Console.WriteLine($"La cantidad de usuarios que ingresaron sus datos fueron {NumUsuarios}");
            Console.WriteLine($"El promedio de los saldos ingresados fue {SumaSaldos / NumUsuarios}");
        }
    }
}
