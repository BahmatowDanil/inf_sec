using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class ConGen
    {
        public int[] sequence = new int[100000];
        public int len = 10000;
        int a = 106, b = 1283, m = 6075;
        public void generateSeq(int key)
        {

            sequence[0] = key % m;
            for (int i = 0; i < len; i++)
            {
                sequence[i + 1] = Math.Abs((int)(a * sequence[i] + b) % m);
            }
        }

        public Int32 generateElem(int key)
        {
            key = Math.Abs(key);
            key %= len;
            generateSeq(key);
            return (Int32)sequence[50];
        }

    }
}
