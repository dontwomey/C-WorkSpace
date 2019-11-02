using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "TEstSEt";

            Console.WriteLine(isPallindrome1(word));
            Console.WriteLine(isPallindrome2(word));

        }

        private static bool isPallindrome2(string word)
        {
            word = word.ToLower();
            bool flag = true;
            
            for (int i = 0; i < word.Length / 2 ; i++){
                if (word[i] != word[word.Length - i - 1])
                {
                    flag = false;
                }
            }

            return flag;
        }

        private static bool isPallindrome1(string word)
        {
            char[] reversearr = word.ToCharArray();
            Array.Reverse(reversearr);
            string reverseword = new string(reversearr);

            if (word.ToLower() == reverseword.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
