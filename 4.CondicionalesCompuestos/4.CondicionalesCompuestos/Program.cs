namespace _4.CondicionalesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese el nombre");
            nombre=Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if(sueldo>=3000)
            {
                //Verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //Falsa
                Console.WriteLine($"La persona no abona impuestos");
            }

            int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad = Int32.Parse(Console.ReadLine());

            if (edad>=18)
            {
                Console.WriteLine($"Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine($"No es apto para el contenido de este sitio web");
            }

            int num1 = 0;
            int num2 = 0;

            Console.WriteLine($"Ingrese dos números cualquiera y vea la magia");
            Console.WriteLine($"Ingrese el primer número");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Ingrese el segundo número");
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"La suma de los datos es {num1 + num2} y su diferencia es {num1 - num2}");
            }
            if (num2 > num1)
            {
                Console.WriteLine($"El producto de los datos es {num1 * num2} y su división es {num1 / num2}");
            }

            int noches = 0, precio = 200;

            Console.WriteLine($"¿Cuántas noches se va a quedar en el hotel?");
            noches = Int32.Parse(Console.ReadLine());

            if (noches > 3)
            {
                Console.WriteLine($"El costo de su estadía será {precio*noches-(precio * noches)*0.17}");
            }
            else
            {
                Console.WriteLine($"El costo de su estadía será {precio*noches-(precio * noches) * 0.02}");
            }


        }
    }
}
