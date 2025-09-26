namespace _27.Matrices2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] suma = new int[2, 3];

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el número para la posición con índices {i}, {j} de la primera matriz");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el número para la posición con índices {i}, {j} de la segunda matriz");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i = 0;i < suma.GetLength(0);i++)
            {
                for(int j = 0;j < suma.GetLength(1);j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            Console.WriteLine("La suma de las matrices es:");

            for(int i = 0; i <suma.GetLength(0);i++)
            {
                for(int j = 0; j<suma.GetLength(1);j++)
                {
                    Console.Write(suma[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
