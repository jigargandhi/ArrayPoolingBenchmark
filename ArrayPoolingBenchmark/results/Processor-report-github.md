``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i3-3110M CPU 2.40GHz (Ivy Bridge), ProcessorCount=4
Frequency=2338449 Hz, Resolution=427.6339 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2110.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2110.0


```
 |      Method |     Mean |    Error |   StdDev |
 |------------ |---------:|---------:|---------:|
 | FillInBytes | 926.5 ms | 17.69 ms | 18.93 ms |
