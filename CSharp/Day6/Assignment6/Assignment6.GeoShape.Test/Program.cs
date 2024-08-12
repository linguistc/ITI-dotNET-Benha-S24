namespace Assignment6.GeoShape.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rec = new Rectangle(2, 3);
            Console.WriteLine(rec.Area());

            Triangle tri = new Triangle(5, 3);
            Console.WriteLine(tri.Area());

            Circle c = new Circle(7);
            Console.WriteLine(c.Area());

            double sum = 0;

            GeoShape[] shapes = {rec, tri, c};

            foreach (GeoShape shape in shapes)
                sum += shape.Area();

            Console.WriteLine(sum);

        }
    }
}
