using System;
using System.Linq;

namespace HelloDelegate
{
    class Program
    {
        static Predicate<string> isUpperPred = s => s.All(char.IsUpper);
        static Func<string, bool> isUpperFunc = s => s.All(char.IsUpper);

        static bool Is(Predicate<string> p, string input)
        {
            //Comment 19 & 20

            return p(input);
        }

        static void PrintIsUpper(string input)
        {
            Console.WriteLine($"{input} isUpper: {Is(isUpperPred, input)}");
            #if uncompilable
            //Cannot pass a Func where a Predicate is expected
            Console.WriteLine($"{input} isUpper: {Is(isUpperFunc, input)}");
            #endif
        }
        static void Main(string[] args)
        {
            PrintIsUpper("Hello");
            System.Diagnostics.Debugger.Break();
            var id = Guid.NewGuid().ToString();
        }
    }
}
