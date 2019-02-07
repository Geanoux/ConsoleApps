using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resources;
using Resources_2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            int i1 = ConsoleInput.getIntegerFromConsole("enter first integer");
            //int i2 = ConsoleInput.getIntegerFromConsole("enter second integer", 10);

            //string s1 = ConsoleInput.getStringFromConsole("enter words");
            //char c0 = ConsoleInput.getCharFromConsole("enter char");

            ShowHello.ShowHello1();
            
           // Console.WriteLine(i2);
            Console.ReadLine();
        }
    
     
    }
}
