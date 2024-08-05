
namespace MagicBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short size = ReadNumber("Enter size of the magic box: ");

            if (size % 2 != 0)
                CreatMagicBox(size);
            else
                Console.Write("size must be odd");

            Console.ReadKey();
        }

        public static void CreatMagicBox(short size)
        {
            short row = 1;
            short col = (short)((size / 2) + 1);
            short i;

            short colShift = (short)(Console.WindowWidth/(size + 1));
            short rowShift = (short)(Console.WindowHeight / (size + 1));

            Console.WriteLine("\n\n");

            for (i = 1; i <= size*size; ++i)
            {
                Console.SetCursorPosition(col*colShift, row*rowShift);
                Console.WriteLine(i);

                if(i%size == 0) ++row;
                else
                {
                    --row;
                    --col;
                    if(row < 1) row = size;
                    if(col < 1) col = size;
                }

            }
            Console.WriteLine("\n\n");

        }

        public static short ReadNumber(string msg)
        {
            Console.Write(msg);

            short n;
            short.TryParse(Console.ReadLine(), out n);

            return n;

        }
    }
}
