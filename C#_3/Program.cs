namespace C__3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            // Задание 1. Заполнить массив размером M на N:
            int number = 0;
            Console.WriteLine("Введите ширину массива: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] intArray1 = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(++number);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */

            // Задание 2. Заполнить массив размером M на N "змейкой":
            int number = 0;
            Console.WriteLine("Введите ширину массива: ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту массива: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[,] intArray1 = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < N; j++)
                    {
                        intArray1[i,j] = ++number;
                    }
                }
                else
                {
                    for (int j = N-1; j >= 0; j--)
                    {
                        intArray1[i,j] = ++number;
                    }
                }
            }
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                    {
                    Console.Write(intArray1[i, j]);
                    }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
