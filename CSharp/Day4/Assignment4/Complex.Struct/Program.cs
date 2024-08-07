namespace Complex.Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stComplex complex1 = new stComplex();
            complex1.real = 10;
            complex1.imag = 20;

            stComplex complex2 = new stComplex();
            complex2.real = 5;
            complex2.imag = 10;

            stComplex addingResult = AddComplex(complex1, complex2);
            stComplex subingResult = SubComplex(complex1, complex2);

            Console.Write($"Adding= ");
            addingResult.Display();
            Console.Write($"Subing= ");
            subingResult.Display();

        }

        public struct stComplex
        {
            public float real;
            public float imag;

            public void Display()
            {
                Console.WriteLine($"{this.real}+{this.imag}i");
            }
        }

        public static stComplex AddComplex(stComplex complex1, stComplex complex2)
        {
            stComplex result = new stComplex();

            result.real = complex1.real + complex2.real;
            result.imag = complex1.imag + complex2.imag;

            return result;
        }

        public static stComplex SubComplex(stComplex complex1, stComplex complex2)
        {
            stComplex result = new stComplex();

            result.real = complex1.real - complex2.real;
            result.imag = complex1.imag - complex2.imag;

            return result;
        }

    }
}
