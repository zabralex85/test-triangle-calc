```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]        : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  NativeAOT 8.0 : .NET 8.0.0, X64 NativeAOT AVX2

Job=NativeAOT 8.0  Runtime=NativeAOT 8.0  

```
| Method                   | Mean      | Error     | StdDev    |
|------------------------- |----------:|----------:|----------:|
| BenchmarkInvalidTriangle | 0.3801 ns | 0.0048 ns | 0.0043 ns |
| BenchmarkRightTriangle   | 0.2637 ns | 0.0031 ns | 0.0029 ns |
| BenchmarkAcuteTriangle   | 0.3173 ns | 0.0061 ns | 0.0051 ns |
| BenchmarkObtuseTriangle  | 0.2976 ns | 0.0036 ns | 0.0032 ns |
