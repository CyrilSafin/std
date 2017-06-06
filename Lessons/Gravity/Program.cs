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

            char[,] arr = new char[width, height];
            for (int j = 0; j < width; j++)
            {
                string line = Console.ReadLine();
                
                for (int i = 0; i < height; i++)
                {
                    arr[i, j] = line[i];//.GetTypeCode();//.ToString();
                }
            }
            

            for (int i = 0; i < width; i++)
            {
                bool exit = true;
                do
                {
                    for( int j=0;j<height-1;j++)
                    {
                        if (arr[i, j] == '#')
                        {
                            if (arr[i, j + 1] == '.')                             { arr[i, j] = '.'; arr[i, j + 1] = '#';}
                        }
                    }
                    exit = false;
                }
                while (exit == true);
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(arr[j,i]);
                }
                Console.Write('\n');
            }

            
            Console.ReadKey();
        }
    }
}
