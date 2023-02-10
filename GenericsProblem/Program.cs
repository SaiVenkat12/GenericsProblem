using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generics Problem");
            Console.WriteLine("Max Value");
            FindMax maxValue= new FindMax();
            Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxNumber(21, 14, 15));
            Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxNumber(12, 90, 15));
            Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxNumber(12, 14, 25));
        }
    }
}
