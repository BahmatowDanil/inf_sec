using System;

namespace lab5.Services
{
    public class MathExtension
    {
        /// <summary>
        /// Возведение в степень по модулю.
        /// </summary>
        /// <remarks>
        /// a^b mod n - возведение a в степень b по модулю n
        /// </remarks>
        /// <param name="a">Число.</param>
        /// <param name="b">Степень.</param>
        /// <param name="n">Модуль.</param>
        /// <returns>Результат воздведения в степень по модулю.</returns>
        public static int ModPow(int a, int b, int n)
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }

        /// <summary>
        /// Возведение в степень по модулю.
        /// </summary>
        /// <remarks>
        /// a^b mod n - возведение a в степень b по модулю n
        /// </remarks>
        /// <param name="a">Число.</param>
        /// <param name="b">Степень.</param>
        /// <param name="n">Модуль.</param>
        /// <returns>Результат воздведения в степень по модулю.</returns>
        public static Int64 ModPow(Int64 a, Int64 b, Int64 n)
        {
            Int64 tmp = a;
            Int64 sum = tmp;
            for (Int64 i = 1; i < b; i++)
            {
                for (Int64 j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }

        /// <summary>
        /// Умножение по модулю.
        /// </summary>
        /// <remarks>
        /// a*b mod n - умножение a на b по модулю n
        /// </remarks>
        /// <param name="a">Первый множитель.</param>
        /// <param name="b">Второй множитель.</param>
        /// <param name="n">Модуль.</param>
        /// <returns>Результат умножения по модулю.</returns>
        public static int ModMul(int a, int b, int n)
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }
    }
}
