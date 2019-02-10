using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            // boxing
            object o = i;

            // unboxing
            int sol = (int)o;

            Console.WriteLine("Value of integer: {0}", i.ToString());
            Console.WriteLine("Value of integer after boxing and unboxing: {0}", sol.ToString());
        }
    }
}
