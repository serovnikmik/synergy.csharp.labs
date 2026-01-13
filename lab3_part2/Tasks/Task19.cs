using System;

namespace lab3Serov.Part2.Tasks
{
    public static class Task19
    {
        public static void Run()
        {
            Console.Title = "Задача 19: Сумма и произведение массива";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 19: Сумма и произведение элементов массива");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = StringArrayHelper.GenerateArray(8, 1, 10);
            Console.WriteLine("Массив:");
            Console.WriteLine(StringArrayHelper.ArrayToString(array));

            int sum = 0;
            long product = 1;

            foreach (int num in array)
            {
                sum += num;
                product *= num;
            }

            Console.WriteLine();
            Console.WriteLine("Сумма элементов: " + sum);
            Console.WriteLine("Произведение элементов: " + product);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}