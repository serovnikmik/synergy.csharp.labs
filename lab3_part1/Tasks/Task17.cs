using System;

namespace lab3Serov.Tasks
{
    public static class Task17
    {
        private struct Student
        {
            public string Name;
            public int Age;
            public double Grade;
        }

        public static void Run()
        {
            Console.Title = "Задача 17: Фильтрация записей";
            Console.Clear();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Задача 17: Фильтрация записей по значению поля");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            Student[] students = new Student[5];
            students[0] = new Student { Name = "Иван", Age = 20, Grade = 4.5 };
            students[1] = new Student { Name = "Мария", Age = 21, Grade = 4.8 };
            students[2] = new Student { Name = "Алексей", Age = 19, Grade = 3.9 };
            students[3] = new Student { Name = "Елена", Age = 22, Grade = 4.2 };
            students[4] = new Student { Name = "Дмитрий", Age = 20, Grade = 4.0 };

            Console.WriteLine("Все студенты:");
            foreach (var student in students)
            {
                Console.WriteLine(student.Name + ", возраст: " + student.Age + ", оценка: " + student.Grade);
            }

            Console.WriteLine();
            Console.WriteLine("Студенты с оценкой выше 4.0:");

            foreach (var student in students)
            {
                if (student.Grade > 4.0)
                {
                    Console.WriteLine(student.Name + ", оценка: " + student.Grade);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для возврата...");
            Console.ReadKey();
        }
    }
}