using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_5_Double_Odd_Triple_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 3, 4, 6, 9, 4, 5, 2, 2, 6 };

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    values[i] = values[i] * 3;
                }
                else
                {
                    values[i] = values[i] * 2;
                }
                Console.Write(values[i] + " ");
            }
        }
    }
}
