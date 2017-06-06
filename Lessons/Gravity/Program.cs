using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int width = int.Parse(inputs[0]);
            int height = int.Parse(inputs[1]);

            char[,] matrix = new char[width, height];

            for (int y = 0; y <height ; y++)
            {
                string line = Console.ReadLine();

                for (int x = 0; x < width; x++)
                {
                    matrix[x, y] = line[x];
                }
            }

            char[] sort = new char[height];


            for (int x = 0; x < width; x++)
            {
                for (int i = 0; i < height; i++)
                {
                    sort[i] = matrix[x, i];
                }

                Array.Sort(sort);
                Array.Reverse(sort);

                for (int i = 0; i < height; i++)
                {
                    matrix[x, i]=sort[i]; 
                }
            }

          
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(matrix[x, y]);
                }
                Console.Write('\n');
            }

            Console.ReadKey();
        }
    }
}
