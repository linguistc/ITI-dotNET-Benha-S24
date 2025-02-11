﻿namespace Assignment6.clsEmployee
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
    }
}
