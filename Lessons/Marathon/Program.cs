using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    class Solution
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int min = 0, x;
            
            string[] time;

            for (int i = 0; i < N; i++)
            {
                time = Console.ReadLine().Split(':');
                int h = int.Parse(time[0]);
                int m = int.Parse(time[1]);
                int s = int.Parse(time[2]);

                x=((h*60+m)*60)+s;

                if (min != 0)
                {
                    if (x < min) { min = x; }
                }
                else { min = x; }
            }
            int a=min/3600;
            int b=(min-a*3600)/60;
            int c=min-(a*3600+b*60);

            Console.Write(a+":"+b+":"+c);
            Console.ReadKey();
        }
    }
}