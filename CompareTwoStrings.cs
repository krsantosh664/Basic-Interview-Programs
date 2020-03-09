//C# program to compare two string without using string library functions. 
//Test Data :
//Enter String 1 : This is first string
//Enter String 2 : This is first string
//Expected Output :
//Both Strings are same

Program:
using System;


namespace Test28
{
    class program
    {
        public static void Main(String[] args)
        {
            String str1, str2;
            int flag = 1;
            Console.WriteLine("Enter String 1");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter String 2");
            str2 = Console.ReadLine();

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        Console.WriteLine("Both strings are not same");
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine("Both Strings are same");
                }
                
            }
            else
            {
                Console.WriteLine("Count of both strings are different and cannot be same");
            }
        }
    }
}






