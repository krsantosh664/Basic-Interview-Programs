//C# program to find length of a string without using library function
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
            int len = 0;

            foreach(char ch in str)
            {
                len++;
            }

            Console.WriteLine("Length of string {0}", len);           

        }
    }
}
