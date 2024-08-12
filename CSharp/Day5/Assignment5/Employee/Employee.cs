using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace clsEmployee
{
    public enum enGender { male, female }
    public class Employee : Human
    {
        public short ID { get; }
        public decimal Salary { get; set; }

        static short counter = 0;

        public Employee() : base()
        {
            this.ID = -1;
            this.Salary = -1;
            
        }

        public Employee(string name, decimal salary, short age, enGender gender) : base(name, age, gender)
        {
            this.ID = ++counter;
            this.Salary = salary;
        }

        public override void DisplayData()
        {
            Console.WriteLine($"Employee ID: {this.ID}");
            base.DisplayData();
            Console.WriteLine($"Salary: {this.Salary}");
            
        }
    }
}
