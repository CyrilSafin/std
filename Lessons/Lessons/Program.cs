using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numinrow
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine()), Y = int.Parse(Console.ReadLine()), a = 0;

            for (int i = 0; i < Y; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    Console.Write(a + " ");
                    a++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
