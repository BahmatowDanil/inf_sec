using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Test1
    {
        public void freqTest(int [] seq, int len)
        {
            int sum = 0;
            double res;
            for (int i = 0; i < len; i++)
            {
                sum += seq[i] * 2 - 1;
            }
            res = (Math.Abs(sum) / Math.Sqrt(len));
            Console.WriteLine("Результат частотного теста: " + res);
            if (res < 1.82138636)
            {
                Console.WriteLine("Тест пройден успешно");
            }
            else Console.WriteLine("Тест не пройден");
        }
    }
}
