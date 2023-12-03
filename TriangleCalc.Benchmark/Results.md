Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]        : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  NativeAOT 8.0 : .NET 8.0.0, X64 NativeAOT AVX2

Job=NativeAOT 8.0  Runtime=NativeAOT 8.0


| Method                  | Mean      | Error     | StdDev    |
|------------------------ |----------:|----------:|----------:|
| BenchmarkRightTriangle  | 0.3029 ns | 0.0048 ns | 0.0045 ns |
| BenchmarkAcuteTriangle  | 0.2888 ns | 0.0062 ns | 0.0058 ns |
| BenchmarkObtuseTriangle | 0.3246 ns | 0.0052 ns | 0.0046 ns |

## To Run: `dotnet run -c Release`
