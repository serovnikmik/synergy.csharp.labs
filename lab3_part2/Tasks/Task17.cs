using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task17
    {
        public static void Run()
        {
            Console.Title = "Задача 17: Существование треугольника";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 17: Существование треугольника по сторонам");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Введите три стороны треугольника:");
            Console.Write("a = ");
            string input1 = Console.ReadLine();
            Console.Write("b = ");
            string input2 = Console.ReadLine();
            Console.Write("c = ");
            string input3 = Console.ReadLine();

            if (!double.TryParse(input1, out double a) ||
                !double.TryParse(input2, out double b) ||
                !double.TryParse(input3, out double c) ||
                a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: нужно ввести положительные числа!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            bool exists = (a + b > c) && (a + c > b) && (b + c > a);

            Console.WriteLine();
            Console.WriteLine("Стороны: a = " + a + ", b = " + b + ", c = " + c);
            Console.WriteLine();

            if (exists)
            {
                Console.WriteLine("Треугольник существует");

                if (a == b && b == c)
                    Console.WriteLine("Треугольник равносторонний");
                else if (a == b || a == c || b == c)
                    Console.WriteLine("Треугольник равнобедренный");
                else
                    Console.WriteLine("Треугольник разносторонний");
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}