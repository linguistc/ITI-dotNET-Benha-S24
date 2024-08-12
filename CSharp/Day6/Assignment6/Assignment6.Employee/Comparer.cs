using System.Collections;

namespace Assignment6.clsEmployee
{
    public class Comparer
    {
        public class CompareByAge : IComparer
        {
            public int Compare(object? x, object? y)
            {
                var e1 = x as Employee;
                var e2 = y as Employee;

                if (e1 == null || e2 == null) return 0;
                    //throw new ArgumentException();

                return e1.Age.CompareTo(e2.Age);
            }
        }

        public class CompareByName : IComparer
        {
            public int Compare(object? x, object? y)
            {
                var e1 = x as Employee;
                var e2 = y as Employee;

                if (e1 == null || e2 == null) return 0;
                    //throw new ArgumentException();

                return e1.Name.CompareTo(e2.Name);
            }
        }
    }
}
