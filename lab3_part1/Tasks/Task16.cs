using System;

namespace lab3Serov.Tasks
{
    public static class Task16
    {
        private enum DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        public static void Run()
        {
            Console.Title = "Задача 16: Записи с вариантами";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 16: Использование записи с вариантами");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Random random = new Random();
            DayOfWeek day = (DayOfWeek)random.Next(0, 7);

            Console.WriteLine("Случайный день недели: " + day);
            Console.WriteLine();
            Console.WriteLine("Описание дня:");

            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Понедельник - день тяжелый");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Вторник - уже лучше");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Среда - маленькая пятница");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Четверг - почти выходные");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Пятница - ура!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Суббота - отдых");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Воскресенье - подготовка к понедельнику");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}