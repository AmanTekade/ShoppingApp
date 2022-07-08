using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Deligate
{
    class basic
    {
        public delegate void del1(); // declaring delegate
        public static void print()
        {
            Console.WriteLine("we are in delegate...");
        }
        static void Main(string[] args)
        {
        //    del1 d1 = new del1(print); // making instance of delegate
            d1.Invoke(); //invoking the method
            Console.ReadLine();
        }
    }
}
