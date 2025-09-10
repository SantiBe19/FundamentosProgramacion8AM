namespace _20.DoWhile4
{
    internal class Program
    {
        static void Main(string[] args)
        { //Un equipo de fútbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber: esos datos de ahí abajo
            int partidosJugados = 0;
            int partidosPerdidos = 0;
            int partidosEmpatados = 0;
            int partidosGanados = 0;
            int cantidad = 30;
            int pregunta;
            int pregunta2;
            float porcentajePP;
            float porcentajePE;
            float porcentajePG;

            do
            {
                partidosJugados++;

                Console.WriteLine("¿Ganaron el partido 1.Si 2.No");
                pregunta = int.Parse(Console.ReadLine());
                if (pregunta == 1)
                    partidosGanados++;
                else if (pregunta == 2)
                {
                    Console.WriteLine("¿Empataron? 1.Si 2.No");
                    pregunta2 = int.Parse(Console.ReadLine());
                    if (pregunta2 == 1)
                        partidosEmpatados++;
                    else
                        partidosPerdidos++;
                }
            } while (partidosJugados < cantidad);
            porcentajePP = (100 * partidosPerdidos) / cantidad;
            porcentajePG = (100 * partidosGanados) / cantidad;
            porcentajePE = (100 * partidosEmpatados) / cantidad;

            Console.WriteLine($"El porcentaje de partidos ganados es {porcentajePG/100}, el de partidos perdidos es {porcentajePP/100} y el de partidos empatados es {porcentajePE / 100}");

        }
    }
}
