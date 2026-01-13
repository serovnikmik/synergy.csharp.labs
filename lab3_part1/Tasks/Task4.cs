using System;

namespace lab3Serov.Tasks
{
    public static class Task4
    {
        public static void Run()
        {
            Console.Title = "Задача 4: Сумма частей массива";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 4: Сумма элементов частей массива");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int[] array = MathHelper.GenerateArray(15, 1, 20);
            Console.WriteLine("Массив:");
            Console.WriteLine(MathHelper.ArrayToString(array));

            int middle = array.Length / 2;

            int sumFirstHalf = 0;
            int sumSecondHalf = 0;

            for (int i = 0; i < middle; i++)
            {
                sumFirstHalf += array[i];
            }

            for (int i = middle; i < array.Length; i++)
            {
                sumSecondHalf += array[i];
            }

            Console.WriteLine();
            Console.WriteLine("Сумма первой половины: " + sumFirstHalf);
            Console.WriteLine("Сумма второй половины: " + sumSecondHalf);
            Console.WriteLine("Разность сумм: " + Math.Abs(sumFirstHalf - sumSecondHalf));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}