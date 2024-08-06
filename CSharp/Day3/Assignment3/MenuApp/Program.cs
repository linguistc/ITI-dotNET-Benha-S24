namespace MenuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();

        }

        public static void GenerateMenu()
        {
            string[] menu = { "  New  ", "Display", "  Exit " };
            short colShift = (short)(Console.WindowWidth / 2);
            short rowShift = (short)(Console.WindowHeight / (menu.Length + 1));

            short highlight = 0;
            Boolean loop = true;
            string name = "";
            short id = 0;
            double salary = 0;

            do
            {
                SetMenuTheme(menu, colShift, rowShift, ref highlight);
                HandlingMenuEvents(menu, ref highlight, ref id, ref name, ref salary, ref loop);
                

            } while (loop);

        }

        private static void HandlingMenuEvents(string[] menu, ref short highlight, ref short id, ref string name, ref double salary,ref bool loop)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    highlight = highlight == 0 ? highlight = 2 : --highlight;
                    break;
                case ConsoleKey.DownArrow:
                    highlight = (highlight == 2 ? highlight = 0 : ++highlight);
                    break;
                case ConsoleKey.Home:
                    highlight = 0;
                    break;
                case ConsoleKey.End:
                    highlight = 2;
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    switch (highlight)
                    {
                        case 0:
                            AddNewEmp(ref id, ref name, ref salary);
                            Console.ReadKey();
                            break;
                        case 1:
                            DisplayEmp(id, name, salary);
                            Console.ReadKey();
                            break;
                        case 2:
                            loop = false;
                            break;
                    }
                    break;
                case ConsoleKey.Escape:
                    loop = false;
                    break;
            }
        }

        private static void SetMenuTheme(string[] menu, short colShift, short rowShift, ref short highlight)
        {
            Console.ResetColor();
            Console.Clear();
            for (short i = 0; i < menu.Length; ++i)
            {
                if (i == highlight)
                    Console.BackgroundColor = ConsoleColor.Green;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                Console.SetCursorPosition(colShift, (i + 1) * rowShift);
                Console.WriteLine(menu[i]);
            }
        }

        private static void DisplayEmp(short id, string name, double salary)
        {
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee name: {name}");
            Console.WriteLine($"Employee salary: {salary}");
        }

        private static void AddNewEmp(ref short id, ref string name, ref double salary)
        {
            Console.Write("Enter Employee ID: ");
            short.TryParse(Console.ReadLine(), out id);
          

            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();

           
            Console.Write("Enter Employee salary: ");
            double.TryParse(Console.ReadLine(), out salary);
        }
    }
}
