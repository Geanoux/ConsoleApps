using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "../../input.txt";
            using (StreamReader sr = new StreamReader(filepath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

                Console.ReadLine();
        }
    }
}
