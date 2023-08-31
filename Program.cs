using System;

namespace StringReplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            string original, search, replace, final;

            Console.Write("Enter a string: ");
            original = Console.ReadLine();

            Console.Write("Enter search string: ");
            search = Console.ReadLine();

            Console.Write("Enter replacement string: ");
            replace = Console.ReadLine();

            final = original.Replace(search, replace);

            Console.WriteLine($"The result is: {final}");
        }
    }
}
