using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class PrimeNumbers
    {
        public void Prime()
        {
            for (int i = 2; i <= 1000; i += 2)
            {
                int temp = 0;

                if (i == 2)
                {
                    Console.Write(2 + " ");
                    i++;
                }
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        temp = 1;
                        break;
                    }
                }
                if (temp == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
    
    

