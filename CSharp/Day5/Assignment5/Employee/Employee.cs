using System.Runtime.CompilerServices;

namespace clsEmployee
{
    public enum enGender { male, female }

    public static class Extension
    {
        public static void Print(this Employee[] emps)
        {
           
            if (emps == null)
                return; 
            int i = 0;
            foreach (Employee emp in emps)
            {
                if (emp == null) return;

                Console.WriteLine($"Employee[{i + 1}] data:");
                Console.WriteLine($"Employee ID: {emp.ID}");
                Console.WriteLine($"Employee name: {emp.Name}");
                Console.WriteLine($"Employee ID: {emp.Age}");
                Console.WriteLine($"Employee salary: {emp.Salary}");
                Console.WriteLine($"Employee gender: {emp.gender.ToString()}");
                Console.WriteLine("\n\n");
            }

        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public short ID { get; }
        public decimal Salary { get; set; }

        public readonly enGender gender;
        public short Age { get; set; }

        static short counter = 0;

        public Employee()
        {
            this.Name = string.Empty;
            this.ID = -1;
            this.Salary = -1;
            this.Age = -1;
            this.gender = enGender.male;
        }

        public Employee(string name, decimal salary, short age, enGender gender)
        {
            this.Name = string.Empty;
            this.ID = ++counter;
            this.Salary = salary;
            this.Age = age;
            this.gender = gender;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Employee ID: {this.ID}");
            Console.WriteLine($"Employee name: {this.Name}");
            Console.WriteLine($"Employee ID: {this.Age}");
            Console.WriteLine($"Employee salary: {this.Salary}");
            Console.WriteLine($"Employee gender: {this.gender.ToString()}");
        }
    }
}
