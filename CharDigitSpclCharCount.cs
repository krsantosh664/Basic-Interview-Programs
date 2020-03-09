// Write a program in C# to count a total number of alphabets, digits and special characters in a string. 
//Test Data :
//Enter string: Welcome to Microsoft 1
//Expected Output :
//Number of characters - 18 
//Number of digits - 1 
//Number of Special Characters - 3 


using System;

namespace interview
{
    class test
    {


        public static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Enter string-1");
            str1 = Console.ReadLine();
            int alpha = 0, digit = 0, spcl = 0;

            for(int i=0;i<str1.Length;i++)
            {
                if (str1[i] >= 'a' && str1[i] <= 'z' || str1[i] >= 'A' && str1[i] <= 'Z')
                    alpha++;
                else if (str1[i] >= '0' && str1[i] <= '9')
                    digit++;
                else
                    spcl++;
            }

            Console.WriteLine("Number of characters - {0}",alpha);
            Console.WriteLine("Number of digits - {0}",digit);
            Console.WriteLine("Number of Special Characters - {0}",spcl);


        }
    }
}
