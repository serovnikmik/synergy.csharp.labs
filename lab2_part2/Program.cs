using lab2Serov.Part2.Tasks;
using System;

namespace lab2Serov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная 2 - Часть 2 - Serov";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("  ЛАБОРАТОРНАЯ РАБОТА №2 - ЧАСТЬ 2");
                Console.WriteLine("========================================");
                Console.WriteLine();
                Console.WriteLine("Выберите задачу (1-20):");
                Console.WriteLine(" 1. Вывести нечетное число");
                Console.WriteLine(" 2. Переписать числа из одного файла в другой");
                Console.WriteLine(" 3. Двухзначные числа с суммой цифр кратной 2");
                Console.WriteLine(" 4. Сумма и произведение цифр трехзначного числа");
                Console.WriteLine(" 5. Таблица значений функции");
                Console.WriteLine(" 6. Расстояние между точками в n-мерном пространстве");
                Console.WriteLine(" 7. Массив B из положительных элементов A с четным индексом");
                Console.WriteLine(" 8. Процентное соотношение строчных и прописных букв");
                Console.WriteLine(" 9. Среднее арифметическое отрицательных, заменить минимальный");
                Console.WriteLine("10. Уравнение прямой через две точки");
                Console.WriteLine("11. Угадай число");
                Console.WriteLine("12. Сколько цифр в числе и его знак");
                Console.WriteLine("13. Количество дней в году");
                Console.WriteLine("14. Принадлежность точки кругу");
                Console.WriteLine("15. Индексы элементов в пределах");
                Console.WriteLine("16. Числа, отклоняющиеся от среднего");
                Console.WriteLine("17. Четные и нечетные цифры числа");
                Console.WriteLine("18. Стороны треугольника по стороне и углам");
                Console.WriteLine("19. Вычисление f(x) в зависимости от x");
                Console.WriteLine("20. Переворот числа");
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