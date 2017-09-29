using System;

namespace Microsoft_excercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StrShift example = "Microsoft";
            StrShift result = example << 1 << 2;
            StrShift result2 = example >> 1;



            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
