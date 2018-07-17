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
