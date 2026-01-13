using System;

namespace lab4_part2_Serov
{
    public class DepartmentManager : Manager
    {
        public string ManagedDepartment { get; set; }
        public decimal Budget { get; set; }

        public DepartmentManager(int id, string firstName, string lastName, string department, decimal baseSalary)
            : base(id, firstName, lastName, department, baseSalary)
        {
            ManagedDepartment = department;
            Budget = 1000000;
        }

        public override string GetWorkDescription()
        {
            return $"Руководит отделом {ManagedDepartment}, бюджет: {Budget:C}.";
        }

        public string ApproveBudget()
        {
            return $"Утверждает бюджет отдела {ManagedDepartment}.";
        }

        public override decimal CalculateBonus()
        {
            return base.CalculateBonus() + Budget * 0.001m;
        }
    }
}