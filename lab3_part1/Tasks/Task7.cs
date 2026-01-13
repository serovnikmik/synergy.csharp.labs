using System;

namespace lab3Serov.Tasks
{
    public static class Task7
    {
        public static void Run()
        {
            Console.Title = "Задача 7: Обмен значений";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 7: Обмен значений переменных");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            int a = MathHelper.GenerateNumber(10, 50);
            int b = MathHelper.GenerateNumber(10, 50);

            Console.WriteLine("До обмена:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine();
            Console.WriteLine("После обмена:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}