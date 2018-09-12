using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            var rectangle = new Rectangle();

            circle.Draw();
            rectangle.Draw();
        }
    }
}
