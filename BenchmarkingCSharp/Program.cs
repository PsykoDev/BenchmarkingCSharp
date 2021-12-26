using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Running;
#pragma warning disable 
namespace BenchmarkingCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userChoise = "";
            Console.WriteLine("1: Dictionnary 100000 items\n2: String build 100000 items\n3: Hash Sha* Md5\n4: Hardware");
            Console.Write("Enter Bumber Here: ");
            userChoise = Console.ReadLine();
            switch (int.Parse(userChoise))
            {
                case 1:
                    BenchmarkRunner.Run<BenchmarkDictionaryLookup>();
                    break;
                case 2:
                    BenchmarkRunner.Run<MemoryBench>();
                    break;
                case 3:
                    BenchmarkRunner.Run<Hash>();
                    break;
                case 4:
                    BenchmarkRunner.Run<Hardware>();
                    break;
                default:
                    Console.Write($"{userChoise} dosen't exist");
                    return;
            }
            
        }
    }
}