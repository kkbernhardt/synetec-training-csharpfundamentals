using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            B.SM();
            C.SM();
          
            C c1 = new C();
            B b = c1;
            C c = c1;

            b.VIM();
            b.NIM();
            c.VIM();
            c.NIM();
            Console.ReadLine();
        }
    }
}
