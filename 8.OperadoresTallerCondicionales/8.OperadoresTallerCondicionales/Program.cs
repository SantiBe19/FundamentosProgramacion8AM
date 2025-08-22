namespace _8.OperadoresTallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1, numero 2, numero3 respectivamente. El algoritmo debe comprobar si los números son diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en pantalla los números de menor a mayor*/

            /*float num1;
            float num2;
            float num3;
            float mayor;
            float menor;
            float medio;

            Console.WriteLine("Ingresa tres números diferentes porfa");
            Console.WriteLine("A ver, ingrese un número");
            num1= float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, otro número");
            num2= float.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, otro más");
            num3= float.Parse(Console.ReadLine());

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine($"Todos los números son iguales");
            }
            else if (num1 == num2 || num2 == num3 || num1 == num3)
            {
                Console.WriteLine("Todos los números deben ser diferentes, intenta otra vez");
            }
            else
            {            
                mayor = num1 > num2

                    ? (num1 > num3 ? num1 : num3)
                    : (num2 > num3 ? num2 : num3);
                Console.WriteLine($"El número mayor es: {mayor}");
                menor = num1 < num2 ? (num1 < num3 ? num1 : num3) : (num2 < num3 ? num2: num3); 
                medio = num1 > num2 ? (num1 < num3 ? num1 :num3 ) : (num2 < num3 ? num2:num3);
                Console.WriteLine($"Los números de menor a mayor es {menor}, {medio} y {mayor}");
        }*/

            /*El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si cuenta con munición y si se encuentra en estado invencible, crear un programa que:
            a. Permita ingresar por teclado si el personaje está en estado invencible (True).
            b. La cantidad de munición que tiene el personaje en el momento será calculada por el sistema por medio de un número aleatorio, para ello utlizar la clase Random de C#
            c.Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y 10, mostrar un mensaje en la consola "El personaje está disparando", en caso contrario no hacer nada*/

            bool invencible;
            int munición;
            Random rnd = new Random();
            munición = rnd.Next(0,11);//Devuelve un número entre 0 y 10
            Console.WriteLine(munición);

            Console.WriteLine("¿El personaje es invencible? V:si F:no");
            


            
        }
    }
}
