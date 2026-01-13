using System;

namespace lab4_part2_Serov
{
    public sealed class SeniorAccountant : Accountant
    {
        public int MentoredEmployees { get; set; }
        public bool CanApproveDocuments { get; set; }

        public SeniorAccountant(int id, string firstName, string lastName, string department, decimal baseSalary)
            : base(id, firstName, lastName, department, baseSalary)
        {
            CertificationLevel = 5;
            MentoredEmployees = 3;
            CanApproveDocuments = true;
        }

        public override string GetWorkDescription()
        {
            return $"Старший бухгалтер, курирует {MentoredEmployees} сотрудников, утверждает документы.";
        }

        public override decimal CalculateBonus()
        {
            return base.CalculateBonus() + MentoredEmployees * 2000;
        }

        public string ApproveDocuments()
        {
            return $"Утверждает финансовые документы отдела {Department}.";
        }
    }
}