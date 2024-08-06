namespace RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num;
            int.TryParse(Console.ReadLine(), out num);

            long result = Factorial(num);

            Console.WriteLine($"Result= {result}");
        }

        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
            
        }

    }
}
