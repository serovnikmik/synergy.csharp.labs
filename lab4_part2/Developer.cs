using System;

namespace lab4_part2_Serov
{
    public class Developer : AbstractEmployee
    {
        public string ProgrammingLanguage { get; set; }
        public int GitHubCommits { get; set; }

        public Developer(int id, string firstName, string lastName, string department, decimal baseSalary)
            : base(id, firstName, lastName, department, baseSalary)
        {
            ProgrammingLanguage = "C#";
            GitHubCommits = 50;
        }

        public override string GetWorkDescription()
        {
            return $"Пишет код на {ProgrammingLanguage} в отделе {Department}.";
        }

        public override decimal CalculateBonus()
        {
            return BaseSalary * 0.03m * ExperienceYears + GitHubCommits * 10;
        }

        public string WriteCode()
        {
            GitHubCommits++;
            return $"Пишет код на {ProgrammingLanguage}. Всего коммитов: {GitHubCommits}.";
        }
    }
}