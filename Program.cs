using System;
using System.Text.RegularExpressions;

namespace Method_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name"); //asks user for name 
            string input = Console.ReadLine();
            bool ans = Regex.IsMatch(input, @"^[a-zA-z]+$");
            if (ans)
            {
                Hello(input);
            }
            else
            {
                Console.WriteLine("Please input a name without numbers");

            }
            
        }

        static void Hello(string input)
        {

            Console.WriteLine("Hello " + input + "!");

            

        }
    }
}
