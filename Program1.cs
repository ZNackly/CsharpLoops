using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
    {

        static void Main(string[] args)
        {
            int col = 0;
            int sum = 0;
            string ok = null;
            while (sum < 100)
            {
                sum += int.Parse(Console.ReadLine());
                col++;
            }
            if (col % 10 == 2 || col % 10 == 3 || col % 10 == 4)
            {
                ok = "ла";
            }else if(col % 10 == 1)
            {
                ok = "ло";
            }
            else
            {
                ok = "eл";
            }
                Console.WriteLine($"Было введено {col} чис{ok}. Сумма чисел {sum}");
        }
    }

