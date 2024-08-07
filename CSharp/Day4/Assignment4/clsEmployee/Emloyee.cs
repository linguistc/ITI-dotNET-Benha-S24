namespace clsEmployee
{
    public enum enGender { male, female }

    public class Employee
    {
        private short id;
        public string Name { get; set; }
        public short ID { get { return id; } set { this.id = value; } }
        public decimal Salary { get; set; }
        public enGender Gender { get; set; }
        public short Age { get; set; }

        public Employee()
        {
            this.Name = string.Empty;
            this.ID = -1;
            this.Salary = -1;
            this.Age = -1;
            this.Gender = enGender.male;
        }


        public void DisplayData()
        {
            Console.WriteLine($"Employee ID: {this.ID}");
            Console.WriteLine($"Employee name: {this.Name}");
            Console.WriteLine($"Employee ID: {this.Age}");
            Console.WriteLine($"Employee salary: {this.Salary}");
            Console.WriteLine($"Employee gender: {this.Gender.ToString()}");
        }
    }
}
