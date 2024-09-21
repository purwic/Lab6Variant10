using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Variant10
{
    public class Class1
    {
        public static double[,] matrix = new double[14, 14];
        public static int method1()
        {
            int count = 0;
            for (int i = 0; i < 14; i++)
            {
                for (int j = 13; j > 12 - i; j--)
                {
                    if (matrix[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static double[] method2()
        {
            double[] G = new double[method1()];
            int count = 0;
            for (int i = 0; i < 14; i++)
            {
                for (int j = 13; j > 12 - i; j--)
                {
                    if (matrix[i, j] < 0)
                    {
                        G[count] = matrix[i, j];
                        count++;
                    }
                }
            }

            return G;
        }
    }
}
