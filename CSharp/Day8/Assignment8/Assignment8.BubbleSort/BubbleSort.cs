namespace Assignment8.BubbleSort
{
    public class BubbleSort
    {
        public delegate bool MyDel(int x, int y);

        static void bubbleSort(int[] arr)
        {
            for(int j=0; j < arr.Length-1 ;++j)
            {
                for(int i=0; i < arr.Length-1 ; ++i)
                {
                    if(arr[i] < arr[i + 1])
                    {
                        swap(ref arr[i], ref arr[i + 1]);
                    }
                }
            }
        }

        static void bubbleSort_MyDel(int[] arr, MyDel predicate)
        {
            for (int j = 0; j < arr.Length - 1; ++j)
            {
                for (int i = 0; i < arr.Length - 1; ++i)
                {
                    if (predicate(arr[i], arr[i + 1]))
                    {
                        swap(ref arr[i], ref arr[i + 1]);
                    }
                }
            }
        }

        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y; 
            y = temp;
        }
    }
}
