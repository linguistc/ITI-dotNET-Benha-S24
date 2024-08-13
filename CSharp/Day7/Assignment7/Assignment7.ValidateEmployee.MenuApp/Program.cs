using Assignment7.ValidateEmployee;

namespace Assignment7.ValidateEmployee.MenuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();

        }

        private static void AddEmps(Employee[] emps)
        {
            for (short i = 0; i < emps.Length; ++i)
            {

                
                string name = "";
                short age = -1;
                decimal salary = -1;
                enGender gender = default;

                Boolean loop = true;

                // Name Validation
                Console.Write($"Enter Employee[{i + 1}] Name: ");
                while (loop)
                {
                    try
                    {
                        name = Console.ReadLine();

                        if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                            throw new Exception("Name shouldn't be empty");

                        loop = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Enter a valid name: ");
                    }
                }

                // Age Validation
                Console.Write($"Enter Employee[{i + 1}] Age: ");
                loop = true;
                while (loop)
                {
                    try
                    {
                        age = short.Parse(Console.ReadLine());
                        if (age < 18 || age > 60)
                            throw new InvalidDataException("Age must be between 18 and 60");

                        loop = false;
                    }
                    catch (InvalidDataException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Enter valid age: ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Enter valid age: ");
                    }
                }

                // Salary Validation
                Console.Write($"Enter Employee[{i + 1}] Salary: ");
                loop = true;
                while (loop)
                {
                    try
                    {
                        salary = decimal.Parse(Console.ReadLine());
                        if (salary < 1000)
                            throw new InvalidDataException("Salary must be over 1000$");

                        loop = false;
                    }
                    catch (InvalidDataException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Enter valid salary: ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Enter valid salary: ");
                    }
                }

                // Gender Validation
                Console.Write($"Enter Employee[{i + 1}] gender: ");
                loop = true;
                while (loop)
                {
                    try
                    {
                        gender = (enGender)Enum.Parse(typeof(enGender), Console.ReadLine(), true);
                        if (gender != enGender.male && gender != enGender.female)
                            throw new InvalidDataException("Gender must be male or female");

                        loop = false;
                    }
                    catch (InvalidDataException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Enter valid gender [0]male [1]female: ");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Console.Write("Enter valid gender [0]male [1]female: ");
                    }
                }

                emps[i] = new Employee(name, salary, age, gender);

                Console.WriteLine("\n\n");
            }

        }

        public static void GenerateMenu()
        {
            string[] menu = { "  New  ", " Display ", "  Sort  ", "  Exit  " };
            short colShift = (short)(Console.WindowWidth / 2);
            short rowShift = (short)(Console.WindowHeight / (menu.Length + 1));

            short highlight = 0;
            Boolean loop = true;

            Employee[] employees = new Employee[2];


            do
            {
                SetMenuTheme(menu, colShift, rowShift, ref highlight);
                HandlingMenuEvents(menu, ref highlight, employees, ref loop);


            } while (loop);

        }

        private static void HandlingMenuEvents(string[] menu, ref short highlight, Employee[] emps, ref bool loop)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    highlight = highlight == 0 ? highlight = 3 : --highlight;
                    break;
                case ConsoleKey.DownArrow:
                    highlight = (highlight == 3 ? highlight = 0 : ++highlight);
                    break;
                case ConsoleKey.Home:
                    highlight = 0;
                    break;
                case ConsoleKey.End:
                    highlight = 3;
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
                            emps.Print();
                            Console.ReadKey();
                            break;
                        case 2:
                            //Array.Sort(emps);
                            Array.Sort(emps, new Comparer.CompareByName());
                            emps.Print();
                            Console.ReadKey();
                            break;
                        case 3:
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



    }
    

}
