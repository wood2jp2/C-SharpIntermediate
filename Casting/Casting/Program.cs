using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{

    class Program
    {
        static void Main(string[] args)
        {
            //     Text text = new Text();

            //     You can easily cast an object to its base class, (a Text instance to Shape, in this case) 
            //      BOTH text AND shape are references to the same object in memory but different views.
            //      Views as in what it can access ('shape' can only reference shape things, while text can reference that AND text things)
            //     Shape shape = text;

            // Shape actually changes the text.Width here to 100, (think of an object referencing a field within another object in JS.
            //text.Width = 200;
            //     shape.Width = 100;

            //     Console.WriteLine(text.Width);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Part 2: 

            // StreamReader takes an argument of any Stream object. So things like MemoryStream or FileStream are automatically upcast
            //StreamReader reader = new StreamReader(new MemoryStream());

            // ArrayList is NOT type-safe, and we may get exceptions thrown.
            // The point here is that object class is the parent of all classes in .NET framework, so all below types
            // are once again upcast to an 'object' 
            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Josh");
            //list.Add(new Text());

            //var anotherList = new List<Shape>();


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// Downcasting

            Shape shape = new Text();
            Text text = (Text)shape;
            // With text, you have access to all Shape props as well as the Text properties.

        }
    }
}
