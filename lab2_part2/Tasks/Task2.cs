using System;
using System.IO;

namespace lab2Serov.Part2.Tasks
{
    public static class Task2
    {
        public static void Run()
        {
            Console.Title = "Задача 2: Копирование чисел между файлами";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 2: Копирование чисел между файлами");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string inputFile = "input_numbers.txt";
            string outputFile = "output_numbers.txt";

            lab2Serov.ExtendedGenerator.CreateNumberFile(inputFile, 10, 1, 100);

            Console.WriteLine("Создан файл " + inputFile + " с 10 числами");

            using (StreamReader reader = new StreamReader(inputFile))
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Числа скопированы в " + outputFile);
            Console.WriteLine();
            Console.WriteLine("Содержимое файлов:");

            Console.WriteLine("\n" + inputFile + ":");
            Console.WriteLine(File.ReadAllText(inputFile));

            Console.WriteLine("\n" + outputFile + ":");
            Console.WriteLine(File.ReadAllText(outputFile));

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}