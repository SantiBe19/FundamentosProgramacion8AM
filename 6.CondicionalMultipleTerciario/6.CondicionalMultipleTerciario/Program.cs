namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* float valorCompra = 0;
             float descuento = 0;
             char dia = ' ';

             Console.WriteLine("Ingrese el valor de compra");
             valorCompra = Single.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese el día de la semana:l:Lunes, m:Martes, x:Miércoles, j: Jueves, v: Viernes, s: Sábado, d: Domingo");
             dia=Convert.ToChar(Console.ReadLine());

             switch(dia)
             {
                 case 'l':
                     descuento = valorCompra * 0.1f;
                     Console.WriteLine($"Hoy es lunes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                     break;
                 case 'm':
                     descuento = valorCompra * 0.15f;
                     Console.WriteLine($"Hoy es martes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                     break;
                 case 'x':
                     descuento = valorCompra * 0.1f;
                     Console.WriteLine($"Hoy es miercoles, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                     break;
                 case 'j':
                     descuento = valorCompra * 0.15f;
                     Console.WriteLine($"Hoy es jueves, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                     break;
                 case 'v':
                     descuento = valorCompra * 0.2f;
                     Console.WriteLine($"Hoy es viernes, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                     break;
                 case 's':
                     descuento = valorCompra * 0.2f;
                     Console.WriteLine($"Hoy es sábado, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                     break;
                 case 'd':
                     descuento = valorCompra * 0f;
                     Console.WriteLine($"Hoy es domingo, descuento de {descuento}, valor total de la compra {valorCompra - descuento}");
                     break;
                 default:
                     Console.WriteLine("Debe ingresar un dia de la samana válido")
                     break;*/
            /*
            float num1 = 0f;
            float num2 = 0f;
            char operación = ' ';
                float resultado = 0f;

                Console.WriteLine($"Bienvenido a esta útil calculadora, ingrese el primer número");
                num1=Single.Parse(Console.ReadLine() );
                Console.WriteLine("Listo rey ahora, ¿Qué operación quieres realizar?: s:Suma, r:Resta, m:Multiplicación, d:División");
                operación=Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Ahora un segundo número porfas");
                num2 = Single.Parse(Console.ReadLine());

                switch(operación)
                {
                    case 's':
                        resultado = (num1+num2);
                        Console.WriteLine($"El resultado de la operación fue {resultado}");
                        break;
                    case 'r':
                        resultado = (num1 - num2);
                        Console.WriteLine($"El resultado de la operación fue {resultado}");
                        break;
                    case 'm':
                        resultado = (num1 * num2);
                        Console.WriteLine($"El resultado de la operación fue {resultado}");
                        break;
                    case 'd':
                        resultado = (num1 / num2);
                        Console.WriteLine($"El resultado de la operación fue {resultado}");
                        break;
                    default:
                        Console.WriteLine("Error, escoge una de las operaciones indicadas");
                        break;
                }
            }*/
            int mes = 0;

            Console.WriteLine("Regálame un numero del 1 al 12: 1:Enero, 2:Febrero, 3:Marzo, 4:Abril, 5:Mayo, 6:Junio, 7:Julio, 8:Agosto, 9:Septiembre. 10:Octubre, 11:Noviembre, 12: Diciembre");
            mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Enero tiene 31 días");
                    break;
                case 2:
                    Console.WriteLine("Febrero tiene 28 días y cuando es bisiesto tiene 29");
                    break;
                case 3:
                    Console.WriteLine("Marzo tiene 31 días");
                    break;
                case 4:
                    Console.WriteLine("Abril tiene 30 días");
                    break;
                case 5:
                    Console.WriteLine("Mayo tiene 31 días");
                    break;
                case 6:
                    Console.WriteLine("Junio tiene 30 días");
                    break;
                case 7:
                    Console.WriteLine("Julio tiene 31 días");
                    break;
                case 8:
                    Console.WriteLine("Agosto tiene 31 días");
                    break;
                case 9:
                    Console.WriteLine("Septiembre tiene 30 días");
                    break;
                case 10:
                    Console.WriteLine("Octubre tiene 31 días");
                    break;
                case 11:
                    Console.WriteLine("Noviembre tiene 30 días");
                    break;
                case 12:
                    Console.WriteLine("Diciembre tiene 31 días");
                    break;
            }

        }
    }
}

        
