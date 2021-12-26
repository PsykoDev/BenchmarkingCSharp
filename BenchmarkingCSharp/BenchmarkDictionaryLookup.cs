using System;
using System.Security.Cryptography;
using System.Text;
using BenchmarkDotNet.Attributes;

#pragma warning disable 

namespace BenchmarkingCSharp
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchmarkDictionaryLookup
    {
        DictionaryLookup obj = new DictionaryLookup();
        string val = "test_100000";
        [Benchmark(Baseline = true)]
        public void GetValueByKey()
        {
            obj.GetValueByKey(val);
        }
        [Benchmark]
        public void GetValueByKeyWithLinq()
        {
            obj.GetValueByKeyWithLinq(val);
        }
        [Benchmark]
        public void GetValueByKeyWithTryGet()
        {
            obj.GetValueByKeyWithTryGet(val);
        }
        [Benchmark]
        public void GetValueByKeyManual()
        {
            obj.GetValueByKeyManual(val);
        }
    }
}

