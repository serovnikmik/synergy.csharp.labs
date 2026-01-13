using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task8
    {
        public static void Run()
        {
            Console.Title = "Задача 8: Соотношение регистров букв";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 8: Процентное соотношение регистров");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            string text = lab2Serov.ExtendedGenerator.GenerateMixedCaseText(50);
            Console.WriteLine("Сгенерированный текст:");
            Console.WriteLine(text);
            Console.WriteLine();

            int lowerCount = 0;
            int upperCount = 0;

            foreach (char c in text)
            {
                if (char.IsLower(c)) lowerCount++;
                else if (char.IsUpper(c)) upperCount++;
            }

            double lowerPercentage = (double)lowerCount / text.Length * 100;
            double upperPercentage = (double)upperCount / text.Length * 100;

            Console.WriteLine("Статистика:");
            Console.WriteLine("Строчные буквы: " + lowerCount + " (" + lowerPercentage.ToString("F1") + "%)");
            Console.WriteLine("Прописные буквы: " + upperCount + " (" + upperPercentage.ToString("F1") + "%)");
            Console.WriteLine("Всего символов: " + text.Length);

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}