using System;
using System.Text;

namespace Part1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to reverse:");
            string userInput = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            for(int i= userInput.Length - 1; i>=0;i--)
            {
                output.Append(userInput[i]);
            }
            Console.WriteLine(userInput + " reverse string is " + output.ToString());
        }
    }
}
