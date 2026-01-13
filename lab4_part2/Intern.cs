using System;

namespace lab4_part2_Serov
{
    public class Intern : AbstractEmployee
    {
        public string MentorName { get; set; }
        public string University { get; set; }
        public int CompletedTasks { get; set; }

        public Intern(int id, string firstName, string lastName, string department, decimal baseSalary)
            : base(id, firstName, lastName, department, baseSalary)
        {
            MentorName = "Иван Петров";
            University = "Технический университет";
            CompletedTasks = 5;
            BaseSalary = 15000;
        }

        public override string GetWorkDescription()
        {
            return $"Стажёр из {University}, работает под руководством {MentorName}.";
        }

        public override decimal CalculateBonus()
        {
            return CompletedTasks * 500;
        }

        public string GetTask()
        {
            CompletedTasks++;
            return $"Получает новое задание от {MentorName}. Выполнено задач: {CompletedTasks}.";
        }
    }
}