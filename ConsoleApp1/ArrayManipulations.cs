using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayManipulations
    {
        public void FindLargeNumber() {
            int largestNumber = 0;
                      
            int[] array = new int[5];
            Console.WriteLine("Enter the size of array:");
            int length = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter the number:");
                array[i] = Convert.ToInt16(Console.ReadLine());
            }

            largestNumber = array[0];
            foreach (var number in array) {
                if (number > largestNumber) {
                    largestNumber = number;
                }
            }

            Console.WriteLine("largest Number: {0}", largestNumber);
            Console.ReadLine();
        }
    }
}
