using System;
using System.Linq;

namespace HelloDelegate
{
    class Program
    {
        static Predicate<string> isUpperPred = s => s.All(char.IsUpper);
        static Func<string, bool> isUpperFunc = s => s.All(char.IsUpper);

        static bool IsUpperPred(Predicate<string> p, string input)
        {
            //Comment 2
            //Comment 3
            //Comment 4
            //Comment 5
            //Comment 6
            //Comment 7 and 8
            //Comment 9 and 10
            //Comment 11 & 12
            //Comment 13 & 14
            return p(input);
        }

        static void PrintIsUpper(string input)
        {
            Console.WriteLine($"{input} isUpper: {IsUpperPred(isUpperPred, input)}");
            #if uncompilable
            //Cannot pass a Func where a Predicate is expected
            Console.WriteLine($"{input} isUpper: {IsUpperPred(isUpperFunc, input)}");
            #endif
        }
        static void Main(string[] args)
        {
            PrintIsUpper("Hello");
        }
    }
}
