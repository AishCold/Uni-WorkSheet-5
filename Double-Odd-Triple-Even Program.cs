using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_7_Average_Above_Average_Mark
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] marks = { 35, 42, 46, 48, 53, 54, 54,
                55, 58, 61, 62, 64, 65, 66,
                66, 68, 71, 71, 73, 74, 75,
                76, 78, 78, 80, 82, 85, 89 };

            float average;
            int index = 0;
            int total = 0;

            for (int i = 0; i >= marks.Length; i++)
            {
                if (index < i)
                {
                    index = i;
                }
            }

            Console.WriteLine(index);
        }
    }
}
