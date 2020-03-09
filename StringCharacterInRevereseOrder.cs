//Write a program in C# Sharp to print individual characters of the string in reverse order.
using System;

namespace interview
{
    class test
    {


        public static void Main(string[] args)
        {
            string str, rev;
            
            Console.WriteLine("Enter String to be Printed");
            str = Console.ReadLine();
            int len = str.Length-1;
            
//Using While
            while(len>=0)
            {
                Console.Write(str[len]);
                len--;
            }

            Console.WriteLine();

//Using For loop
            for(int i = str.Length - 1; i>=0;i--)
            {
                Console.Write(str[i]);
            }         
            

        }
    }
}
