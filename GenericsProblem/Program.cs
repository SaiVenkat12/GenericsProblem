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
            List<int> listNo = new List<int> { 90, 1, 56, 88, 4, 23, 7 };
            List<float> listfloat = new List<float> { 22,3.3f,12.9f,99.234f,1,67.85f};
            List<string> listString = new List<string> { "apple", "banana", "xray", "peach", "WaterMelon" };
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Find Max Number \n2.Find Max Float \n3.Find Max String \n4.Sort Int Find Max \n5.Sort float Find Max \n6.Sort string Find Max \n22.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("The Greatest Number is {0}", FindMax<int>.FindMaxValue(21, 14, 15));
                        Console.WriteLine("The Greatest Number is {0}", FindMax<int>.FindMaxValue(12, 90, 15));
                        Console.WriteLine("The Greatest Number is {0}", FindMax<int>.FindMaxValue(12, 14, 25));
                        break;
                    case 2:
                        Console.WriteLine("The Greatest Value is {0}", FindMax<float>.FindMaxValue(21.5f, 14.9f, 15));
                        Console.WriteLine("The Greatest Value is {0}", FindMax<float>.FindMaxValue(12, 90, 15.3f));
                        Console.WriteLine("The Greatest Value is {0}", FindMax<float>.FindMaxValue(12, 14, 25.1f));
                        break;
                    case 3:
                        Console.WriteLine("The Greatest Value is {0}", FindMax<string>.FindMaxValue("Apple", "Peach", "Banana"));
                        Console.WriteLine("The Greatest Value is {0}", FindMax<string>.FindMaxValue("Apple", "Banana", "WaterMelon"));
                        Console.WriteLine("The Greatest Value is {0}", FindMax<string>.FindMaxValue("Xray", "Banana", "Peach"));
                        break;
                    case 4:
                        Console.WriteLine("Maximum Value = " + Sort<int>.FindMaxList(listNo));
                        break;
                    case 5:
                        Console.WriteLine("Maximum Value = " + Sort<float>.FindMaxList(listfloat));
                        break;
                    case 6:
                        Console.WriteLine("Maximum Value = " + Sort<string>.FindMaxList(listString));
                        break;                                      
                    case 22:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter the Correct Number !");
                        break;

                }
            }

        }
    }
}
