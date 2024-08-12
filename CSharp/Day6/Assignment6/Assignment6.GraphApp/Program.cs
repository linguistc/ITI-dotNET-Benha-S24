using ClassLibraryForms;

namespace Assignment6.GraphApp
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            Circle c = new Circle(70, 70, 100, System.Drawing.Color.Red);
            Line l = new Line(70, 70, 240, 240, System.Drawing.Color.Magenta);
            Rect r = new Rect(10, 10, 150, 100, Color.GreenYellow);

            Shape[] shapes = new Shape[3];
            shapes[0] = c;
            shapes[1] = l;
            shapes[2] = r;

            Picture p = new Picture(shapes);

            p.DrawPicture();

            DrawingClass.EndDraw();
        }
        
    }
}
