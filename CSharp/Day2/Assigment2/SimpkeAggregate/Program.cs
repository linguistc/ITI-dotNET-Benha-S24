namespace SimpkeAggregate
{
    internal class Program
    {

        // reate simple menu and get user selection from it
        //      □ To calculate sum or get max or get min
        static void Main(string[] args)
        {
            CreatSimpleMenu();
            short option = ReadOption();

            if (option != -1)
            {
                float num1 = ReadNumber("Enter num1: ");
                float num2 = ReadNumber("Enter num2: ");

                float result = SimpleAggregate(num1, num2, option);

                Console.WriteLine($"Result= {result}");
                
            }
        }

        public static Ttype SimpleAggregate<Ttype>(Ttype num1, Ttype num2, short option) where Ttype : struct
        {
            
            switch(option)
            {
                case 1:
                    return (dynamic)num1 + (dynamic)num2;
                    break;
                case 2:
                    return (dynamic)num1 > (dynamic)num2 ? num1 : num2;
                    break;
                case 3:
                    return (dynamic)num1 < (dynamic)num2 ? num1 : num2;
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

        public static short ReadOption()
        {
            short option;
            short.TryParse(Console.ReadLine(), out option);

            if (option < 1 || option > 3)
            {
                Console.WriteLine("Invalid Option");
                return -1;
            }

            else
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("You choose sum!");
                        break;
                    case 2:
                        Console.WriteLine("You choose max!");
                        break;
                    case 3:
                        Console.WriteLine("You choose min!");
                        break;
                }

                return option;
            }
        }

        public static void CreatSimpleMenu()
        {
            Console.WriteLine("1- Sum");
            Console.WriteLine("2- Max");
            Console.WriteLine("3- Min");
            Console.Write("Select Option: ");     
        }
    }
}
