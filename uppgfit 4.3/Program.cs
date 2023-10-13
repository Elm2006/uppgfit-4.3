using System;
namespace uppgift_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Detta är en liten text";
            for(int i = text.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine(text[i]);
            }
            Console.ReadKey();  
        }
    }
}