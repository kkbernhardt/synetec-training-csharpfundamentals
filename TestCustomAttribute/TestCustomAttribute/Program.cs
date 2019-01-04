using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestCustomAttribute
{
    class Program
    {
        //2.8
        static void Main(string[] args)
        {
            Console.WriteLine("Information about our program:");
            var assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine(assembly.FullName);
            Console.WriteLine();
            Console.WriteLine("Classes or assemblies in our program:");
            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine("Type: " + type.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Methods and their attributes in our Example class:");
            Type sampleType = typeof(Example);
            var methodNames = sampleType.GetMethods().Where(m => m.GetCustomAttributes<BugFixedAttribute>().Count() > 0);
            foreach (var item in methodNames)
            {
                Console.WriteLine(item.Name);
                object[] customAttributesNames = item.GetCustomAttributes(typeof(BugFixedAttribute), false);
                foreach (var attribute in customAttributesNames)
                {
                    Console.WriteLine(attribute);
                }
            }
            Console.ReadLine();
        }
    }

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class BugFixedAttribute: Attribute
    {
        public int ReportNum { get; set; }
        public string BugDescription { get; set; }
        public BugFixedAttribute(int reportNum, string bugDescription)
        {
            ReportNum = reportNum;
            BugDescription = bugDescription;
        }

        public BugFixedAttribute(string bugDescription)
        {
            ReportNum = -1;
            BugDescription = bugDescription;
        }
        
        public override string ToString()
        {
            string message = "";
            if (ReportNum > 0)
            {
                message = "Bugnumber: " + ReportNum +", "+ "Description: " + BugDescription;
            }
            else
            {
                message = "Description: " + BugDescription;
            }
            return message;
        }
    }
    class Example
    {
        [BugFixed(4, "Performance: Uses SortedDictionary")]
        [BugFixed(3, "Throws IndexOfOutRangeException on empty array")]
        [BugFixed("Performance: Uses repeated string concatenation in for-loop")]
        [BugFixed(2, "Loops forever on one-element array")]
        [BugFixed(1, "Spelling mistakes in output")]
        public static string PrintMedian(int[] xs)
        {
            /* ... */
            return "";
        }
        [BugFixed(67, "Rounding error in quantum mechanical simulation")]
        public double CalculateAgeOfUniverse()
        {
            /* ... */
            return 11.2E9;
        }
    }
}
