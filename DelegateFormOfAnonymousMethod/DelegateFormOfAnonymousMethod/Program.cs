using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFormOfAnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IntList xs = new IntList(7, 9, 13, 24, 25, 28);
            xs.Act(Console.WriteLine);
            Console.WriteLine("Print only the even numbers of the IntList:");
            //this is an anonymus method:
            xs.Filter(delegate(int x)
            {
                return x % 2 == 0;
            })
                .Act(Console.WriteLine);
            Console.WriteLine("Prints the bigger or equal to 25 elements:");
            xs.Filter(delegate(int x)
            {
                return x >= 25;
            })
                .Act(Console.WriteLine);

            int sum = 0;
            xs.Act(delegate (int x)
            {
                sum += x;
                Console.WriteLine(sum);

            });
            Console.ReadLine();
        }
    }
    // Delegate types to describe predicates on ints and actions on ints.

    public delegate bool IntPredicate(int x);
    public delegate void IntAction(int x);

    // Integer lists with Act and Filter operations.
    // An IntList containing the element 7 9 13 may be constructed as 
    // new IntList(7, 9, 13) due to the params modifier.

    class IntList : List<int>
    {

        public IntList(params int[] elements) : base(elements) { }

        public void Act(IntAction f)
        {
            foreach (int i in this)
            {
                f(i);
            }
        }

        public IntList Filter(IntPredicate p)
        {
            IntList res = new IntList();
            foreach (int i in this)
            {
                if (p(i))
                {
                    res.Add(i);
                }
            }
            return res;
        }
    }
}
