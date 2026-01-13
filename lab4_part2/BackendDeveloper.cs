using System;

namespace lab4_part2_Serov
{
    public class BackendDeveloper : Developer
    {
        public string DatabaseType { get; set; }
        public int ApiEndpointsCreated { get; set; }

        public BackendDeveloper(int id, string firstName, string lastName, string department, decimal baseSalary)
            : base(id, firstName, lastName, department, baseSalary)
        {
            DatabaseType = "SQL Server";
            ApiEndpointsCreated = 15;
            ProgrammingLanguage = "C#";
        }

        public override string GetWorkDescription()
        {
            return $"Backend-разработчик, работает с {DatabaseType}, создал {ApiEndpointsCreated} API endpoints.";
        }

        public string CreateAPI()
        {
            ApiEndpointsCreated++;
            return $"Создаёт новый API endpoint. Всего создано: {ApiEndpointsCreated}.";
        }

        public override decimal CalculateBonus()
        {
            return base.CalculateBonus() + ApiEndpointsCreated * 100;
        }
    }
}