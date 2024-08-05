using System.Data;

namespace MSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short[,] studentDegrees = new short[3, 4];
            FillArray(studentDegrees, 3, 4);

            short student1Marks = SumOfRow(studentDegrees, 0);
            short student2Marks = SumOfRow(studentDegrees, 1);
            short student3Marks = SumOfRow(studentDegrees, 2);

            short sub1Avg = SumOfCol(studentDegrees, 0);
            short sub2Avg = SumOfCol(studentDegrees, 1);
            short sub3Avg = SumOfCol(studentDegrees, 2);
            short sub4Avg = SumOfCol(studentDegrees, 3);

            Console.WriteLine($"Student 1 sum of marks= {student1Marks}");
            Console.WriteLine($"Student 2 sum of marks= {student2Marks}");
            Console.WriteLine($"Student 3 sum of marks= {student3Marks}");

            Console.WriteLine($"Average of subject 1= {sub1Avg}");
            Console.WriteLine($"Average of subject 2= {sub2Avg}");
            Console.WriteLine($"Average of subject 3= {sub3Avg}");
            Console.WriteLine($"Average of subject 4= {sub4Avg}");


        }

        public static short SumOfRow(short[,] array, short row)
        {

            short sum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
                sum += array[row, i];

            return sum;
        }

        public static short SumOfCol(short[,] array, short col)
        {

            short sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                sum += array[i, col];

            return (short)(sum / 3);
        }

        private static void FillArray(short[,] array, int row, int col)
        {
            for (short i = 0; i < row; i++)
            {
                Console.WriteLine($"Enter Student[{i + 1}] degrees");
                for (short j = 0; j < col; ++j)
                {
                    Console.Write($"Subject[{j + 1}] degree: ");
                    short.TryParse(Console.ReadLine(), out array[i, j]);
                }
            }
        }
    }
}
