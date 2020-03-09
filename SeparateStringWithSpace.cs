//C# program to separate the individual characters from a string with empty space. 
using System;

namespace interview
{
    class test
    {


        public static void Main(string[] args)
        {
            string str;            
            Console.WriteLine("Enter String to be Printed");
            str = Console.ReadLine();
        
            foreach(char ch in str)
            {
                Console.Write(ch + " ");
            }      

        }
    }
}
