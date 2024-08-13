using System;

namespace Assignment7.ValidateEmployee
{
    
    public static class Extension
    {
        public static void Print(this Employee[] emps)
        {

            if (emps == null)
                return;

            if (emps == null)
                return;

            int i = 0;
            foreach (Employee emp in emps)
            {
                if (emp == null) return;

                Console.WriteLine($"Employee[{i + 1}] data:");
                Console.WriteLine(emp);
                Console.WriteLine("\n\n");
            }

        }
    }
    

}
