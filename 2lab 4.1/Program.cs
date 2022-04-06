using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_4._1
{
    class Program
    {
        public static void Main()
        {
            Vector v = new Vector();
            v.Read();
            v.Display();
            Console.WriteLine("Area: " + v.GetArea());
            Console.WriteLine("Perim: " + v.GetPerim());
            Console.ReadKey();

        }
    }
}
