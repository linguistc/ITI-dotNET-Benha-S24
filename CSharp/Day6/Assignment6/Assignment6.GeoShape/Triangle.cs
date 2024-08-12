namespace Assignment6.GeoShape
{
    public class Triangle : GeoShape
    {
        public Triangle(float b, float h) : base(b, h) { }

        public float Base
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
            return 0.5 * this.Base * this.Height;
        }

    }
}
