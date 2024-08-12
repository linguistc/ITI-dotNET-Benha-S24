using ClassLibraryForms;

namespace Assignment6.GraphApp
{
    public class Circle : Shape
    {
        public Point _centre;
        public int _radius;

        public Circle(int x, int y, int radius, Color color)
        {
            this._centre = new Point(x, y);
            this._radius = radius;
            this.color = color;
        }

        public override void Draw()
        {

            DrawingClass.DrawCircle(this.color, this._centre.X, this._centre.Y, this._radius, true);
        }
    }
        
        
    
}
