using System;
using System.Collections.Generic;

namespace lab5.Services
{
    public class PrimeGenerator
    {
        /// <summary>
        /// Получение случайного простого числа.
        /// </summary>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="seed">Сид.</param>
        /// <returns>Простое число.</returns>
        public static int GetRandomPrimeNumber(int min = 1, int max = int.MaxValue, int? seed = null)
        {
            var random = seed.HasValue ? new Random(seed.Value) : new Random();
            var num = random.Next(min, max);
            while (!MillerRabinTest.IsPrimeNumber(num))
                num = random.Next(min, max);
            return num;
        }

        /// <summary>
        /// Получение массива взаимно простых чисел к заданному.
        /// </summary>
        /// <param name="num">Число.</param>
        /// <param name="maxNum">Максимальное значение.</param>
        /// <returns>Массив взаимно простых чисел к заданному.</returns>
        public static int[] GetCoprimeNumbers(int num, int? maxNum = null)
        {
            var primes = new List<int>();
            for(int i = 1; i <= (maxNum ?? num); i += 2)
            {
                if (IsCoprime(i, num))
                    primes.Add(i);
            }
            return primes.ToArray();
        }

        private static bool IsCoprime(int a, int b)
        {
            return a == b
                   ? a == 1
                   : a > b
                        ? IsCoprime(a - b, b)
                        : IsCoprime(b - a, a);
        }
    }
}
