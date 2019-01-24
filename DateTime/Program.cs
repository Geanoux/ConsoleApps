using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTimeOffset dt1 = new DateTime;
            DateTime dt1 = DateTime.Now;

            int dayOfWeek = 4;

            string result; //= getDayAsString(dayOfWeek);
            //result = getDayAsString2(dayOfWeek);
            //result = getDayAsString3(dayOfWeek);

            result = getDayAsString3(5);
            Console.WriteLine(result);
           // Console.WriteLine("Tana on " + dt1.ToString("dddd") + ", " + dt1.ToString("d.MMMM"));
            Console.ReadLine();
        }

        private static string getDayAsString3(int dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    return "";
            }
        }

        private static string getDayAsString2(int dayOfWeek)
        {
            string[] dateArr = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday",
                "Friday", "Saturday", "Sunday" };

            return dateArr[dayOfWeek-1];
        }

        static string getDayAsString(int input)
        {
            if (input == 1) { return "Monday"; }
            else if (input == 2) { return "Tuesday"; }
            else if (input == 3) { return "Wednesday"; }
            else if (input == 4) { return "Thursday"; }
            else if (input == 5) { return "Friday"; }
            else if (input == 6) { return "Saturday"; }
            else if (input == 7) { return "Sunday"; }
            else return "";
        }
    }
}
