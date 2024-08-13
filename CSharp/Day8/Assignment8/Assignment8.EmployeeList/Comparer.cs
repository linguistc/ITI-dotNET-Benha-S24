using System.Collections;

namespace Assignment8.EmployeeList
{
    public class Comparer
    {

        public class CompareByName : IComparer<Employee>
        {
            public int Compare(Employee? e1, Employee? e2)
            {

                if (e1 == null || e2 == null) return 0;
                    //throw new ArgumentException();

                return e1.Name.CompareTo(e2.Name);
            }
        }

        public class CompareBySalary : IComparer<Employee>
        {
            public int Compare(Employee? e1, Employee? e2)
            {

                if (e1 == null || e2 == null) return 0;
                    //throw new ArgumentException();

                return e1.Salary.CompareTo(e2.Salary);

            }
        }

        public class CompareByID : IComparer<Employee>
        {
            public int Compare(Employee? e1, Employee? e2)
            {
                if (e1 == null || e2 == null) return 0;
                //throw new ArgumentException();

                return e1.ID.CompareTo(e1.ID);
            }
        }

    }
}
