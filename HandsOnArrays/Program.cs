using System;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            n[0] = 20;
            n[1] = 30;
            n[2] = 40;
            n[3] = 50;
            n[4] = 60;
            //n[5] = 70;
            int k = n[2];
            foreach (int i in n)
            {
                Console.WriteLine(i);
            }
        }
    }
}
