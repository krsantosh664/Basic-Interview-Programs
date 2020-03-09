//C# program to reverese words in a given string 
//Input : Santosh Kumar Yadav
//Output: Yadav Kumar Santosh


Program:

namespace Test28
{
    class program
    {
        
        public static void Main(String[] args)
        {
            String Str;
            Console.WriteLine("Enter Text whose words need to be reversed");
            Str = Console.ReadLine();

            String[] Words = Str.Split(' ');       //Split
            Array.Reverse(Words);                  //Reverse
            String text = String.Join(" ", Words);   //Join

            Console.WriteLine(text);                       
                   
        }
    }
}