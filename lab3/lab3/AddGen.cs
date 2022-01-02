﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class AddGen
    {
        public int[] sequence = new int[10000];
        public int len = 0;
        int a = 55, b = 24;
        public string generateSeq()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                sequence[i] = rnd.Next(0, 1000);  
            }
            for (int i = 0; i < len; i++)
            {
                int temp = (sequence[len - a + i] + sequence[len - b + i]) % 512;
                sequence[i] = temp;
            }
            for (int i = 0; i < len; i++)
            {
               sequence[i] = sequence[i] % 2;
            }
            int[] tmparr = new int[len];
            Array.Copy(sequence, tmparr, len);
            return String.Join("", tmparr);
        }
    }
}
