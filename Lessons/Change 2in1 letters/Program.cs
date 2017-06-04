using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_2in1_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToUpper();
            string ans = string.Empty;

            if (str.Length % 2 == 0)
            {
                for (int i = 0; i < str.Length; i += 2)
                { ans += str[i + 1].ToString() + str[i].ToString(); }
            }
            else
            {
                for (int i = 1; i < str.Length; i += 2)
                { ans += str[i].ToString() + str[i-1].ToString(); }
                ans += str[str.Length-1];
            }

            Console.Write(ans);
            Console.ReadKey();
        }
    }
}
