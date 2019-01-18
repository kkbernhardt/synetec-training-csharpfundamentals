using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystemCGeneric
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<double> temperatures = new List<double>();
            temperatures.Add(11);
            temperatures.Add(14);
            temperatures.Add(22);
            temperatures.Add(25);
            temperatures.Add(29);
            temperatures.Add(30.5);
            double min = 15;

            //11
            Console.WriteLine("Return number of temperatures from list that are equal or exceed 25:");
            BiggerThanOrEqualTo25Degrees(temperatures);
            Console.WriteLine("Return number of temperatures from list that are equal or greater to {0}:", min);
            Console.WriteLine(GreaterCount(temperatures, min));
            Console.WriteLine();
            //12
            double[] genericTemperatures = { 13, 12.5, 32.8, 40};
            Console.WriteLine("Return number of temperatures from array that are equal or greater to {0}", min);
            Console.WriteLine(GreaterCount(genericTemperatures, min));
            //can not call the method on int[] as I declared IEnumerable<double> previously
            Console.WriteLine("Return number of temperatures from list that are equal or greater to {0}", min);
            Console.WriteLine(GreaterCount(temperatures, min));
            List<string> words = new List<string>() {"a", "b", "c", "e", "f", "d"};
            string wordMin = "d";
            Console.WriteLine("Return 1, 0 or -1 if words from list alphabetically bigger, equal or smaller compared to '{0}'", wordMin);
            Console.WriteLine(GreaterCount(words, wordMin));
            //13
            int[] genericTemperaturesWholeNums = { 12, 14, 16, 22 };
            int minInteger = 17;
            Console.WriteLine("Greater than {0} using generic types:",min);
            Console.WriteLine(GreaterCount<double>(temperatures, min));
            Console.WriteLine();
            Console.WriteLine(GreaterCount<int>(genericTemperaturesWholeNums, minInteger));
            Console.WriteLine();
            Console.WriteLine(GreaterCount<string>(words, wordMin));
            Console.ReadLine();
        }
        //11
        public static void BiggerThanOrEqualTo25Degrees(List<double> temperatures)
        {
            int counter = 0;
            foreach (int temperature in temperatures)
            {
                if (temperature >= 25)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }

        public static int GreaterCount(List<double> temperatures, double min)
        {
            int counter = 0;
            foreach (var temperature in temperatures)
            {
                if (temperature >= min)
                {
                    counter++;
                }
            }
            return counter;
        }

        //12
        public static int GreaterCount(IEnumerable<double> eble, double min)
        {
            int counter = 0;
            foreach (var item in eble)
            {
                if (item >= min)
                {
                    counter++;
                }
            }
            return counter;
        }
    
        public static int GreaterCount(IEnumerable<string> eble, string min)
        {
            int comparing = 0;
            foreach (string item in eble)
            {
                comparing = item.CompareTo(min);
                Console.WriteLine(comparing);
            }
            return comparing;
        }
        //13
        public static int GreaterCount<T>(IEnumerable<T> eble, T x) where T : IComparable<T>
        {
            int compared = 0;
            foreach (var item in eble)
            {
                compared = item.CompareTo(x);
                Console.WriteLine(compared);
            }
            return compared;
        }
    }
}
