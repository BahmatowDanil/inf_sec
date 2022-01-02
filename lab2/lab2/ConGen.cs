using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class ConGen
    {
        public int[] sequence = new int[100000];
        public int len = 0;
        int a = 106, b = 1283, m = 6075;
        public void generateSeq()
        {
            Random rnd = new Random();

            sequence[0] = rnd.Next(0, m);
            for (int i = 0; i < len; i++)
            {
                sequence[i + 1] = (int)(a * sequence[i] + b) % m;
            }
            for (int i = 0; i < len; i++)
            {
                sequence[i] = Math.Abs(sequence[i] % 2);
            }
        }

    }
}
