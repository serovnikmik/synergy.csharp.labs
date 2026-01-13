using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task18
    {
        public static void Run()
        {
            Console.Title = "Задача 18: Четверть координатной плоскости";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 18: Определение четверти");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Введите координаты точки:");
            Console.Write("x = ");
            string inputX = Console.ReadLine();
            Console.Write("y = ");
            string inputY = Console.ReadLine();

            if (!double.TryParse(inputX, out double x) || !double.TryParse(inputY, out double y))
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка ввода!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Точка: (" + x + ", " + y + ")");

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Точка находится в начале координат");
            }
            else if (x == 0)
            {
                Console.WriteLine("Точка находится на оси Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Точка находится на оси X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Точка находится в I четверти");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Точка находится во II четверти");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Точка находится в III четверти");
            }
            else
            {
                Console.WriteLine("Точка находится в IV четверти");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}