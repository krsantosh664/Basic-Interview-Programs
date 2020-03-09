using System;

namespace Interview
{
    class Test
    {


        public static void Main(string[] args)
        {
            string str;
            int count = 0;
            Console.WriteLine("Enter String to be Printed");
            str = Console.ReadLine();

	//Using for loop
            for(int i=0;i<str.Length;i++)
            {
                Console.Write(str[i]);
            }

            Console.Write("\n");

	//Using foreach loop
            foreach(char ch in str)
            {
                Console.Write(ch);
            }

            Console.Write("\n");

	//Using While loop
            while(count<str.Length)
            {
                Console.Write(str[count]);
                count++;
            }

        }
    }
}
