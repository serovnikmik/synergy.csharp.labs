using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task14
    {
        public static void Run()
        {
            Console.Title = "Задача 14: Точка в круге";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 14: Принадлежность точки кругу");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Random random = new Random();
            double centerX = random.Next(-5, 6);
            double centerY = random.Next(-5, 6);
            double radius = random.Next(1, 6);

            var point = lab2Serov.ExtendedGenerator.GeneratePoint2D(-10, 10);
            double pointX = point.x;
            double pointY = point.y;

            double distanceSquared = Math.Pow(pointX - centerX, 2) + Math.Pow(pointY - centerY, 2);
            double radiusSquared = radius * radius;

            bool isInside = distanceSquared <= radiusSquared;

            Console.WriteLine("Круг:");
            Console.WriteLine("Центр: (" + centerX.ToString("F1") + ", " + centerY.ToString("F1") + ")");
            Console.WriteLine("Радиус: " + radius.ToString("F1"));
            Console.WriteLine();
            Console.WriteLine("Точка:");
            Console.WriteLine("Координаты: (" + pointX.ToString("F1") + ", " + pointY.ToString("F1") + ")");
            Console.WriteLine();
            Console.WriteLine("Расстояние до центра: " + Math.Sqrt(distanceSquared).ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine("Точка " + (isInside ? "принадлежит" : "не принадлежит") + " кругу");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}