using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            // there are type safety issues with ArrayList. It takes an object as an argument, so you can add any...

            // Boxing essentially occurs above because you are boxing an 'int' 999 as an object with Add
            list.Add(999);

            list.Add("Josh");
            list.Add(DateTime.Now);

            // This typeSafeList will ONLY allow for ints to be added
            var typeSafeList = new List<int>();

        }
    }
}
