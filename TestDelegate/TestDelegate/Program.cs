using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDelegate
{
    public class Program
    {
        public delegate void IntAction(int num);
        //Declare a method with the same signature as the delegate
        public static void PrintInt(int num)
        {
            Console.WriteLine("Number in the parameter: {0}", num);
        }
        public static void Perform(IntAction act, int[] arr)
        {
            foreach (var item in arr)
            {
                //calling the delegate
                act(item);
            }
        }
        //modified method which accepts a variable number of parameters
        public static void PerformDifferently(IntAction intAct, params int[] numbers)
        {
            foreach(var number in numbers)
            {
                intAct(number);
            }
        }
        static void Main(string[] args)
        {
            //create an istance of the delegate
            IntAction intAction = PrintInt;

            intAction(42);

            Console.WriteLine("Print array elements:");
            int[] arr = { 1, 3, 6, 2 };
            Perform(PrintInt, arr);

            Console.WriteLine("Print variable number of parameters: ");
            PerformDifferently(PrintInt, 4, 6, 7, 0, 9, 23);

            Console.ReadLine();
        }
    }
}
