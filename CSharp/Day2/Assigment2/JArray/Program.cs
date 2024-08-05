namespace JArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short numberOfClassRoom = (short)SimpleCalc.Program.ReadNumber("Enter number of class room: ");
            short[][] classes = new short[numberOfClassRoom][];

            DeclareStudentsToEachClass(classes);

            FillMarks(classes);

            Avg(classes);         

        }

        public static void DeclareStudentsToEachClass(short[][] jClasses)
        {
            short numberOfStudentsInClass;

            for (int i = 0; i < jClasses.GetLength(0); ++i)
            {
                Console.Write($"Enter number of students in class[{i + 1}]: ");
                short.TryParse(Console.ReadLine(), out numberOfStudentsInClass);

                jClasses[i] = new short[numberOfStudentsInClass];
            }
        }

        public static void FillMarks(short[][] jClasses)
        {
            for (int i = 0; i < jClasses.GetLength(0); ++i)
            {
                Console.WriteLine($"Class[{i + 1}]");
                for (int j = 0; j < jClasses[i].Length; ++j)
                {
                    Console.Write($"Enter mark of student[{j + 1}]: ");
                    short.TryParse(Console.ReadLine(), out  jClasses[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static void Avg(short[][] jClasses)
        {
            for (int i = 0; i < jClasses.GetLength(0); ++i)
            {
                short sum = 0;
                for (int j = 0; j < jClasses[i].Length; ++j)
                    sum += jClasses[i][j];

                Console.WriteLine($"Average mark for class room[{1 + i}]= {(float)sum / jClasses[i].Length}");
            }
        }
    }
}
