using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMethods
{
    public class B
    {
        public static void SM()
        {
            Console.WriteLine("Hello from B.SM()");
        }

        public virtual void VIM()
        {
            Console.WriteLine("Hello from b.VIM()");
        }

        public void NIM()
        {
            Console.WriteLine("Hello from b.NIM()");
        }

    }
}
