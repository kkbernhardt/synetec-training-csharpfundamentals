using System;
using static TestTime.Time;

namespace TestTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Time firstTime = new Time(3, 50);
            Time secondTime = new Time(10, 5);
            Console.WriteLine(firstTime);
            Console.WriteLine(secondTime);
            Console.WriteLine();

            Time t1 = new Time(9, 30);
            Time t2 = t1;
            t1.minutes = 100;
            Console.WriteLine("t1 = {0} and t2 = {1}", t1, t2);
            //because it's a struct each different variable of the struct have their own value
            Console.WriteLine();

            Console.WriteLine("Using class instead of struct: ");

            Time2 t21 = new Time2(9, 30);
            Time2 t22 = t21;
            t21.minutes = 100;
            Console.WriteLine("t1 = {0} and t2 = {1}", t21, t22);
            //because if it's a class if we make a change on it it applies to all assigned variable

            Console.WriteLine();
            Console.WriteLine("Operator overloading:");
            Time t3 = new Time(2, 50);
            Time t4 = new Time(5, 15);
            Time t34 = t3 + t4;
            Console.WriteLine("Add two Time values together: {0}", t34);

            Time t5 = new Time(12, 5);
            Time t6 = new Time(20, 5);
            Time t56 = t5 - t6;
            Console.WriteLine("Subtract two Time values from each other: {0}", t56);
            Console.WriteLine();

            Console.WriteLine("Conversion:");
            int v2 = 100;
            Time timeImpl = v2;
            Console.WriteLine("Implicit conversion from int to Time with value: {0}", timeImpl);

            Time v = new Time(8, 50);
            int timeExpl = (int)v;
            Console.WriteLine("Explicit conversion Time to int with value: {0}", timeExpl);
            Time time3 = v + 56;
            Console.WriteLine(time3);
            Console.ReadLine();
        }
    }
    public struct Time
    {
        public int minutes;
        //possible to declare static field type: the struct, but not possible to declare non static field as it causes a cycle.
        private static Time noon;
        public int Hour { get; set; }
        public int Minute { get; set; }
        public Time(int hh, int mm)
        {
            minutes = 60 * hh + mm;
            Hour = hh;
            Minute = mm;
        }
        //an other constructor for using the +,- operators
        public Time(int t)
        {
            this.minutes = t;
            Hour = t / 60;
            //Minute = t - Hour * 60;
            Minute = t % 60;
        }
        public override string ToString()
        {
            string hoursAndMinutesFormat = String.Format("{0}:{1}", Hour, Minute);
            string minuteFormat = minutes.ToString();
            return hoursAndMinutesFormat + " is " + minuteFormat + " minutes in total after midnight.";
        }
        public static Time operator + (Time t1, Time t2)
        {
            int sumOfHours = t1.Hour + t2.Hour;
            int sumOfMinutes = t1.Minute + t2.Minute;
            if (sumOfMinutes >= 60)
            {
                sumOfHours += sumOfMinutes / 60;
            }
            return new Time(sumOfHours, sumOfMinutes % 60);
        }
        public static Time operator - (Time t3, Time t4)
        {
            return new Time(t3.Hour - t4.Hour, t3.Minute - t4.Minute);
        }

        public static implicit operator Time(int v2)
        {
            return new Time(v2);
        }

        public static explicit operator int(Time v)
        {
            int timeExpl = v.minutes;
            return timeExpl;
        }
    }
    public class Time2
    {
        public int minutes;
        private Time2 time;
        public int Hour { get; set; }
        public int Minute { get; set; }
        public Time2(int hh, int mm)
        {
            minutes = 60 * hh + mm;
            Hour = hh;
            Minute = mm;
        }

        public override string ToString()
        {
            string hoursAndMinutesFormat = String.Format("{0}:{1}", Hour, Minute);
            string minuteFormat = minutes.ToString();
            return hoursAndMinutesFormat + " is " + minuteFormat + " minutes in total after midnight.";
        }
    }
}
