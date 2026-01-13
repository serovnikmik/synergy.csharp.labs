using System;

namespace lab4_part2_Serov
{
    public class FrontendDeveloper : Developer
    {
        public string Framework { get; set; }
        public int UiComponentsCreated { get; set; }

        public FrontendDeveloper(int id, string firstName, string lastName, string department, decimal baseSalary)
            : base(id, firstName, lastName, department, baseSalary)
        {
            Framework = "React";
            UiComponentsCreated = 30;
            ProgrammingLanguage = "JavaScript";
        }

        public override string GetWorkDescription()
        {
            return $"Frontend-разработчик, использует {Framework}, создал {UiComponentsCreated} UI компонентов.";
        }

        public string CreateUI()
        {
            UiComponentsCreated++;
            return $"Создаёт UI компонент на {Framework}. Всего компонентов: {UiComponentsCreated}.";
        }

        public override decimal CalculateBonus()
        {
            return base.CalculateBonus() + UiComponentsCreated * 50;
        }
    }
}