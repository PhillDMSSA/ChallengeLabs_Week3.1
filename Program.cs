using System.Security.Cryptography.X509Certificates;

namespace ChallengeLabs_Week3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to see if it is a palindrome: ");
            string input = Console.ReadLine();

            

            if (Palindrome(input))
            {
                Console.WriteLine($"'{input}' is a palindrome.");
            }
            else
            {
                Console.WriteLine($"'{input}' is not a palindrome.");
            }
        

        }

        static public bool Palindrome(string input)
        {

           int length = input.Length;

            for(int i = 0; i < input.Length / 2; i++)  
            {
               if (input[i] != input[length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
