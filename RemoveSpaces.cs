using System;

namespace Interview
{
    class RemoveNameSpaces
    {


        public static void Main(string[] args)
        {
            string str = "Sp ac es Rem ove d Suc cess full y";
            int len = str.Length;
            char[] temp = new char[len];
            int count = 0;

            for (int i = 0; i < len; i++)
            {
                if (str[i] != ' ')
                {
                    temp[count] = str[i];
                    count++;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write(temp[i]);
            }
        }
    }
}
