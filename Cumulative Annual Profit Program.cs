using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_4_Cumulative_Annual_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] monthlyProfit = { 550, 443, 397, 355, 457, 589, 677, 812, 674, 534, 354, 412 };

            int[] cumulativeMonthlyProfit = new int[12];

            cumulativeMonthlyProfit[0] = monthlyProfit[0];

            int index = 1;

            while (index <= 11)
            {
                cumulativeMonthlyProfit[index] = cumulativeMonthlyProfit[index - 1] + monthlyProfit[index];
                index = index + 1;
            }

            for(int i = 0; i < cumulativeMonthlyProfit.Length; i++)
            {
                Console.WriteLine(cumulativeMonthlyProfit[i]);
            }

            
        }
    }
}
