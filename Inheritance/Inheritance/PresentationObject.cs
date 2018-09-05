using System;
namespace Inheritance
{

    // PARENT class
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy() {
            Console.WriteLine("Obj was copied");
        }

        public void Duplicate() {
            Console.WriteLine("Object was duplicated");
        }
    }
}
