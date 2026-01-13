using lab3Serov.Tasks;
using System;
using System.Threading.Tasks;

namespace lab3Serov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная 3 - Serov";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("      ЛАБОРАТОРНАЯ РАБОТА №3");
                Console.WriteLine("           Serov - Задачи");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("Выберите задачу (1-20):");
                Console.WriteLine(" 1. Сколько раз в матрице встречается число");
                Console.WriteLine(" 2. Максимальный по модулю элемент массива");
                Console.WriteLine(" 3. Среднее чётных на нечётных позициях");
                Console.WriteLine(" 4. Сумма элементов частей массива");
                Console.WriteLine(" 5. Кубы чисел от A до B");
                Console.WriteLine(" 6. Правильное окончание к числу");
                Console.WriteLine(" 7. Обмен значений переменных");
                Console.WriteLine(" 8. Вычисление факториала");
                Console.WriteLine(" 9. Простейший ввод и вывод");
                Console.WriteLine("10. Форматированный вывод вещественных");
                Console.WriteLine("11. Форматированный вывод невещественных");
                Console.WriteLine("12. Количество простых чисел");
                Console.WriteLine("13. Сумма элементов различных рядов");
                Console.WriteLine("14. Проверка кратности числа");
                Console.WriteLine("15. Извлечение цифр числа");
                Console.WriteLine("16. Использование записи с вариантами");
                Console.WriteLine("17. Фильтрация записей по значению поля");
                Console.WriteLine("18. Масштабирование фигуры");
                Console.WriteLine("19. Сумма и произведение цифр числа");
                Console.WriteLine("20. Вывод квадратов натуральных чисел");
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
                    case "20": Task20.Run(); break;
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