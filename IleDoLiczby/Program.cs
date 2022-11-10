using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleDoLiczby
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 1, b = 0, l = 100;
                                   

            while (a <= l)
            {
                                              

                a = (b + 1) + a;

                
                b++;

            }

            Console.WriteLine("Aby uzyskać liczbę " + l + " albo większą należy dodać " + b + " liczb poczynając od 1");
            Console.ReadKey();









        }
    }
}
