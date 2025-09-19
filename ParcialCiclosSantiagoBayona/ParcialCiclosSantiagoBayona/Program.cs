namespace ParcialCiclosSantiagoBayona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Don Alcides, un tendero, realiza la venta de 10 productos y necesita calcular el valor total de la venta aplicando el IVA correspondiente a cada uno de ellos según las siguientes condiciones:
             -Si el valor del producto es mayor a 10.000, se aplica un 15% de IVA.
             -Si el valor del producto es menor o igual a 5.000, se aplica un 19% de IVA.
             El programa debe realizar lo siguiente:
             1.Solicitar por teclado el valor de cada uno de los 10 productos.
             2.Calcular el subtotal de cada producto, teniendo en cuenta el valor ingresado más el IVA correspondiente.
             3.Sumar los subtotales de los 10 productos.
             4.Mostrar en pantalla el valor total de la venta.*/

            double producto;
            int total = 3;
            double subtotal;
            double venta = 0;

            for (int i = 1; i <= total; i++)
            {
                Console.WriteLine($"Cuál es el valor del producto {i}");
                producto = double.Parse(Console.ReadLine());

                if (producto > 0 && producto <= 5000)
                {
                    subtotal = producto + (producto * 0.19);
                    venta += subtotal;
                }
                else if (producto > 10000)
                {
                    subtotal = producto + (producto * 0.15);
                    venta += subtotal ;
                }
                else
                {
                    subtotal = producto;
                    venta += subtotal;
                }
            }
            Console.WriteLine($"El total de su compra es {venta:F2}");
        }
    }
}
