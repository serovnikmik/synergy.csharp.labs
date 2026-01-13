using System;

namespace lab2Serov.Part2.Tasks
{
    public static class Task11
    {
        public static void Run()
        {
            Console.Title = "Задача 11: Угадай число";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 11: Угадай число");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;

            Console.WriteLine("Я загадал число от 1 до 100.");
            Console.WriteLine("Попробуйте угадать!");

            while (true)
            {
                Console.Write("Ваша попытка: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Слишком мало!");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Слишком много!");
                }
                else
                {
                    Console.WriteLine("Поздравляю! Вы угадали число " + secretNumber);
                    Console.WriteLine("Количество попыток: " + attempts);
                    break;
                }

                if (attempts >= 10)
                {
                    Console.WriteLine("Вы использовали все 10 попыток. Число было: " + secretNumber);
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}