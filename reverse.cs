using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,n,d,s=0,c=0;
            System.Console.WriteLine("enter the no.");
            num = Convert.ToInt32(Console.ReadLine());
            n = num;
            while(n>0)
            {
                d = n % 10;
                s = s * 10 + d;
                n = n / 10;
            }
            Console.Write("revcerse number " + s);
        }
    }
}
