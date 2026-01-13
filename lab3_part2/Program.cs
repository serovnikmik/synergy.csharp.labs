using lab3Serov.Part2.Tasks;
using System;
using System.Threading.Tasks;

namespace lab3Serov.Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная 3 - Часть 2 - Serov";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("      ЛАБОРАТОРНАЯ РАБОТА №3 - ЧАСТЬ 2");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("Выберите задачу (1-20):");
                Console.WriteLine(" 1. Количество простых чисел");
                Console.WriteLine(" 2. Сумма элементов различных рядов");
                Console.WriteLine(" 3. Проверка кратности числа");
                Console.WriteLine(" 4. Извлечение цифр числа");
                Console.WriteLine(" 5. Масштабирование фигуры");
                Console.WriteLine(" 6. Сумма и произведение цифр числа");
                Console.WriteLine(" 7. Вывод квадратов натуральных чисел");
                Console.WriteLine(" 8. Удаление одинаковых символов");
                Console.WriteLine(" 9. Вывод строки по диагонали");
                Console.WriteLine("10. Частота встречаемости символа");
                Console.WriteLine("11. Переворот строки");
                Console.WriteLine("12. Вставка подстроки");
                Console.WriteLine("13. Удаление подстроки");
                Console.WriteLine("14. Копирование части строки");
                Console.WriteLine("15. Определение длины строки");
                Console.WriteLine("16. Числа Фибоначчи");
                Console.WriteLine("17. Существование треугольника по сторонам");
                Console.WriteLine("18. Определение четверти координатной плоскости");
                Console.WriteLine("19. Сумма и произведение элементов массива");
                Console.WriteLine();
                Console.WriteLine(" 0. Выход");
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
                    case "11": Task11.Run(); break;
                    case "12": Task12.Run(); break;
                    case "13": Task13.Run(); break;
                    case "14": Task14.Run(); break;
                    case "15": Task15.Run(); break;
                    case "16": Task16.Run(); break;
                    case "17": Task17.Run(); break;
                    case "18": Task18.Run(); break;
                    case "19": Task19.Run(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("\nНет такой задачи!");
                        Console.WriteLine("Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}