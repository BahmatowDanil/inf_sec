using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Seq
    {
        public int[] sequence = new int[10000];
        public int len = 0;
        public void generateSeq()
        {
            Random rnd = new Random();
            for (int i = 0; i < len; i++)
            {
                sequence[i] = rnd.Next(0, 2);
            }
        }
    }
}
