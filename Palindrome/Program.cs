using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPalindrome;

            Console.WriteLine("Please input the string that you'd like to check if it's a palindrome: ");
            myPalindrome = Console.ReadLine();

            palindrome(myPalindrome);

        }

        static bool palindrome(string input)
        {
            // Reverse the string and check if it's equal
            string check = new string(input.Reverse().ToArray());

            if (check == input)
            {
                Console.WriteLine("palindrome!");

                return true;

            }
            else
            {
                Console.WriteLine("Not a palindrome!");

                return false;

            }
        }
    }
}
