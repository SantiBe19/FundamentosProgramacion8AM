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
                float[] numeros = {num1, num2, num3};
                Array.Sort(numeros);
                Console.WriteLine($"El número mayor es: {numeros[2]}");
                Console.WriteLine($"Los números de menor a mayor son: {numeros[0]}, {numeros[1]} y {numeros[2]}");
            }*/

            /*El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si cuenta con munición y si se encuentra en estado invencible, crear un programa que:
            a. Permita ingresar por teclado si el personaje está en estado invencible (True).
            b. La cantidad de munición que tiene el personaje en el momento será calculada por el sistema por medio de un número aleatorio, para ello utlizar la clase Random de C#
            c.Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y 10, mostrar un mensaje en la consola "El personaje está disparando", en caso contrario no hacer nada*/

            /*bool invencible = false;
            int munición;
            Random rnd = new Random();
            munición = rnd.Next(0,11);//Devuelve un número entre 0 y 10
            Console.WriteLine(munición);

            Console.WriteLine("¿El personaje es invencible? true/false");
            invencible = bool.Parse(Console.ReadLine());

            if(invencible && munición >= 1)
            {
                Console.WriteLine("El personaje está disparando");
            }
            else
            {
                Console.WriteLine("El personaje NO está disparando");
            }*/

            /*Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1,y1), 
            P2(x2,y2), P3(x3,y3). Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1
            P3. La distancia entre dos puntos está dada por la siguiente formula: 
            d = √((x2 - x1)² + (y2 - y1)²) 
            Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con 
            dichas distancias se puede construir un triángulo, consultar las condiciones que se deben 
            cumplir para realizar dicha construcción. En caso contrario, decir cuál o cuáles de las 
            condiciones no se cumplen.*/

          /*double X1, Y1;
            double X2, Y2;
            double X3, Y3;
            double d12, d23, d13;

            Console.WriteLine("Regálame las coordenadas de tres puntos");
            Console.WriteLine("A ver la coordenada x del primer punto");
            X1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, la coordenada y del primer punto");
            Y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("La coordenada x del segundo punto");
            X2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ahora, la coordenada y");
            Y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Finalmente, la coordenada x del tercer punto");
            X3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Y, la coordenada y del tercer punto");
            Y3 = double.Parse(Console.ReadLine());

            d12 = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1,2));
            d23 = Math.Sqrt(Math.Pow(X3 - X2, 2) + Math.Pow(Y3 - Y2, 2));
            d13 = Math.Sqrt(Math.Pow(X3 - X1, 2) + Math.Pow(Y3 - Y1, 2));

            Console.WriteLine($"Distancia entre el punto 1 y el punto 2 es {d12}");
            Console.WriteLine($"Distancia entre el punto 2 y el punto 3 es {d23}");
            Console.WriteLine($"Distancia entre el punto 1 y el punto 3 es {d13}");

            bool cond1 = d12 + d23 > d13;
            bool cond2 = d12 + d13 > d23;
            bool cond3 = d13 + d23 > d12;

            if (cond1 && cond2 && cond3)
            {
                Console.WriteLine("Se puede construir un triángulo con estos puntos");
            }
            else
            {
                Console.WriteLine("No se puede construir un triángulo. ¿Porque?");

                if (!cond1) Console.WriteLine($"La suma de P1 a P2 + P2 a P3 no es mayor que P1 a P3({d12 + d23}<={d13})");
                if (!cond2) Console.WriteLine($"La suma de P1 a P2 + P1 a P3 no es mayor que P2 a P3({d12 + d13}<={d23}");
                if (!cond3) Console.WriteLine($"La suma de P1 a P3 + P2 a P3 no es mayor que P1 a P2({d13 + d23}<={d12}");
            }*/

            /*El personaje de un juego, solo se puede mover en forma horizontal (Izquierda o Derecha), 
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve 
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado. 
                 Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la 
                derecha 
                 Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha 
                 En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra 
                dirección”*/

            /*char movimiento = ' ';

              Console.WriteLine("¿Te quieres mover a la izquierda o a la derecha? i para izquierda, d para derecha");
              movimiento=Convert.ToChar(Console.ReadLine());

              switch(movimiento)
              {
                  case 'i':
                      Console.WriteLine("El personaje se mueve hacia la izquierda");
                      break;
                  case 'd':
                      Console.WriteLine("El personaje se mueve a la derecha");
                      break;
                  default:
                      Console.WriteLine("No me puedo mover en otra dirección");
                      break;
              }*/
            /*El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
            el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
             Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje.
            (Función Random)
             Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. En
            caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
            ninguna acción”.
             Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
            carácter que se ingrese:
            o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando”
            o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana”
            o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo”
            o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible”*/

          /*int vidas;
            Random rnd = new Random();
            vidas = rnd.Next(0, 6);
            Console.WriteLine(vidas);

            char acciones = ' ';

            if (vidas == 0)
            {
                Console.WriteLine("El personaje no posee vidas, y no puede realizar ningún acción.");
            }
            else
            {
                Console.WriteLine("El personaje puede realizar acciones: presiona c para disparar, x para hablar con la Rana, t para modo Turbo, i para ser invencible");
                acciones = Convert.ToChar(Console.ReadLine());

                switch (acciones)
                {
                    case 'c':
                        Console.WriteLine("El personaje está disparando");
                        break;
                    case 'x':
                        Console.WriteLine("El personaje está hablando con la Rana");
                        break;
                    case 't':
                        Console.WriteLine("El personaje está en modo Turbo");
                        break;
                    case 'i':
                        Console.WriteLine("El personaje es Invencible");
                        break;
                }
            }*/

}
}
}
