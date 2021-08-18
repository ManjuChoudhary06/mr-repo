using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class demo3
    {
        static void Main()
        {
            int[] n = new int[3];
            for (int i=10; i<n.Length;i++)
            {
                Console.Write("Enter n[{0}] value:", i);
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int k in n)
                Console.WriteLine(k + "\t");
        }
    }
}
