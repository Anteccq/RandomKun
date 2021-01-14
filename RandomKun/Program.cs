using System;
using System.Security.Cryptography;

namespace RandomKun
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new byte[sizeof(UInt16)];
            using var rng = new RNGCryptoServiceProvider();
            rng.GetBytes(data);
            var n = BitConverter.ToUInt16(data, 0);

            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
