using System.Numerics;

namespace SimpleCalc
{
    public class Program
    {
        //Simple calculator
        static void Main(string[] args)
        {
            float operand1 = ReadNumber("Enter operand1: ");
            string op = ReadOperator();
            float operand2 = ReadNumber("Enter operand2: ");

            float result = SimpleCalc(operand1, operand2, op);

            if (result == -1)
                Console.WriteLine("Can't be calculated");
            else
                Console.WriteLine($"Result= {result}");

            Console.ReadKey();
            
        }

        public static Ttype SimpleCalc<Ttype>(Ttype num1, Ttype num2, string op) where Ttype : INumber<Ttype>
        {

            switch (op)
            {
                case "+":
                    return (dynamic)num1 + (dynamic)num2;
                    break;
                case "-":
                    return (dynamic)num1 - (dynamic)num2;
                    break;
                case "*":
                case "x":
                case "X":
                    return (dynamic)num1 * (dynamic)num2;
                    break;
                case "/":
                    return (dynamic)num1 / (dynamic)num2;
                    break;
                case "%":
                    return (dynamic)num1 % (dynamic)num2;
                    break;
                default:
                    return (dynamic)(-1);
            }
        }



        public static float ReadNumber(string msg)
        {
            Console.Write(msg);

            float n;
            float.TryParse(Console.ReadLine(), out n);

            return n;

        }

        public static string ReadOperator()
        {
            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();
            return op;
           
        }

        public static void CreatSimpleMenu()
        {
            Console.WriteLine("1- Sum");
            Console.WriteLine("2- Max");
            Console.WriteLine("3- Min");
            Console.Write("Select Option: ");
        }
    }

    public interface IEnumeric<Ttype> where Ttype : IEnumeric<Ttype>
    {
    }
}
