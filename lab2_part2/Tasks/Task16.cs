using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task16
    {
        public static void Run()
        {
            Console.Title = "Задача 16: Отклонение от среднего";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 16: Числа, отклоняющиеся от среднего");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            double[] array = new double[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 100;
            }

            Console.WriteLine("Исходный массив:");
            Console.WriteLine("[" + string.Join(", ", array).Substring(0, 50) + "...]");

            double sum = 0;
            foreach (double value in array)
            {
                sum += value;
            }
            double average = sum / array.Length;

            Console.WriteLine();
            Console.WriteLine("Среднее значение: " + average.ToString("F2"));
            Console.WriteLine();
            Console.WriteLine("Элементы, отклоняющиеся более чем на 20% от среднего:");

            bool found = false;
            for (int i = 0; i < array.Length; i++)
            {
                double deviation = Math.Abs(array[i] - average) / average * 100;

                if (deviation > 20)
                {
                    Console.WriteLine("array[" + i + "] = " + array[i].ToString("F2") + " (отклонение: " + deviation.ToString("F1") + "%)");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Таких элементов нет");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}