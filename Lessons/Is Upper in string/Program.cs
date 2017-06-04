using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_Upper_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string ans=string.Empty;
            
            char[] array = str.ToArray();

            foreach (var x in array)
            {
                if (65 <= x && x <= 90)
                {
                    ans += x;
                }
            }
            Console.Write(ans);
            Console.ReadKey();
        }
    }
}
