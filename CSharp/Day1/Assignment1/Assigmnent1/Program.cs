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

            float sum = GetSum(n1, n2);
            float avg = GetAvg(n1, n2);

            Console.WriteLine($"\nSum({n1}, {n2}) = {sum}");
            Console.WriteLine($"Average({n1}, {n2}) = {avg}");

            Console.ReadKey();
        }

        // Get sum , average for 2 numbers
        //      □ Watch ,breakpoint debug

        public static float GetSum(float n1 , float n2 )
        {
            return n1 + n2;
        }

        public static float GetAvg(float n1, float n2) 
        { 
            return (n1 + n2) / 2;
        }

       
    }
}
