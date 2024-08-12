namespace Assignment6.GeoShape
{
    public class Circle : GeoShape
    {
        public Circle(float r) : base(r)  { }

        public float Radius
        {
            get => this.dim1;
            set => this.dim1 = this.dim2 = value;
        }

        public override double Area()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
