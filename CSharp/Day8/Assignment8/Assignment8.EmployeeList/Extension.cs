using System;
using System.Collections;

namespace Assignment8.EmployeeList
{
    
    public static class Extension
    {
        public static void Print(this List<Employee> emps)
        {
            if (emps == null)
                return;

            int i = 0;
            foreach (Employee emp in emps)
            {
                if (emp == null) return;

                Console.WriteLine($"Employee[{++i}] data:");
                emp.Print();
            }

        }


        public static void Print(this Employee emp)
        {
            if (emp == null)
                return;
                Console.WriteLine(emp);
                Console.WriteLine("\n\n");
           
        }
    }
    

}
