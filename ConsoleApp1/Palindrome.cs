using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Palindrome
    {
        public void CheckPalindrome()
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
            //Console.WriteLine("Reverse  String  Is  {0}", reverseString);
            if (Str.Replace(" ", "") == reverseString.Replace(" ", ""))
            {
                Console.WriteLine("Given  String  Is  Palindrome");
            }
            else {
                Console.WriteLine("Given  String  Is  Not Palindrome");
            }
            Console.ReadLine();
        }
    }
}
