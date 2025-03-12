using System;
using System.Reflection.Metadata.Ecma335;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insert n-th number of the special sequence:");
            string s = Console.ReadLine();

            int num = int.Parse(s);
            Console.WriteLine(GetSpecial(num));
        }
        private static int GetSpecial(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return GetSpecial(n - 1) + GetSpecial(n - 2) * 2;

        }

    }
}
