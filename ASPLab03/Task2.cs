using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLab03
{
    class Task2
    {
        
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public double Average(params int[] tab)
        {
            int sum = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                sum += tab[i];
            }

            double avg = sum / tab.Length;

            return avg;
        }

    }
}
