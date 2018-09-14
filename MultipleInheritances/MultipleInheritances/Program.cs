using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritances
{
    // You can have multiple interfaces implemented
    public class TextBox : UiControl, IDraggable, IDroppable
    {
        // In inheritance, you inherit all code (UiControl, in this case). In interfaces, you must re-implement any code
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
    
        }
    }
}
