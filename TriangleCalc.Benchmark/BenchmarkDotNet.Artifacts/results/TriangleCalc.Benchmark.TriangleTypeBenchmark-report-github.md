```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]        : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  NativeAOT 8.0 : .NET 8.0.0, X64 NativeAOT AVX2

Job=NativeAOT 8.0  Runtime=NativeAOT 8.0  

```
| Method                  | Mean      | Error     | StdDev    |
|------------------------ |----------:|----------:|----------:|
| BenchmarkRightTriangle  | 0.7341 ns | 0.0052 ns | 0.0047 ns |
| BenchmarkAcuteTriangle  | 0.9029 ns | 0.0071 ns | 0.0060 ns |
| BenchmarkObtuseTriangle | 0.7253 ns | 0.0061 ns | 0.0054 ns |
