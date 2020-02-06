using System;
using System.Text.RegularExpressions;

namespace Method_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name"); //asks user for name 
            string input = Console.ReadLine(); //assigns user input as the variable "input"
            bool ans = Regex.IsMatch(input, @"^[a-zA-z]+$"); //create bool variable named "ans" and checks it to make sure it is 
            //an a or A
            if (ans)
            {
                Hello(input); //if the input is made of up letters 
            }
            else
            {
                Console.WriteLine("Please input a name without numbers"); //if the input is not made of letters.

            }
            
        }

        static void Hello(string input) //this is the method
        {

            Console.WriteLine("Hello " + input + "!"); //thing the method does

            

        }
    }
}
