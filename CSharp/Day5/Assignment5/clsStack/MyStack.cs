using System;
using System.Numerics;
using System.Reflection;

namespace clsStack
{

    public class MyStack
    {
        private int[] _DataList;
        private int _Top;
        private int _InitialSize;

        public MyStack()
        {
            this._InitialSize = 3;
            this._DataList = new int[this._InitialSize];
            this._Top = -1;
        }

        public MyStack(int initialSize)
        {
            this._InitialSize = initialSize;
            this._DataList = new int[this._InitialSize];
            this._Top = -1;
        }

        public static implicit operator int[](MyStack s)
        {
            return s._DataList;
        }

        public static implicit operator MyStack(int[] arr)
        {
            MyStack s = new MyStack(arr.Length);
            for (short i = 0; i < arr.Length; ++i)
            {
                s._DataList[i] = arr[i];
            }
            return s;
        }

        //public static explicit operator int[](MyStack s)
        //{
        //    return s._DataList;
        //}

        //public static explicit operator MyStack(int[] arr)
        //{
        //    MyStack s = new MyStack(arr.Length);
        //    for (short i = 0; i < arr.Length; ++i)
        //    {
        //        s._DataList[i] = arr[i];
        //    }
        //    return s;
        //}

        public static MyStack operator +(MyStack stack1, MyStack stack2)
        {
            var newStack = new MyStack(stack1.Size() + stack2.Size());


            //foreach (var item in stack1) // need extention definition of (GetEnumerator)
            //{
            //    tempS1.Push(item);
            //}

            for (short i = 0; i < stack1.Size(); ++i)
            {
                newStack.Push(stack1[i]);
                //newStack.Push(stack1.PeekAt(i));
            }

            for (short i = 0; i < stack2.Size(); ++i)
            {
                newStack.Push(stack2[i]);
                //newStack.Push(stack2.PeekAt(i));
            }

            return newStack;

        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > this._Top)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                return this._DataList [index];
            }

            // set => this._DataList[index] = value;
        }

        public void ResizeOrNot()
        {
            if (this._Top < this._DataList.Length - 1)
                return;

            Console.WriteLine("Will be resized.");

            int[] NewArray = new int[this._DataList.Length + this._InitialSize];

            this._DataList.CopyTo(NewArray, 0);
            this._DataList = null;
            this._DataList = NewArray;
        }

        public void Push(int Item)
        {
            this.ResizeOrNot();

            this._DataList[++this._Top] = Item;
        }

        public int Beek()
        {
            if (this.IsEmpty()) return -1;

            return this._DataList[this._Top];
        }

        public int PeekAt(int index)
        {
            if (index < 0 || index > this._Top) return -1;
            return this._DataList[index];
        }


        public int Pop()
        {
            if (this.IsEmpty()) return -1;

            int HeadData = this._DataList[this._Top];
            this._DataList[this._Top] = default;
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


    }

}
