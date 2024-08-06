using SimpleCalc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JArray
{
    internal class Program
    {
         //⊡ Design a program that get from user input
        //      □ Number of class room
        //      □ Number of student in each class
        //      □ Mark for each student
        //⊡ Then calculate the 
        //      □ Average mark for each class room
        static void Main(string[] args)
        {
            short numberOfClassRooms = (short)SimpleCalc.Program.ReadNumber("Enter number of class room: ");
            short[][] classes = new short[numberOfClassRooms][];

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
            short sum;
            for (int i = 0; i < jClasses.GetLength(0); ++i)
            {
                sum = 0;
                for (int j = 0; j < jClasses[i].Length; ++j)
                    sum += jClasses[i][j];

                Console.WriteLine($"Average mark for class room[{1 + i}]= {(float)sum / jClasses[i].Length}");
            }
        }
    }
}
