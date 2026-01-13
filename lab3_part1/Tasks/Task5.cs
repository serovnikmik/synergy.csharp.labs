using System;

namespace lab3Serov.Tasks
{
    public static class Task5
    {
        public static void Run()
        {
            Console.Title = "Задача 5: Кубы чисел";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 5: Кубы чисел от A до B");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Введите границы диапазона:");
            Console.Write("A = ");
            string inputA = Console.ReadLine();

            Console.Write("B = ");
            string inputB = Console.ReadLine();

            if (!int.TryParse(inputA, out int A) || !int.TryParse(inputB, out int B))
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка: нужно ввести целые числа!");
                Console.WriteLine();
                Console.WriteLine("Нажмите любую клавишу для возврата...");
                Console.ReadKey();
                return;
            }

            if (A > B)
            {
                int temp = A;
                A = B;
                B = temp;
                Console.WriteLine();
                Console.WriteLine("Границы поменяны местами (A должно быть меньше B)");
            }

            Console.WriteLine();
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine();

            if (B - A > 20)
            {
                Console.WriteLine("Диапазон слишком большой. Показываю первые 20 чисел:");
                B = Math.Min(B, A + 19);
            }

            Console.WriteLine("Таблица кубов:");
            Console.WriteLine("Число | Куб");
            Console.WriteLine("------|--------");

            for (int i = A; i <= B; i++)
            {
                int cube = i * i * i;
                Console.WriteLine($"{i,5} | {cube,8}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}