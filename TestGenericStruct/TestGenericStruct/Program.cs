using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenericStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //b
            Pair<string, int> pairFirst = new Pair<string, int>("Anders", 13);
            //c
            Pair<string, double> pairSecond = new Pair<string, double>("Phoenix", 39.7);
            //d
            //You can not assign value type Pair<string, int> to a pair<string, double> ->
            //Pair<string, double> tryToAssign = pairFirst;
            //g
            //yes, you can assign a value of type Pair to a variable type Pair.
            Pair<Pair<string, int>, int> pairThird = new Pair<Pair<string, int>, int>(pairFirst, 6);
            Pair<Pair<string, int>, string> appointment = new Pair<Pair<string, int>, string>(pairFirst, "local GP");
            Console.WriteLine();
            Console.WriteLine(pairThird);
            //e,f
            Console.WriteLine("Pair array elements:");
            Pair<string, double> firstPerson = new Pair<string, double>("Andrew", 2.1);
            Pair<string, double> secondPerson = new Pair<string, double>("Andrew", 2);
            Pair<string, double> thirdPerson = new Pair<string, double>("Andrew", 3);
            Pair<string, double> fourthPerson = new Pair<string, double>();
            Pair<string, double> fifthPerson = new Pair<string, double>();
            Pair<string, double>[] grades = new Pair<string, double>[5] { firstPerson, secondPerson, thirdPerson, fourthPerson, fifthPerson };
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
                //if there is no value assigned it gives a null and a 0 to the double
            }
            Console.WriteLine();
            Console.WriteLine(pairFirst.Swap());
            Console.ReadLine();
        }
    }

    public struct Pair<T, U>
    {
        public readonly T Fst;
        public readonly U Snd;
        public Pair(T fst, U snd)
        {
            this.Fst = fst;
            this.Snd = snd;
        }

        public override string ToString()
        {
            return "("+ Fst + ", " + Snd + ")";
        }
        //h
        public Pair<U, T> Swap()
        {
            return new Pair<U, T>();
        }
    }
}
