using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<double> action = PrintElement;
            Console.WriteLine("Print variable number of parameters: ");
            Perform(PrintElement, 4.6, 6, 7.5, 0, 9, 23);
            Perform(PrintElement, "one", "two", "three");
            Perform(PrintElement, 1, 3, 6, 2);
            Console.ReadLine();
        }
        public delegate void Action<T>(T arg);

        public static void PrintElement<T>(T num)
        {
            Console.WriteLine("Element in the delegate: {0}", num);
        }
        public static void Perform<T>(Action<T> act, params T[] arr)
        {
            foreach (var element in arr)
            {
                act(element);
            }
        }
    }
}
