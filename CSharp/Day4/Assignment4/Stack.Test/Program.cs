
using clsStack;

namespace Stack.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack();

            Console.WriteLine("Is empty? " + stack.IsEmpty());
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Is empty? " + stack.IsEmpty());
            Console.WriteLine("Size: " + stack.Size());
            stack.PrintStack();

            stack.Push(4);
            stack.PrintStack();


            Console.WriteLine("Peek: " + stack.Beek());

            while (!stack.IsEmpty())
            {
                Console.WriteLine("Pop: " + stack.Pop());
                Console.WriteLine("Size: " + stack.Size());
                stack.PrintStack();
            }


            Console.ReadKey();
        }
    }
}



