using System;

namespace lab3Serov.Tasks
{
    public static class Task2
    {
        public static void Run()
        {
            Console.Title = "Задача 2: Максимальный по модулю";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 2: Максимальный по модулю элемент");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = MathHelper.GenerateArray(10, -50, 50);
            Console.WriteLine("Массив:");
            Console.WriteLine(MathHelper.ArrayToString(array));

            int maxAbsIndex = 0;
            int maxAbsValue = Math.Abs(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                int absValue = Math.Abs(array[i]);
                if (absValue > maxAbsValue)
                {
                    maxAbsValue = absValue;
                    maxAbsIndex = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Максимальный по модулю элемент:");
            Console.WriteLine("array[" + maxAbsIndex + "] = " + array[maxAbsIndex]);
            Console.WriteLine("Модуль: " + maxAbsValue);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}