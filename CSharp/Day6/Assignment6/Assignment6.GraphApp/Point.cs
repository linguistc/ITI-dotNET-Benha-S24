namespace Assignment6.GraphApp
{
    public class Point
    {
        private int _x;
        private int _y;

        public Point()
        {
            this._x = this._y = 10;
        }
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public int X
        {
            get => this._x;
            set => this._x = value;
        }
        public int Y
        {
            get => this._y;
            set => this._y = value;
        }
    }
}
