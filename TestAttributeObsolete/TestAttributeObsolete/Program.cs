using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAttributeObsolete
{
    class Program
    {
        static void Main(string[] args)
        {
            //there is a warning saying it is an obsolete method but it does compile
            AcousticModem();
            AcousticModem("updated method");
            Console.ReadLine();
        }
        [Obsolete("Use updated method with parameter instead this", false)]
        static void AcousticModem()
        {
            Console.WriteLine("beep buup baap bzfttfsst %^@~#&&^@CONNECTION LOST");
        }
        static void AcousticModem(string name)
        {
            Console.WriteLine("beep buup baap bzfttfsst %^@~#&&^@CONNECTION LOST: " + name);
        }
    }
}
