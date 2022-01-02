using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class CubeConGen
    {
        public int[] sequence = new int[10000];
        public int len = 0;
        int a = 122, b = 547, c = 369, d = 465, m = 187;
        public void generateSeq()
        {
            Random rnd = new Random();

            sequence[0] = rnd.Next(0, m);
            for (int i = 0; i < len; i++)
            {
                sequence[i + 1] = (int)(d + sequence[i] * c + Math.Pow(sequence[i], 2) * b + Math.Pow(sequence[i], 3) * a) % m;
            }
            for (int i = 0; i < len; i++)
            {
                sequence[i] = Math.Abs(sequence[i] % 2);
            }
        }

    }
}
