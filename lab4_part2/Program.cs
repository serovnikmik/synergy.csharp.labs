using System;

namespace lab4_part2_Serov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЗАДАНИЕ 1: Класс Employee ===");

            Employee emp1 = new Employee();
            Employee emp2 = new Employee(101, "Алексей", "Иванов", "IT");
            emp2.BaseSalary = 80000;
            emp2.ExperienceYears = 3;
            Employee emp3 = new Employee(emp2);

            Console.WriteLine($"emp1: {emp1.GetFullInfo()}");
            Console.WriteLine($"emp2: {emp2.GetFullInfo(true)}");
            Console.WriteLine($"emp3: {emp3.GetFullInfo()}");

            emp2.Promote("Senior IT", 20000);
            Console.WriteLine($"После повышения: {emp2.GetFullInfo(true)}");

            Console.WriteLine($"Статус: {emp2.GetWorkStatus()}");
            Console.WriteLine($"Общая зарплата: {emp2.CalculateTotalSalary():C}");

            Employee[] employees = { emp1, emp2, emp3 };
            Console.WriteLine($"Средняя зарплата: {Employee.GetAverageSalary(employees):C}");
            Console.WriteLine($"Компания: {Employee.CompanyName}");

            Console.WriteLine("\n=== ЗАДАНИЕ 2: Иерархия классов ===");

            Manager manager = new Manager(1, "Ольга", "Смирнова", "Управление", 120000);
            DepartmentManager deptManager = new DepartmentManager(2, "Дмитрий", "Козлов", "Финансы", 150000);
            Developer developer = new Developer(3, "Анна", "Петрова", "IT", 90000);
            BackendDeveloper backendDev = new BackendDeveloper(4, "Игорь", "Сидоров", "Backend", 110000);
            FrontendDeveloper frontendDev = new FrontendDeveloper(5, "Мария", "Ковалёва", "Frontend", 95000);
            Accountant accountant = new Accountant(6, "Елена", "Фёдорова", "Бухгалтерия", 70000);
            SeniorAccountant seniorAccountant = new SeniorAccountant(7, "Виктор", "Николаев", "Бухгалтерия", 100000);
            Intern intern = new Intern(8, "Александр", "Морозов", "IT", 15000);

            Console.WriteLine("\n1. ДОКАЗАТЕЛЬСТВО НАСЛЕДОВАНИЯ:");
            Console.WriteLine($"Manager is AbstractEmployee: {manager is AbstractEmployee}");
            Console.WriteLine($"DepartmentManager is Manager: {deptManager is Manager}");
            Console.WriteLine($"BackendDeveloper is Developer: {backendDev is Developer}");
            Console.WriteLine($"SeniorAccountant is Accountant: {seniorAccountant is Accountant}");
            Console.WriteLine($"SeniorAccountant is AbstractEmployee: {seniorAccountant is AbstractEmployee}");

            Console.WriteLine("\n2. ВИРТУАЛЬНЫЕ И ПЕРЕОПРЕДЕЛЁННЫЕ МЕТОДЫ:");

            AbstractEmployee virtualTest1 = new Manager(9, "Иван", "Тестов", "IT", 100000)
            { TeamSize = 10, ExperienceYears = 5 };
            AbstractEmployee virtualTest2 = new Developer(10, "Пётр", "Тестов", "IT", 90000)
            { ExperienceYears = 3, GitHubCommits = 100 };
            AbstractEmployee virtualTest3 = new Accountant(11, "Светлана", "Тестова", "Финансы", 70000)
            { ReportsPerMonth = 25 };

            Console.WriteLine($"Manager.CalculateBonus(): {virtualTest1.CalculateBonus():C}");
            Console.WriteLine($"Developer.CalculateBonus(): {virtualTest2.CalculateBonus():C}");
            Console.WriteLine($"Accountant.CalculateBonus(): {virtualTest3.CalculateBonus():C}");

            Console.WriteLine("\n3. АБСТРАКТНЫЙ МЕТОД GetWorkDescription():");
            foreach (AbstractEmployee emp in new AbstractEmployee[] { virtualTest1, virtualTest2, virtualTest3 })
            {
                Console.WriteLine($"{emp.GetType().Name}: {emp.GetWorkDescription()}");
            }

            Console.WriteLine("\n4. SEALED КЛАСС (бесплодный):");
            Console.WriteLine($"SeniorAccountant помечен как 'sealed'");
            Console.WriteLine($"Нельзя создать класс, который наследует от SeniorAccountant");
            Console.WriteLine($"Но SeniorAccountant наследует от Accountant: {seniorAccountant is Accountant}");

            Console.WriteLine("\n5. ПОЛИМОРФИЗМ ЧЕРЕЗ МАССИВ AbstractEmployee:");
            AbstractEmployee[] allEmployees =
            {
                manager, deptManager, developer, backendDev,
                frontendDev, accountant, seniorAccountant, intern
            };

            foreach (var emp in allEmployees)
            {
                Console.WriteLine($"{emp.GetType().Name,20}: {emp.GetWorkDescription()}");
            }

            Console.WriteLine($"\n6. СТАТИЧЕСКИЕ ДАННЫЕ:");
            Console.WriteLine($"Всего сотрудников в системе: {AbstractEmployee.GetTotalEmployees()}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}