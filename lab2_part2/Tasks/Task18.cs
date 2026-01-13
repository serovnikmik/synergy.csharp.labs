using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task18
    {
        public static void Run()
        {
            Console.Title = "Задача 18: Стороны треугольника";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 18: Стороны треугольника по стороне и углам");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            var triangle = lab2Serov.ExtendedGenerator.GenerateTriangle();
            double sideA = triangle.side;
            double angleB = triangle.angle1;
            double angleC = triangle.angle2;

            double angleA = 180 - angleB - angleC;

            if (angleA <= 0)
            {
                Console.WriteLine("Ошибка: сумма углов должна быть меньше 180 градусов");
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            double angleARad = angleA * Math.PI / 180;
            double angleBRad = angleB * Math.PI / 180;
            double angleCRad = angleC * Math.PI / 180;

            double sideB = sideA * Math.Sin(angleBRad) / Math.Sin(angleARad);
            double sideC = sideA * Math.Sin(angleCRad) / Math.Sin(angleARad);

            Console.WriteLine("Исходные данные:");
            Console.WriteLine("Известная сторона: " + sideA.ToString("F1"));
            Console.WriteLine("Угол B: " + angleB.ToString("F1") + "°");
            Console.WriteLine("Угол C: " + angleC.ToString("F1") + "°");
            Console.WriteLine();
            Console.WriteLine("Вычисленные данные:");
            Console.WriteLine("Угол A: " + angleA.ToString("F1") + "°");
            Console.WriteLine("Сторона B: " + sideB.ToString("F1"));
            Console.WriteLine("Сторона C: " + sideC.ToString("F1"));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}