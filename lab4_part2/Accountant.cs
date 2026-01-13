using System;

namespace lab4_part2_Serov
{
    public class Accountant : AbstractEmployee
    {
        public int CertificationLevel { get; set; }
        public int ReportsPerMonth { get; set; }

        public Accountant(int id, string firstName, string lastName, string department, decimal baseSalary)
            : base(id, firstName, lastName, department, baseSalary)
        {
            CertificationLevel = 2;
            ReportsPerMonth = 20;
        }

        public override string GetWorkDescription()
        {
            return $"Ведёт бухгалтерский учёт в отделе {Department}, уровень сертификации: {CertificationLevel}.";
        }

        public override decimal CalculateBonus()
        {
            return 5000 + ReportsPerMonth * 100;
        }

        public string PrepareReport()
        {
            return $"Подготавливает финансовый отчёт. Отчётов в месяц: {ReportsPerMonth}.";
        }
    }
}