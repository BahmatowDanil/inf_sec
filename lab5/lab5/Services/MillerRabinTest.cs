using System;

namespace lab5.Services
{
    public class MillerRabinTest
    {
        /// <summary>
        /// Тест Миллера — Рабина на простоту числа.
        /// </summary>
        /// <param name="m">Число.</param>
        public static bool IsPrimeNumber(Int64 m)
        { 
            if (m == 2 || m == 3) 
                return true; 
            
            if (m % 2 == 0 || m == 1)
                return false;

            Int64 s = 0; 
            Int64 t = m - 1; 
            Int64 r1 = 2;
            Int64 r2 = m - 2;
            Int64 a;
            Int64 r = (Int64)(Math.Log(m) / Math.Log(2));

            while (t != 0 && t % 2 == 0)
            {
                s++;
                t /= 2;
            }

            var random = new Random();
            for (Int64 i = 0; i < r; i++) 
            { 
                a = r1 + random.Next() % (r2 - r1); 
                Int64 x = MathExtension.ModPow(a, t, m);
                if (x == 1 || x == m - 1) 
                    continue; 
                
                for (Int64 j = 0; j < s - 1; j++) 
                { 
                    x = MathExtension.ModPow(x, 2, m); 
                    if (x == 1) 
                        return false; 
                   
                    if (x == m - 1) 
                        break; 
                } 

                if (x == m - 1) 
                    continue; 
                
                return false; 
            }

            return true; 
        }
    }
}
