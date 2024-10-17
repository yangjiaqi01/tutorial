using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial6
{
    class exercise4
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine(); // 为了在输出结束后换行
        }
    }
}
