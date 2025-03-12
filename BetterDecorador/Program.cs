using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            char symbol = char.Parse(args[1]);
            int num = int.Parse(args[2]);

            Decor(args[0], symbol, num);
            Console.WriteLine(Decor(args[0], symbol, num));

        }

        private static string Decor(string s, char dec, int i)
        {
            string conv = Convert.ToString(dec);

            for (int f = i - 1; f > 0; f--)
            {
                conv += dec;
            }

            return $"{conv} {s} {conv}";
        }
    }
}
