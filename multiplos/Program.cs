using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Multiplos de 3 e 5 - avaliação de teste");

            for (var i = 1; i <= 100; i++)
            {
                Console.Write(i);
                if (i % 3 == 0)
                {
                    Console.Write("ROBSON");
                }

                if (i % 5 == 0)
                {
                    Console.Write("JUNIOR");
                }
                Console.WriteLine("  ");
            }
            Console.ReadKey();
        }
    }
}