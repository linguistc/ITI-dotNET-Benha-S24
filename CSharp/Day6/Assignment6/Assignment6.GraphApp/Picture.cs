namespace Assignment6.GraphApp
{

    public class Picture
    {
        private Shape[] _shapes;

        public Picture(Shape[] shapes)
        {
            this._shapes = shapes;
        }

        public void DrawPicture()
        {
            foreach (Shape shape in this._shapes)
                shape.Draw();
        }
    }


}
