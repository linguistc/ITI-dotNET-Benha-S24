namespace Assignment6.GeoShape
{
    public class Rectangle : GeoShape
    {

        public Rectangle(float width, float height) : base(width, height) {}

        public float Width
        {
            get => this.dim1;
            set => this.dim1 = value;
        }
        public float Height
        {
            get => this.dim2;
            set => this.dim2 = value;
        }

        public override double Area()
        {
            return this.Width * this.Height;
        }

    }
}
