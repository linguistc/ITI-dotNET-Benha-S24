namespace Assigmnent1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;

            Console.Write("Enter num1: ");
            float.TryParse(Console.ReadLine(), out n1);

            Console.Write("Enter num2: ");
            float.TryParse(Console.ReadLine(), out n2);

            float sum = GetSum<float>(n1, n2);
            float avg = GetAvg<float>(n1, n2);

            Console.WriteLine($"\nSum({n1}, {n2}) = {sum}");
            Console.WriteLine($"Average({n1}, {n2}) = {avg}");

            Console.ReadKey();
        }

        // Get sum , average for 2 numbers
        //      □ Watch ,breakpoint debug

        public static Tvalue GetSum<Tvalue>(Tvalue n1 , Tvalue n2 )
        {
            return (dynamic)n1 + (dynamic)n2;
        }

        public static Tvalue GetAvg<Tvalue>(Tvalue n1, Tvalue n2) 
        { 
            return ((dynamic)n1 + (dynamic)n2) / 2;
        }

       
    }
}
