using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{

    public class Oval : Circle
    {
        public int Radius { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape(); not allowed because it's abstract

            var circle = new Circle();
            var rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();

            // You can create a derived class based on a class that derives from another class.
            var oval = new Oval();
            
        }
    }
}
