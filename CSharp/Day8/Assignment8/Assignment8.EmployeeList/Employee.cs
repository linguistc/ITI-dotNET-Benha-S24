using System.Collections;
using System.ComponentModel.Design;

namespace Assignment8.EmployeeList
{
    public enum enGender { male, female }
    public class Employee : Human, IComparable
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


        public override string ToString()
        {
            return $"Employee ID: {this.ID}" +
                    base.ToString() +
                    $"Salary: {this.Salary}";
        }

        int IComparable.CompareTo(object? obj)
        {
            var e = obj as Employee;

            if (e == null) return 0;
                //throw new ArgumentException();

            if (this.Salary == e.Salary) return 0;
            if (this.Salary < e.Salary) return -1;
            return 1;

           // return this.Salary.CompareTo(e.Salary);
        }

        public static Employee SearchByID(short ID, List<Employee> emps)
        {
            foreach (Employee e in emps)
            {
                if (e.ID == ID)
                    return e;
            }
            return null; 
        }

        public static Employee SearchByName(string name, List<Employee> emps)
        {
            foreach (Employee e in emps)
            {
                if (e.Name == name)
                    return e;
            }
            return null;
        }
    }
}
