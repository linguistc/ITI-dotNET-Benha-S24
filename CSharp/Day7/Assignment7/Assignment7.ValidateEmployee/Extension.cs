﻿using System;
using System.Collections;

namespace Assignment7.ValidateEmployee
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

                Console.WriteLine($"Employee[{++i}] data:");
                Console.WriteLine(emp);
                Console.WriteLine("\n\n");
            }

        }

        public static void Print(this ArrayList emps)
        {
            if (emps == null)
                return;

            int i = 0;
            foreach (Employee emp in emps)
            {
                if (emp == null) return;

                Console.WriteLine($"Employee[{++i}] data:");
                Console.WriteLine(emp);
                Console.WriteLine("\n\n");
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
