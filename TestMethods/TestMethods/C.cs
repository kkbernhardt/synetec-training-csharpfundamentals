using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    public class C : B
    {
        public new static void SM()
        {
            Console.WriteLine("Hi from C.SM()");
        }

        public override void VIM()
        {
            Console.WriteLine("Hi from C.VIM()");
        }

        public new void NIM()
        {
            Console.WriteLine("Hi from C.NIM()");
        }


    }
}
