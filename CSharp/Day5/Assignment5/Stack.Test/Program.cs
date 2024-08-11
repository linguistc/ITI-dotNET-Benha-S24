using clsStack;

namespace Stack.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack stack1 = new MyStack();

            stack1.Push(1);
            stack1.Push(2);

            MyStack stack2 = new MyStack();

            stack2.Push(5);
            stack2.Push(4);
            stack2.Push(3);


            MyStack newStack = stack1 + stack2;

            newStack.PrintStack();

            int[] arr = newStack;

            Console.WriteLine(string.Join(", ", arr));

            Console.ReadKey();
        }
    }
}



