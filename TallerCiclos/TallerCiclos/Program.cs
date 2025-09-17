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

            /*float tiempo;
            float SumaTiempo = 0;
            float promedio;
            float numeroCarreras=10;
            bool ningunMayorA20 = true;
            bool alMenosUnoMenorA15 = false;


            for(int i = 1; i <= numeroCarreras; i++)
            {
                Console.WriteLine($"¿Cuál fue su tiempo del día {i} (en minutos)?");
                tiempo = float.Parse(Console.ReadLine());

                SumaTiempo += tiempo;

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

            if (ningunMayorA20 && alMenosUnoMenorA15 && promedio <= 18)
            {
                Console.WriteLine("El atleta es apto para la competencia");
            }
            else
            {
                Console.WriteLine("El atleta NO es apto para la competencia");
            }
            Console.WriteLine($"El promedio total fue de {promedio} minutos");*/

            /*Se aplicó una encuesta a n personas solicitando su opinión sobre el
            tema del servicio militar obligatorio para las mujeres. Las opciones de
            respuesta fueron: a favor, en contra y no responde. Se solicita un
            algoritmo que calcule qué porcentaje de los encuestados marcó cada
            una de las respuestas.*/

            /*int personas;
            int contadorAFavor = 0;
            int contadorEnContra = 0;
            int contadorNoResponde = 0;
            string respuesta;

            Console.WriteLine("¿Cuántas personas van a ser encuestadas el día de hoy?");
            personas = int.Parse(Console.ReadLine());

            for (int i = 0; i < personas; i++)
            {
                bool Valido = false;

                while (!Valido)
                {
                    Console.WriteLine("¿Cree que el servicio militar debería ser obligatorio para las mujeres?");
                    Console.WriteLine("Respuestas: a favor, en contra, no responde");
                    respuesta = Console.ReadLine().ToLower();

                    if (respuesta == "a favor")
                    {
                        contadorAFavor++;
                        Valido = true;
                    }
                    else if (respuesta == "en contra")
                    {
                        contadorEnContra++;
                        Valido = true;
                    }
                    else if (respuesta == "no responde")
                    {
                        contadorNoResponde++;
                        Valido = true;
                    }
                    else
                        Console.WriteLine("Dé una respuesta válida");
                }
            }
            float porcentajeAFavor = ((float)contadorAFavor/personas) * 100;
            float porcentajeEnContra = ((float)contadorEnContra / personas) * 100;
            float porcentajeNoResponde = ((float)contadorNoResponde / personas) * 100;

            Console.WriteLine($"El porcentaje de personas que votaron a favor es del: {porcentajeAFavor}%, el porcentaje que votaron en contra es del: {porcentajeEnContra}% y el porcentaje de personas que no respondieron es del: {porcentajeNoResponde}%");*/

            /*Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos
            de esos números son positivos, cuántos negativos, cuántos son neutros
            (0); además que imprima por pantalla la sumatoria de los números
            positivos y la de los negativos.*/

            /*int numeros = 10;
            float numero;
            int contadorPositivos = 0;
            int contadorNegativos = 0;
            int contadorNeutros = 0;
            float SumatoriaNumPositivos = 0;
            float SumatoriaNumNegativos = 0;

            for (int i = 1; i <= numeros; i++)
            {
                Console.WriteLine($"Regalame {numeros} número, ya sea positivo o neagtivo, incluso cero. (Van {i})");
                numero = float.Parse(Console.ReadLine());
                if (numero == 0)
                {
                    contadorNeutros++;
                }
                else if (numero > 0)
                {
                    contadorPositivos++;
                    SumatoriaNumPositivos += numero;
                }
                else if (numero < 0)
                {
                    contadorNegativos++;
                    SumatoriaNumNegativos += numero;
                }
            }
            Console.WriteLine($"La cantidad de números positivos es: {contadorPositivos}");
            Console.WriteLine($"La cantidad de números negativos es: {contadorNegativos}");
            Console.WriteLine($"La cantidad de números neutros es: {contadorNeutros}");
            Console.WriteLine($"La sumatoria de los positivos ingresados es: {SumatoriaNumPositivos}");
            Console.WriteLine($"La sumatoria de los negativos ingresados es: {SumatoriaNumNegativos}");*/

            /*Una persona desea realizar un muestreo con 70 personas para
            determinar el promedio de peso de los niños, jóvenes, adultos y viejos
            que existen en su zona y cuántos son de cada una de las categorías.
            Las categorías están dadas por la siguiente tabla: Niños (0-13), jóvenes (14-30),
            adultos (31-60) y viejos (mayor a 61).*/

            /*int personas = 70;
            int edad;
            float peso;
            int jovenes = 0;
            int niños = 0;
            int adultos = 0;
            int viejos = 0;
            float SumatoriaNiños = 0;
            float SumatoriaJovenes = 0;
            float SumatoriaAdultos = 0;
            float SumatoriaViejos = 0;

            for(int i = 0; i < personas;i++)
            {
                Console.WriteLine("¿Cuántos años tiene?");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Cuánto pesa?");
                peso = float.Parse(Console.ReadLine());

                if (edad >= 0 && edad <= 13)
                {
                    niños++;
                    SumatoriaNiños += peso;
                }
                else if (edad >= 14 && edad <= 30)
                {
                    jovenes++;
                    SumatoriaJovenes += peso;
                }
                else if (edad >= 31 && edad <=60)
                {
                    adultos++;
                    SumatoriaAdultos += peso;
                }
                else if (edad >= 61)
                {
                    viejos++;
                    SumatoriaViejos+=peso;
                }
            }
            float promedioPN = (SumatoriaNiños/niños);
            float promedioPJ = (SumatoriaJovenes/jovenes);
            float promedioPA = (SumatoriaAdultos/adultos);
            float promedioPV = (SumatoriaViejos/viejos);

            Console.WriteLine("---RESULTADOS---");

            if (niños > 0)
                Console.WriteLine($"El promedio del peso de los {niños} niños de la zona es {promedioPN}");
            else
                Console.WriteLine("No se ingresaron datos de niños");

            if (jovenes > 0)
                Console.WriteLine($"El promedio del peso de los {jovenes} jovenes de la zona es {promedioPJ}");
            else
                Console.WriteLine("No se ingresaron datos de jovenes");

            if (adultos > 0)
                Console.WriteLine($"El promedio del peso de los {adultos} adultos de la zona es {promedioPA}");
            else
                Console.WriteLine("No se ingresaron datos de adultos");

            if (viejos > 0)
                Console.WriteLine($"El promedio del peso de los {viejos} viejos de la zona es {promedioPV}");
            else
                Console.WriteLine("No se ingresaron datos de viejos");*/

            /*El Departamento de Transito de Antioquia. desea saber de los n autos
            que entran a la ciudad de Medellín, cuántos autos entran con
            calcomanía de un determinado color. Conociendo el último dígito de la
            placa de cada automóvil se puede determinar el color de la calcomanía,
            para determinar lo anterior utilice la siguiente tabla: Amarillo (1 o 2), Rosa (3 o 4),
            Roja (5 o 6), Verde (7 o 8) y Azul (9 o 0)*/

            int digito;
            int coches;
            int contadorAmarillos = 0;
            int contadorRosa = 0;
            int contadorRojos = 0;
            int contadorVerdes = 0;
            int contadorAzules = 0;

            Console.WriteLine("¿Cuántos coches fueron registrados en su entrada a Medellín?");
            while (!int.TryParse(Console.ReadLine(), out coches) || coches <= 0)
            {
                Console.WriteLine("Por favor, introduzca un número entero positivo.");
            }

            for (int i = 1; i <= coches; i++)
            {
                Console.WriteLine($"Cuál es el último número de la placa del carro número {i}");
                string entrada = Console.ReadLine();

                if(!int.TryParse(entrada, out digito) || digito < 0 || digito > 9)
                {
                    Console.WriteLine("Entrada no válida. Debe ser un número entre 0 y 9.");
                    i--;
                    continue;
                }

                switch (digito)
                {
                    case (0):
                    case (9):
                        contadorAzules++;
                        break;
                    case (1):
                    case (2):
                        contadorAmarillos++;
                        break;                       
                    case (3):
                    case (4):
                        contadorRosa++;
                        break;

                    case (5):
                    case (6):
                        contadorRojos++;
                        break;
                    case (7):
                    case (8):
                        contadorVerdes++;
                        break;
                    default:
                        Console.WriteLine("Respuesta no válida");
                        break;

                }
            }
            Console.WriteLine("---Resumen de calcomanías---");
            Console.WriteLine($"La cantidad de carros con una calcomanía amarilla es {contadorAmarillos}");
            Console.WriteLine($"La cantidad de carros con una calcomanía rosa es {contadorRosa}");
            Console.WriteLine($"La cantidad de carros con una calcomanía roja es {contadorRojos}");
            Console.WriteLine($"La cantidad de carros con una calcomanía verde es {contadorVerdes}");
            Console.WriteLine($"La cantidad de carros con una calcomanía azul es {contadorAzules}");
        }
    }
}
