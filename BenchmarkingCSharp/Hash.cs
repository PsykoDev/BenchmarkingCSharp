using System;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
#pragma warning disable 
namespace BenchmarkingCSharp
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Hash
	{
        public const int N = 10000;
        public readonly byte[] data;

        public readonly SHA1 sha1 = SHA1.Create();
        public readonly SHA256 sha256 = SHA256.Create();
        public readonly SHA384 sha384 = SHA384.Create();
        public readonly SHA512 sha512 = SHA512.Create();
        public readonly MD5 md5 = MD5.Create();
        

        public Hash()
        {
            data = new byte[N];
            new Random(42).NextBytes(data);
        }

        [Benchmark]
        public byte[] Sha1() => sha1.ComputeHash(data);

        [Benchmark]
        public byte[] Sha256() => sha256.ComputeHash(data);

        [Benchmark]
        public byte[] Sha384() => sha384.ComputeHash(data);

        [Benchmark]
        public byte[] Sha512() => sha512.ComputeHash(data);

        [Benchmark]
        public byte[] Md5() => md5.ComputeHash(data);
    }
}

