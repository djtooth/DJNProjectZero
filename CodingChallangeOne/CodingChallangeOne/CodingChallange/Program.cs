using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            PEvaluator tester = new PEvaluator();
            string s1 = "Race", s2 = "Racecar", s3 = "1e3e1";

            Console.WriteLine(tester.Palindrome(s1));
            Console.WriteLine(tester.Palindrome(s2));
            Console.WriteLine(tester.Palindrome(s3));
            Console.ReadKey();
        }



    }


    public class PEvaluator
    {
        public string StringReverse(string s1)
        {
            string s2 = "";
            for (int i = s1.Length; i > 0; i--)
                s2 += s1[i-1];
            return s2;
        }

        public bool Palindrome(string s1)
        {
            return (s1.ToLower() == StringReverse(s1.ToLower()));
        }

    }
}
