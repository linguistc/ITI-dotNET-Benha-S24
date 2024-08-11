namespace clsEmployee
{
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
}
