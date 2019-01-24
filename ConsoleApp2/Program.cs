using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "12345678!";

            printCharsInSeparateLine(s1);
            printCharsInReverseOrder(s1);
            printCharsMixedWay(s1);

            Console.ReadLine();
        }


        /// <summary>
        /// See meetod prindib stringi iga tahe uuele reale
        /// </summary>
        /// <param name="input">Sisendparameeter</param>
        static void printCharsInSeparateLine(string input) {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }

        /// <summary>
        /// kirjutab tahed kahes reas
        /// </summary>
        /// <param name="input"></param>
        static void printCharsInReverseOrder(string input) {
            for (int i = input.Length - 1; i >= 0; i--) {
                Console.WriteLine(input[i]);
            }
        }
        static void printCharsMixedWay(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + "   " + input[input.Length - i - 1]);
            }
        }
    }
}
