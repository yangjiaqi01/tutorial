using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial6
{
     class exercise1
    {
        static void Main()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i);
                if (i < 10)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
