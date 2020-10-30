using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celtofah
{
    class Program
    {
        static void Main(string[] args)
        {
            //int cel, fah;
            //Console.Write("Enter the tep in cel : ");
            //cel = int.Parse(Console.ReadLine()); ;
            //fah = (cel * 9) / 5 + 32;
            //Console.WriteLine("Temp in fah : " + fah.ToString());

            bool res;
            int a;
            string myStr = "120";
            res = int.TryParse(myStr, out a);
            Console.WriteLine("String is a numeric representation: " + res);
            Console.ReadLine();
        }
    }
}
