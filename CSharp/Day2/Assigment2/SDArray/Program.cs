using SimpleCalc;

namespace SDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //short size;
            //Console.Write("Enter Size of Array: ");
            //short.TryParse(Console.ReadLine(), out size);


            //short[] array = new short[size];
            //FillArray(array);

            //Console.WriteLine($"Sum= {GetSum(array)}");
            //Console.WriteLine($"Avg= {GetAvg(array)}");
            //Console.WriteLine($"Max= {GetMax(array)}");
            //Console.WriteLine($"Min= {GetMin(array)}");

            CalculateOperation();

            Console.ReadKey();
            
        }

        private static void CalculateOperation()
        {
            Console.Write("Enter Operation: ");
            string operation = Console.ReadLine();

            string[] op = new string[2];

            string operator1 = "";
            if (operation.Contains("+"))
            {
                op = operation.Split("+");
                operator1 = "+";
            }
            else if (operation.Contains("*"))
            {
                op = operation.Split("*");
                operator1 = "*";
            }
            else if (operation.Contains("/"))
            {
                op = operation.Split("/");
                operator1 = "/";
            }
            else if (operation.Contains("-"))
            {
                op = operation.Split("-");
                operator1 = "-";
            }

            int operand1, operand2;
            int.TryParse(op[0].Trim(), out operand1);
            int.TryParse(op[1].Trim(), out operand2);
            

            int result = SimpleCalc.Program.SimpleCalc(operand1, operand2, operator1);

            Console.WriteLine($"result= {result}");
        }

        private static int GetSum(short[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return sum;
        }
        private static short GetAvg(short[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            return (short)(sum / array.Length);
        }

        private static short GetMin(short[] array)
        {
            short min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }
            return min;
        }

        private static short GetMax(short[] array)
        {
            short max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }
            return max;
        }

        

        public static void FillArray(short[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter element[{i + 1}]: ");
                short.TryParse(Console.ReadLine(), out array[i]);
            }
        }
    }
}
