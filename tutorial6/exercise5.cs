using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial6
{
     class exercise5
    {
        static void Main()
        {
            int Result = 0; 
            do
            {
                Result += 1;
                Console.WriteLine(Result);

                if (Result == 10)
                {
                    Result = -1; 
                }
            } while (Result >= 0);

        }
    }
}
