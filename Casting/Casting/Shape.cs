namespace Casting
{
    // The point is to model an app like PPT, so Shape will be common among text, image, etc.
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {

        }
    }
}
