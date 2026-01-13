using System;

namespace lab4_part2_Serov
{
    public class Manager : AbstractEmployee
    {
        public int TeamSize { get; set; }
        public int ProjectsCount { get; set; }

        public Manager(int id, string firstName, string lastName, string department, decimal baseSalary)
            : base(id, firstName, lastName, department, baseSalary)
        {
            TeamSize = 5;
            ProjectsCount = 3;
        }

        public override string GetWorkDescription()
        {
            return $"Управляет командой из {TeamSize} человек в отделе {Department}.";
        }

        public override decimal CalculateBonus()
        {
            return BaseSalary * 0.05m * TeamSize;
        }

        public string ConductMeeting()
        {
            return $"Проводит совещание по проектам ({ProjectsCount} активных проекта).";
        }
    }
}