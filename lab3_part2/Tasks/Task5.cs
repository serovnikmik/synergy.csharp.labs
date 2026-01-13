using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task5
    {
        public static void Run()
        {
            Console.Title = "Задача 5: Масштабирование фигуры";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 5: Масштабирование фигуры");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            double[,] rectangle = {
                {1, 1},
                {4, 1},
                {4, 3},
                {1, 3}
            };

            Console.Write("Введите коэффициент масштабирования: ");
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double scale) || scale <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: нужно ввести положительное число!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Исходный прямоугольник:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Вершина {i + 1}: ({rectangle[i, 0]}, {rectangle[i, 1]})");
            }

            Console.WriteLine();
            Console.WriteLine($"Масштабированный (x{scale}):");
            for (int i = 0; i < 4; i++)
            {
                double scaledX = rectangle[i, 0] * scale;
                double scaledY = rectangle[i, 1] * scale;
                Console.WriteLine($"Вершина {i + 1}: ({scaledX:F2}, {scaledY:F2})");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}