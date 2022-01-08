using System;

namespace lab5.Services
{
    public class ClientKey
    {
        public int y { get; set; }
        public int g { get; set; }
        public int p { get; set; }
    };

    public class SecretKey
    {
        public int x { get; set; }
    }

    public class KeysInfo
    {
        public ClientKey ClientKey { get; set; }
        public SecretKey SecretKey { get; set; }
    }
    
    public class ElGamalCipher
    {
        /// <summary>
        /// Генерация пары ключей - открытого и закрытого.
        /// </summary>
        /// <returns>Информация о закрытом и открытом ключе.</returns>
        public KeysInfo GenerateKeys()
        {
            int minValue = 1234;
            var random = new Random();
            var p = PrimeGenerator.GetRandomPrimeNumber(minValue, minValue + 10000, random.Next());
            var g = PrimeGenerator.GetRandomPrimeNumber(minValue, p - 1, random.Next());
            var x = PrimeGenerator.GetRandomPrimeNumber(minValue, p - 1, random.Next());
            var y = MathExtension.ModPow(g, x, p);

            return new KeysInfo
            {
                ClientKey = new ClientKey { y = y, g = g, p = p },
                SecretKey = new SecretKey { x = x }
            };
        }

        /// <summary>
        /// Шифрование.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <param name="key">Открытый ключ.</param>
        /// <returns>Результат шифрования.</returns>
        public string Encrypt(string message, ClientKey key)
        {
            var random = new Random();
            var coPrimes = PrimeGenerator.GetCoprimeNumbers(key.p - 1);
            var result = string.Empty;
            foreach(var ch in message)
            {
                var m = Convert.ToInt32(ch);
                if (m <= 0)
                    continue;

                var k = coPrimes[random.Next(0, coPrimes.Length - 1)];

                int a = MathExtension.ModPow(key.g, k, key.p);
                int b = MathExtension.ModMul(MathExtension.ModPow(key.y, k, key.p), m, key.p);
                result += $"{(char)a}{(char)b}";
            }

            return result;
        }

        /// <summary>
        /// Дешифрование.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        /// <param name="clientKey">Открытый ключ.</param>
        /// <param name="secretKey">Закрытый ключ.</param>
        /// <returns>Результат дешифрования.</returns>
        public string Decrypt(string message, ClientKey clientKey, SecretKey secretKey)
        {
            var result = string.Empty;
            for(int i = 0; i < message.Length; i += 2)
            {
                var a = (int)message[i];
                var b = (int)message[i + 1];
                
                if (a == 0 && b == 0)
                    continue;

                var M = MathExtension.ModMul(b, MathExtension.ModPow(a, clientKey.p - 1 - secretKey.x, clientKey.p), clientKey.p);
                result += (char)M;
            }

            return result;
        }
    }
}
