using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace operaterExercise
{
    class Program
    {

        public static double AreaofCircle(double r)
        {
            double pi = 3.14;

            return pi * (r  * r);
        }


        static void Main(string[] args)
        {
            

            Console.WriteLine("what is the radius?");

            double r = Double.Parse(Console.ReadLine());

           var area = AreaofCircle(r);
            Console.WriteLine($"The area of your circle is {area}");


           


        }

    }
}
