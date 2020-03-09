//C# program to count the total number of words in a string. 

//Input the string : My name is santosh

//Total number of words in the string is : 4 


using System;

namespace LearningProgram
{
    class InterviewProgram
    {
        static void Main(String[] args)
        {
            String Str;
            int Len = 0;
            int Word = 1;
            
            Console.WriteLine("Input the String:");
            Str = Console.ReadLine();           
            
           
	for(int i = 0;i<str.Length;i++)
            {
                if (str[i] ==' ' || str[i] == '\n' || str[i] == '\t')
                    word++;
            }
            Console.WriteLine("Total number of words in the String: {0}", Word);

        }
    }
}