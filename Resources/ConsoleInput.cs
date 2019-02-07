using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public class ConsoleInput
    {
        public static int getIntegerFromConsole(string messageToShow)
        {
            Console.WriteLine(messageToShow);
            int result;
            try
            {
                result = Convert.ToInt16(Console.ReadLine());
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("  Invalid number");
                return getIntegerFromConsole(messageToShow);
            }
        }

        public static int getIntegerFromConsole(string messageToShow, int maximumIntegerValue)
        {
            Console.WriteLine(messageToShow);
            int result;
            try
            {
                result = Convert.ToInt32(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("invalid format");
                result = getIntegerFromConsole(messageToShow, maximumIntegerValue);
            }

            if (result < maximumIntegerValue)
            {
                return result;
            }
            else
            {
                Console.WriteLine("too big number");
                return getIntegerFromConsole(messageToShow, maximumIntegerValue);
            }
        }

        public static char getCharFromConsole(string messageToShow)
        {
            Console.WriteLine(messageToShow);
            string result = Console.ReadLine();
            return result[0];

        }

        public static string getStringFromConsole(string messageToShow)
        {
            Console.WriteLine(messageToShow);
            return Console.ReadLine();
        }

    }
}
