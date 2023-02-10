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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Find Max Number \n2.Find Max Float \n3.Find Max String \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxValue(21, 14, 15));
                        Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxValue(12, 90, 15));
                        Console.WriteLine("The Greatest Number is {0}", maxValue.FindMaxValue(12, 14, 25));
                        break;
                    case 2:
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxValue(21.5f, 14.9f, 15));
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxValue(12, 90, 15.3f));
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxValue(12, 14, 25.1f));
                        break;
                    case 3:
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxValue("Apple", "Peach", "Banana"));
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxValue("Apple", "Banana", "WaterMelon"));
                        Console.WriteLine("The Greatest Value is {0}", maxValue.FindMaxValue("Xray", "Banana", "Peach"));
                        break;
                    case 22:
                        flag= false;
                        break;
                    default:
                        Console.WriteLine("Enter the Correct Number !");
                        break;

                }
            }
                        
        }
    }
}
