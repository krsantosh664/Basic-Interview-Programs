//C# program to reverse each word of string separately
//Input :    My name is santosh
//Output:    yM eman si hsotnas


Program:
namespace Interview
{
    class Program
    {
        
        public static void Main(String[] args)
        {
            String Str;
            Console.WriteLine("Enter Text whose words need to be reversed");
            Str = Console.ReadLine();

            string strrev = "";

            foreach (var word in Str.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                strrev = strrev + temp + " ";
            }
            Console.WriteLine(strrev);
            
        }
    }
}