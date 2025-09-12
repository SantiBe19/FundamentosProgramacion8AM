using System.Security.Cryptography;

namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Algoritmo que permita calcular el promedio de calificaciones, el algoritmo 
                le permitirá al usuario, introducir tantas calificaciones como así desee, 
                en el momento en que seleccione que no desea continuar capturando
                calificaciones, el algoritmo debe presentar el promedio de las
                calificaciones capturadas previamente.*/

            /*float notas;
            float NumeroNotas = 0;
            bool continuar;
            float Sumatoria = 0;

            do
            {
                Console.WriteLine("Ingresa la calificación correspondiente");
                notas = float.Parse(Console.ReadLine());

                Console.WriteLine("¿Deseas continuar? si:true no:false ");
                continuar = bool.Parse(Console.ReadLine());

                NumeroNotas++;

                Sumatoria += notas;

            } while (continuar == true);

            Console.WriteLine($"El promedio total de las notas es {Sumatoria / NumeroNotas}");*/

            /*Se requiere un algoritmo para mostrar por pantalla los divisores de un 
            número ingresado por teclado. 
            Tener en cuenta que dados dos números enteros a y b, se dice que b es 
            divisor de a si se cumple que al efectuar una división entera a/b el 
            residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            una división de dos números. */

            /*int num;

            Console.WriteLine("Ingrese un número entero");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Los divisores de {num} son:");

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine($"{i}");
                }

            }*/

            /*Dados dos números enteros ingresados por teclado: b que es la base y 
              e que es el exponente, se requiere calcular el resultado de la 
              potenciación. 
              Ejemplo: b=2, e=5  25=2*2*2*2*2= 32 
              Mostrar por pantalla el resultado de la potenciación. 
              Seguir pidiendo por teclado la base y el exponente y realizar la 
              potenciación correspondiente, hasta que el usuario ingrese por teclado 
              el carácter de escape ‘n’*/

            /*int b;
            int e;
            double resultado;
            string respuesta;

                Console.WriteLine("Bienvenido a la calculadora de potencias rey");
            do
            {
                Console.WriteLine("Ingresa un número entero que será la base");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Ahora ingresa un número entero que hará de exponente");
                e = int.Parse(Console.ReadLine());

                resultado = Math.Pow(b, e);
                Console.WriteLine($"El resultado de la potencia de {b}^{e} es {resultado}");

                Console.WriteLine("¿Quieres calcular otra potencia? si:y no:n");
                respuesta = Console.ReadLine().ToLower();
            } while (respuesta != "n");

            Console.WriteLine("Hasta luego");*/

            /*Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco 
            kilómetros durante 10 días, para determinar si es apto para la prueba de 
            5 kilómetros. Para considerarlo apto debe cumplir las siguientes 
            condiciones: 
             Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos. 
             Que al menos en una de las pruebas realice un tiempo menor de 15 
              minutos. 
             Que su promedio sea menor o igual a 18 minutos. 
            Diseñar un algoritmo para registrar los datos y decidir si es apto para la 
            competencia.*/

            float tiempo;
            float SumaTiempo = 0;
            float promedio;
            float numeroCarreras=10;
            bool ningunMayorA20 = true;
            bool alMenosUnoMenorA15 = false;


            for(int i = 1; i <= numeroCarreras; i++)
            {
                Console.WriteLine($"¿Cuál fue su tiempo del día {i} (en minutos)");
                tiempo = float.Parse(Console.ReadLine());

                SumaTiempo += tiempo;
                numeroCarreras++;

                if(tiempo > 20)
                {
                    ningunMayorA20 = false;
                }

                if (tiempo < 15)
                {
                    alMenosUnoMenorA15 = true;
                }
            }
            promedio = (SumaTiempo / numeroCarreras);

            if (ningunMayorA20 && alMenosUnoMenorA15 && promedio < 18)
            {
                Console.WriteLine("El atleta es apto para la competencia");
            }
            else
            {
                Console.WriteLine("El atleta NO es apto para la competencia");
            }
            Console.WriteLine($"El promedio total fue de {promedio} minutos");
                 




        }
    }
}
