namespace AbstractClasses
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy shape to clipboard.");
        }

        public void Select()
        {
            System.Console.WriteLine("Select shape");
        }
    }
}
