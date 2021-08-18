using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class HandsOnArrayDemo2
{ 
    static void Main()
    {
            int[] n = new int[4] { 12, 13, 14, 15 };
            char[] ch = new char[3] { 'a', 'b', 'c' };
            double[] prices = new double[4]
            {
                12.44,
                44.14,
                15.75,
                88.99
            };
            int[] number = { 12, 33, 14, 567, 32 };
            string[] flowers = new string[3]
            {
                "Rose",
                "Lilly",
                "Tulips"
            };
            foreach(string s in flowers)
            {
                if (s.Length > 4)
                    Console.WriteLine(s);
            }
        }
    }

