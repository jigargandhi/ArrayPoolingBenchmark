using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace ArrayPoolingBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {

            var summary = BenchmarkRunner.Run<Processor>();

            
        }
    }

    public class Processor
    {
        private const int length = 1024 * 1024 * 1024;
        public Processor()
        {
            byteArray = ArrayPool<byte>.Shared.Rent(length);
        }
        public byte[] byteArray;

        [Benchmark]
        public void FillInBytes()
        {
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = 8;
            }
        }
    }
}
