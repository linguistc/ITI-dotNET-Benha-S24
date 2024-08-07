using System;

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
            this._DataList = new int [this._InitialSize];
            this._Top = -1;
        }

        public void ResizeOrNot()
        {
            if (this._Top < this._DataList.Length - 1)
                return;

            Console.WriteLine("Will be resized.");

            int[] NewArray = new int[this._DataList.Length + this._InitialSize];

            this._DataList.CopyTo(NewArray, 0);
            this._DataList= null;
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
