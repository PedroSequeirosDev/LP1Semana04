﻿using System;

namespace BetterDecorador
{
    /// <summary>
    /// This program add characters behind and after the string 
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method which receives the arguments
        /// uses the arguments in the Decor method
        /// and converts the arguments to the desired format
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(Decor());
            }
            else
            {
                char symbol = char.Parse(args[1]);
                int num = int.Parse(args[2]);

                Decor(args[0], symbol, num);
                Console.WriteLine(Decor(args[0], symbol, num));
            }


        }

        /// <summary>
        /// Decor method, which receives a string, a char and an int
        /// and returns an output with the desired formatting.
        /// it also converts the char into a string and multiplies 
        /// it by the value int
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        private static string Decor(string s, char dec, int i)
        {
            string con = Convert.ToString(dec);

            for (int f = i - 1; f > 0; f--)
            {
                con += dec;
            }

            return $"{con} {s} {con}";
        }
        /// <summary>
        /// Decor method, which returns a specific message when the user 
        /// does not specify what arguments are to be used
        /// </summary>
        /// <returns></returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);
        }
    }
}
