namespace Assignment6.GeoShape
{
    public class GeoShape
    {
        protected float dim1;
        protected float dim2;

        protected GeoShape()
        {
            this.dim1 = this.dim2 = 0.0f;
        }

        protected GeoShape(float dim1, float dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }

        protected GeoShape(float dim)
        {
            this.dim1 = this.dim2 = dim;
        }

        public virtual double Area() => 0d;
        
    }
}
