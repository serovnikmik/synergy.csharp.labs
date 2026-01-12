using Lab1Serov.Tasks;
using System;

namespace Lab1Serov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная 1 - Консольные приложения";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("      ЛАБОРАТОРНАЯ РАБОТА №1");
                Console.WriteLine("      Консольные приложения");
                Console.WriteLine("========================================\n");

                Console.WriteLine("Выберите задачу (1-10):");
                Console.WriteLine("  1. Имя и фамилия");
                Console.WriteLine("  2. Имя и возраст");
                Console.WriteLine("  3. Дата (день недели, дата, месяц)");
                Console.WriteLine("  4. Месяц и количество дней");
                Console.WriteLine("  5. Возраст по году рождения");
                Console.WriteLine("  6. Имя и возраст с годом рождения");
                Console.WriteLine("  7. Год рождения по возрасту");
                Console.WriteLine("  8. Сумма двух чисел");
                Console.WriteLine("  9. Последовательность чисел");
                Console.WriteLine(" 10. Сумма и разность двух чисел");
                Console.WriteLine("\n  0. Выход");
                Console.Write("\n>>> ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": Task1.Run(); break;
                    case "2": Task2.Run(); break;
                    case "3": Task3.Run(); break;
                    case "4": Task4.Run(); break;
                    case "5": Task5.Run(); break;
                    case "6": Task6.Run(); break;
                    case "7": Task7.Run(); break;
                    case "8": Task8.Run(); break;
                    case "9": Task9.Run(); break;
                    case "10": Task10.Run(); break;
                    case "0":
                        Console.WriteLine("\nЗавершение работы...");
                        return;
                    default:
                        Console.WriteLine("\n[ОШИБКА] Нет такой задачи!");
                        Console.WriteLine("Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}