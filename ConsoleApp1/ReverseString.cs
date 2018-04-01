using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReverseString
    {
        public void StringReverse()
        {
            string Str, reverseString = "";
            int Length;
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();
            Length = Str.Length - 1;
            while (Length >= 0)
            {
                reverseString = reverseString + Str[Length];
                Length--;
            }
            Console.WriteLine("Reverse  String  Is  {0}", reverseString);
            Console.ReadLine();
        }
    }
}
