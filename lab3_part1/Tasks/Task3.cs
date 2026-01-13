using System;

namespace lab3Serov.Tasks
{
    public static class Task3
    {
        public static void Run()
        {
            Console.Title = "Задача 3: Среднее чётных на нечётных";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 3: Среднее чётных на нечётных позициях");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = MathHelper.GenerateArray(12, 1, 30);
            Console.WriteLine("Массив:");
            Console.WriteLine(MathHelper.ArrayToString(array));

            int sum = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1 && array[i] % 2 == 0)
                {
                    sum += array[i];
                    count++;
                }
            }

            Console.WriteLine();
            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine("Сумма: " + sum);
                Console.WriteLine("Количество: " + count);
                Console.WriteLine("Среднее арифметическое: " + average.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Нет чётных элементов на нечётных позициях");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}