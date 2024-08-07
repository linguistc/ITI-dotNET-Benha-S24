namespace MenuApp.Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();

        }
        enum enGender { male, female }

        struct stEmployee
        {
            public short id;
            public string name;
            public decimal salary;
            public enGender gender;
            

            public void Display()
            {
                Console.WriteLine($"Employee ID: {this.id}");
                Console.WriteLine($"Employee name: {this.name}");
                Console.WriteLine($"Employee salary: {this.salary}");
                Console.WriteLine($"Employee gender: {this.gender.ToString()}");
            }
        }

        public static void GenerateMenu()
        {
            string[] menu = { "  New  ", "Display", "  Exit " };
            short colShift = (short)(Console.WindowWidth / 2);
            short rowShift = (short)(Console.WindowHeight / (menu.Length + 1));

            short highlight = 0;
            Boolean loop = true;

            stEmployee[] employees = new stEmployee[2];
            

            do
            {
                SetMenuTheme(menu, colShift, rowShift, ref highlight);
                HandlingMenuEvents(menu, ref highlight, employees, ref loop);


            } while (loop);

        }

        private static void HandlingMenuEvents(string[] menu, ref short highlight, stEmployee[] emps, ref bool loop)
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
                            AddEmps(emps);
                            Console.ReadKey();
                            break;
                        case 1:
                            DisplayEmps(emps);
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

    
        private static void DisplayEmps(stEmployee[] emps)
        {
            for(short i = 0; i < emps.Length; ++i)
            {
                Console.WriteLine($"Employee[{i + 1}] data:");
                emps[i].Display();
                Console.WriteLine("\n\n");
            }
        }

        private static void AddEmps(stEmployee[] emps)
        {
            for (short i = 0; i < emps.Length; ++i)
            {
                Console.Write($"Enter Employee[{i+1}] ID: ");
                short.TryParse(Console.ReadLine(), out emps[i].id);


                Console.Write($"Enter Employee[{i+1}] Name: ");
                emps[i].name = Console.ReadLine();


                Console.Write($"Enter Employee[{i+1}] salary: ");
                decimal.TryParse(Console.ReadLine(), out emps[i].salary);

                Console.Write($"Enter Employee[{i + 1}] gender: ");
                enGender.TryParse(Console.ReadLine(), out emps[i].gender);

                Console.WriteLine("\n\n");
            }
            
        }
    }
}
