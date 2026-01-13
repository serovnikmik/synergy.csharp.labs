using System;

namespace lab3Serov.Tasks
{
    public static class Task18
    {
        private struct Point
        {
            public double X;
            public double Y;
        }

        public static void Run()
        {
            Console.Title = "Задача 18: Масштабирование фигуры";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 18: Масштабирование фигуры");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Point[] triangle = new Point[3];
            triangle[0] = new Point { X = 1, Y = 1 };
            triangle[1] = new Point { X = 4, Y = 1 };
            triangle[2] = new Point { X = 2.5, Y = 3 };

            double scale = 2.0;

            Console.WriteLine("Исходный треугольник:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Вершина {i + 1}: ({triangle[i].X}, {triangle[i].Y})");
            }

            Console.WriteLine();
            Console.WriteLine($"Масштабирование в {scale} раз:");
            Console.WriteLine("Масштабированный треугольник:");

            for (int i = 0; i < 3; i++)
            {
                double scaledX = triangle[i].X * scale;
                double scaledY = triangle[i].Y * scale;
                Console.WriteLine($"Вершина {i + 1}: ({scaledX}, {scaledY})");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}