using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 0;
            while (Math.Pow(2, k) <= n)
            {
                k++;
            }
            Console.WriteLine(Math.Pow(2, k));
        }
    }
}
