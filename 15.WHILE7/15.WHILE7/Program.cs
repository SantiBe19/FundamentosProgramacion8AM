namespace _15.WHILE7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo para determinar cuanto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes.
            int mes = 0;
            int dineroMes;
            int ahorrado = 0;

            while (mes < 12)
            {
                mes++;
                Console.WriteLine("¿Cuánto vas a meter este mes?");
                dineroMes = int.Parse(Console.ReadLine());
                ahorrado += dineroMes;
            }
            Console.WriteLine($"Lo que ahorraste tras estos doce meses fue: {ahorrado}");
        }
    }
}
