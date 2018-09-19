using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S4E1___Design_a_Stack
{
    public class Stack
    {
        private ArrayList StackItems = new ArrayList();

        public void Push (object obj)
        {
            if (obj != null) StackItems.Add(obj);
            else throw new InvalidOperationException();
        }

        public object Pop()
        {
            if (StackItems.Count == 0)
                throw new InvalidOperationException("There are no items in the stack yet.");

            var returnable = StackItems[StackItems.Count-1];
            StackItems.RemoveAt(StackItems.Count - 1);

            return returnable;
        }

        public void Clear() => StackItems.Clear();
    }
}
