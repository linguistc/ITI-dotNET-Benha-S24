namespace Assignment8.GenericStack
{
    public class Stack<T> : IGetBy<T>
    {
        private T[] _DataList;
        private int _Top;
        private int _InitialSize;

        public Stack()
        {
            this._InitialSize = 3;
            this._DataList = new T[this._InitialSize];
            this._Top = -1;
        }

        public Stack(int initialSize)
        {
            this._InitialSize = initialSize;
            this._DataList = new T[this._InitialSize];
            this._Top = -1;
        }

        public T GetByIndex(int index)
        {
            if (index < 0 || index > this._Top)
                Console.WriteLine("Index out of range");
            
            return this._DataList[index];

            // return this[index];
        }

        public void ResizeOrNot()
        {
            if (this._Top < this._DataList.Length - 1)
                return;

            Console.WriteLine("Will be resized.");

            T[] NewArray = new T[this._DataList.Length + this._InitialSize];

            this._DataList.CopyTo(NewArray, 0);
            this._DataList = null;
            this._DataList = NewArray;
        }

        public void Push(T Item)
        {
            this.ResizeOrNot();

            this._DataList[++this._Top] = Item;
        }

        public T Beek()
        {
            if (this.IsEmpty()) return (T)(object)-1;

            return this._DataList[this._Top];
        }
        public T Pop()
        {
            if (this.IsEmpty()) return (T)(object)-1;

            T HeadData = this._DataList[this._Top];
            this._DataList[this._Top] = default(T);
            --this._Top;
            return HeadData;
        }

        public bool IsEmpty()
        {
            return this._Top == -1;
        }

        public int Size()
        {
            return this._Top + 1;
        }

        public void PrintStack()
        {
            for (int i = this._Top; i > -1; --i)
                Console.Write(this._DataList[i] + " -> ");
            Console.WriteLine();

        }


        public static implicit operator T[](Stack<T> s)
        {
            return s._DataList;
        }

        public static implicit operator Stack<T>(T[] arr)
        {
            Stack<T> s = new Stack<T>(arr.Length);
            for (short i = 0; i < arr.Length; ++i)
            {
                s._DataList[i] = arr[i];
            }
            return s;
        }

        public static Stack<T> operator +(Stack<T> stack1, Stack<T> stack2)
        {
            var newStack = new Stack<T>(stack1.Size() + stack2.Size());

            for (short i = 0; i < stack1.Size(); ++i)
                newStack.Push(stack1[i]);
                
            

            for (short i = 0; i < stack2.Size(); ++i)
                newStack.Push(stack2[i]);

            return newStack;

        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this._Top)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                return this._DataList[index];
            }

            // set => this._DataList[index] = value;
        }

    }
}