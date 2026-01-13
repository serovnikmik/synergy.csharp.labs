using lab2Serov.Tasks;
using System;

namespace lab2Serov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная 2 - Serov";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("      ЛАБОРАТОРНАЯ РАБОТА №2");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("Выберите задачу (1-20):");
                Console.WriteLine(" 1. Сумма четных цифр числа");
                Console.WriteLine(" 2. Элементы массива > предыдущего");
                Console.WriteLine(" 3. Разделить элементы на максимальный");
                Console.WriteLine(" 4. Первый положительный элемент");
                Console.WriteLine(" 5. Максимальные элементы столбцов");
                Console.WriteLine(" 6. Четные и нечетные символы строки");
                Console.WriteLine(" 7. Заменить элементы на противоположные");
                Console.WriteLine(" 8. Поменять местами строки матрицы");
                Console.WriteLine(" 9. Наибольший по модулю элемент матрицы");
                Console.WriteLine("10. Поменять min и max элементы массива");
                Console.WriteLine("11. Разность max и min элементов массива");
                Console.WriteLine("12. Сумма четных отрицательных элементов");
                Console.WriteLine("13. Минимальный с нечетными индексами");
                Console.WriteLine("14. Элементы > среднего арифметического");
                Console.WriteLine("15. Среднее арифметическое двух чисел");
                Console.WriteLine("16. Сумма положительных элементов массива");
                Console.WriteLine("17. Сумма и произведение элементов матрицы");
                Console.WriteLine("18. Положительные на главной диагонали");
                Console.WriteLine("19. Случайное трехзначное число, кончается на 0");
                Console.WriteLine("20. Количество положительных элементов");
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