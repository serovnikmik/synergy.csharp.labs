using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task10
    {
        public static void Run()
        {
            Console.Title = "Задача 10: Уравнение прямой";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 10: Уравнение прямой через две точки");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            var point1 = lab2Serov.ExtendedGenerator.GeneratePoint2D(-10, 10);
            var point2 = lab2Serov.ExtendedGenerator.GeneratePoint2D(-10, 10);

            Console.WriteLine("Точка 1: (" + point1.x.ToString("F1") + ", " + point1.y.ToString("F1") + ")");
            Console.WriteLine("Точка 2: (" + point2.x.ToString("F1") + ", " + point2.y.ToString("F1") + ")");

            double deltaX = point2.x - point1.x;
            double deltaY = point2.y - point1.y;

            Console.WriteLine();

            if (Math.Abs(deltaX) < 0.0001)
            {
                Console.WriteLine("Уравнение прямой: x = " + point1.x.ToString("F1"));
            }
            else
            {
                double k = deltaY / deltaX;
                double b = point1.y - k * point1.x;

                Console.WriteLine("Уравнение прямой: y = " + k.ToString("F2") + "x");

                if (b >= 0)
                {
                    Console.WriteLine("                + " + b.ToString("F2"));
                }
                else
                {
                    Console.WriteLine("                - " + Math.Abs(b).ToString("F2"));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}