using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

namespace GetMax
{
    internal class Program
    {
        // Take two integer from user and get max of them
        static void Main(string[] args)
        {
            int num1 = ReadInteger("Enter num1: ");
            int num2 = ReadInteger("Enter num1: ");

            Console.WriteLine($"{GetMax(num1, num2)} is the max.");
            Console.WriteLine($"{GetMaxUsingMathLib(num1, num2)} is the max using Math Library.");

            Console.ReadKey();
        }

        public static Ttype GetMax<Ttype> (Ttype num1, Ttype num2) where Ttype : struct
        {
            return (dynamic)num1 > (dynamic)num2 ? num1 : num2;
        }

        public static Ttype GetMaxUsingMathLib<Ttype> (Ttype num1, Ttype num2) where Ttype : struct
        {
            return Math.Max((dynamic)num1, (dynamic)num2);
        }

        public static int ReadInteger(string msg)
        {
            Console.Write(msg);

            int n;
            int.TryParse(Console.ReadLine(), out n);

            return n;

        }

    }
}
