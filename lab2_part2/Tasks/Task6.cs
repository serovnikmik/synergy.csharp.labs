using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task6
    {
        public static void Run()
        {
            Console.Title = "Задача 6: Расстояние между точками";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 6: Расстояние в n-мерном пространстве");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int dimensions = 3;
            double[] point1 = lab2Serov.ExtendedGenerator.GenerateNDimensionalPoint(dimensions, -10, 10);
            double[] point2 = lab2Serov.ExtendedGenerator.GenerateNDimensionalPoint(dimensions, -10, 10);

            Console.WriteLine("Точка 1: (" + string.Join(", ", point1) + ")");
            Console.WriteLine("Точка 2: (" + string.Join(", ", point2) + ")");

            double sumSquares = 0;
            for (int i = 0; i < dimensions; i++)
            {
                double diff = point2[i] - point1[i];
                sumSquares += diff * diff;
            }

            double distance = Math.Sqrt(sumSquares);

            Console.WriteLine();
            Console.WriteLine("Расстояние между точками: " + distance.ToString("F2"));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}