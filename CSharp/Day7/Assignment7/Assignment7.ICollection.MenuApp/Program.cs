using Assignment7.ValidateEmployee;
using System.Collections;
namespace Assignment7.ICollection.MenuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateMenu();
        }

        private static void AddEmps(ArrayList emps)
        {


            string name = "";
            short age = -1;
            decimal salary = -1;
            enGender gender = default;

            Boolean loop = true;

            // Name Validation
            Console.Write($"Enter Employee Name: ");
            while (loop)
            {
                    
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                    Console.Write("Enter a valid name: ");
                else
                    loop = false;                   
            }

            // Age Validation
            Console.Write($"Enter Employee Age: ");
            loop = true;
            while (loop)
            {
                    
                short.TryParse(Console.ReadLine(), out age);
                if (age < 18 || age > 60)
                    Console.Write("Enter valid age between 18 and 60: ");
                else
                    loop = false;
            }

            // Salary Validation
            Console.Write($"Enter Employee Salary: ");
            loop = true;
            while (loop)
            {
                decimal.TryParse(Console.ReadLine(), out salary);
                if (salary < 1000)
                    Console.Write("Enter valid salary over 1000$: ");
                else
                    loop = false;
            }

            // Gender Validation
            Console.Write($"Enter Employee gender: ");
            loop = true;
            while (loop)
            {
                string input = Console.ReadLine();
                if (Enum.TryParse(input, true, out gender) && 
                    (gender == enGender.male || gender == enGender.female))
                    loop = false; 
                    
                else
                    Console.Write("Enter valid gender [0]male [1]female: ");
            }

                emps.Add(new Employee(name, salary, age, gender));

            Console.WriteLine("\n\n");
            

        }

        public static void GenerateMenu()
        {
            string[] menu = { "   New   ", " Display ", " Search ", "  Sort  ", "  Exit  " };
            short colShift = (short)(Console.WindowWidth / 2);
            short rowShift = (short)(Console.WindowHeight / (menu.Length + 1));

            short highlight = 0;
            Boolean loop = true;

            ArrayList employees = new ArrayList();


            do
            {
                SetMenuTheme(menu, colShift, rowShift, ref highlight);
                HandlingMenuEvents(menu, ref highlight, employees, ref loop);


            } while (loop);

        }

        private static void HandlingMenuEvents(string[] menu, ref short highlight, ArrayList emps, ref bool loop)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    highlight = highlight == 0 ? highlight = 4 : --highlight;
                    break;
                case ConsoleKey.DownArrow:
                    highlight = (highlight == 4 ? highlight = 0 : ++highlight);
                    break;
                case ConsoleKey.Home:
                    highlight = 0;
                    break;
                case ConsoleKey.End:
                    highlight = 4;
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
                            SearchEmp(emps);
                            Console.ReadKey();
                            break;
                        case 3:
                            emps.Sort();
                            emps.Print();
                            Console.ReadKey();
                            break;
                        case 4:
                            loop = false;
                            break;
                    }
                    break;
                case ConsoleKey.Escape:
                    loop = false;
                    break;
            }
        }

        public static void SearchEmp(ArrayList emps)
        {
            Console.Write("Enter ID: ");
            short id = 0;
            bool loop = true;
            while (loop)
            {

                short.TryParse(Console.ReadLine(), out id);
                if (id < 1)
                    Console.Write("Enter valid ID: ");
                else
                    loop = false;
            }

            var e = Employee.Search(id, emps);

            if (e != null)
                Console.WriteLine(e);
            else
                Console.WriteLine("Not Found");
;
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
