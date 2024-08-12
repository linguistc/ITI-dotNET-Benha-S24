using ClassLibraryForms;

namespace Assignment6.GraphApp
{
    public class Line : Shape
    {
        public Point Start;
        public Point End;

        public Line()
        {
            this.Start = new Point();
            this.End = new Point();
            this.color = Color.White;
        }

        public Line(int x1, int y1, int x2, int y2, Color color)
        {
            this.Start = new Point(x1, y1);
            this.End = new Point(x2, y2);
            this.color = color;
        }

        public override void Draw()
        {
            DrawingClass.DrawLine(color, Start.X, Start.Y, End.X, End.Y);
        }
    }
    
}
