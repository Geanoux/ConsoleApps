using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Harjutus
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool b1;
            b1 = true;

            int int1 = getBiggestNumber(100, 20);
             b1 = isFirstNumberBiggerThanSecond(10, 29);


            Console.WriteLine("b1 value: " + b1);
            Console.Read();
        }

        static int getBiggestNumber(int i1, int i2) {
            if (i1 > i2) {
                return i1;
            } else {
                return i2;

            }

        }
        static bool isFirstNumberBiggerThanSecond(int i3, int i4) {
            if (i3 > i4) {
                return true;
            }
            else {
                return false;
            }
        }
    }

}
