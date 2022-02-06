using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
/// Создать класс Employee. 
/// В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и инициализирует поля, соответствующие фамилии и имени сотрудника. 
/// Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый сбор. 
/// Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), оклад и налоговый сбор. 

/// </summary>
namespace Task3
{
    class Program
    {
        static void Main()
        {
            Employee boss = new Employee("Ivanov", "Ivan");
            boss.Position = "Начальник отдела";
            Console.WriteLine($"{boss.Surname} {boss.Name} - {boss.Position}. Оклад {boss.Salary}. НДФЛ {boss.NDFL}");
            Console.ReadKey();
        }
    }
    class Employee
    {
        public string Surname { get; }
        public string Name { get; }
        private string position;
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
                CalculateSFanance();
            }
        }
        public double NDFL { get; private set; }
        public string Experience { get; set; }
        public double Salary { get; set; }
        public Employee(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }

        public void CalculateSFanance()
        {
            if (Position.ToLower().Contains("начальник")) Salary = 1000;
            else Salary = 100;
            NDFL = 0.13 * Salary;
        }

    }
}