using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Test2
    {
        public void identicalBitsTest(int[] seq, int len)
        {
            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                sum += seq[i];
            }
            double pi = (double)sum / len;
            int temp = 0;
            int sumr = 0;
            for (int i = 0; i < len - 1; i++)
            {
                if (seq[i] == seq[i + 1]) temp = 0;
                else temp = 1;
                sumr += temp;
            }
            double res = (Math.Abs((sumr + 1) - 2 * len * pi * (1 - pi))) / (2 * Math.Sqrt(2 * len) * pi * (1 - pi));
            Console.WriteLine("Результат теста на последовательность одинаковых бит: " + res);
            if (res < 1.82138636) Console.WriteLine("Тест пройден успешно");
            else Console.WriteLine("Тест не пройден");

        }
    }
}
