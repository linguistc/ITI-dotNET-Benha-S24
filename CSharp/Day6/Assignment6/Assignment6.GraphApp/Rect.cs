using ClassLibraryForms;

namespace Assignment6.GraphApp
{
    public class Rect : Shape
    {
        Point _start;
        int _width;
        int _height;

        public Rect(int x1, int y1, int width, int height, Color color)
        {
            this._start = new Point(x1, y1);
            this._height = height;
            this._width = width;
            this.color = color;
        }

        public override void Draw()
        {
            DrawingClass.DrawRectangle(this.color, this._start.X, this._start.Y, this._width, this._height);
        }
        
    }
 
}
