namespace Assignment6.GeoShape
{
    public class Picture
    {
        public GeoShape[] shapes;
        

        public Picture(GeoShape[] shapes) => this.shapes = shapes;
            
        

        public double Area()
        {
            double sum = 0;
            foreach (var shape in shapes)
            {
                sum += shape.Area();
            }
            return sum;
        }
    }
}
