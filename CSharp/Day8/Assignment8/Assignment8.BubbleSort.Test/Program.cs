namespace Assignment8.BubbleSort.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 1, 9, 8, 5, 4, 10 };


            BubbleSort.bubbleSort(arr);

            Console.WriteLine("=================");
            Console.WriteLine(string.Join(", ", arr));

            BubbleSort.bubbleSort_MyDel(arr, sortDESC);

            Console.WriteLine("========My Delegate DESC=========");
            Console.WriteLine(string.Join(", ", arr));

            BubbleSort.bubbleSort_CustomDel(arr, (x, y) => x > y);

            Console.WriteLine("========Custom Delegate Lambda Expression=========");
            Console.WriteLine(string.Join(", ", arr));

        }

        public static bool sortASC(int x, int y) => x > y;
        public static bool sortDESC(int x, int y) => x < y;

    }
}
