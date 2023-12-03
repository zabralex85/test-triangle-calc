Intel Core i7-9700 CPU 3.00GHz, 1 CPU, 8 logical and 8 physical cores
.NET SDK 8.0.100
  [Host]        : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  NativeAOT 8.0 : .NET 8.0.0, X64 NativeAOT AVX2

Job=NativeAOT 8.0  Runtime=NativeAOT 8.0

std:

| Method                  | Mean      | Error     | StdDev    |
|------------------------ |----------:|----------:|----------:|
| BenchmarkAcuteTriangle  |  2.212 ns | 0.0139 ns | 0.0130 ns |
| BenchmarkObtuseTriangle |  2.196 ns | 0.0148 ns | 0.0131 ns |
| BenchmarkRightTriangle  |  1.946 ns | 0.0069 ns | 0.0061 ns |

uns+unc

| Method                  | Mean     | Error     | StdDev    |
|------------------------ |---------:|----------:|----------:|
| BenchmarkRightTriangle  | 1.980 ns | 0.0108 ns | 0.0101 ns |
| BenchmarkAcuteTriangle  | 2.183 ns | 0.0058 ns | 0.0049 ns |
| BenchmarkObtuseTriangle | 2.188 ns | 0.0072 ns | 0.0060 ns |

unc

| Method                  | Mean     | Error     | StdDev    |
|------------------------ |---------:|----------:|----------:|
| BenchmarkRightTriangle  | 1.975 ns | 0.0120 ns | 0.0112 ns |
| BenchmarkAcuteTriangle  | 2.165 ns | 0.0112 ns | 0.0093 ns |
| BenchmarkObtuseTriangle | 2.202 ns | 0.0095 ns | 0.0085 ns |

## To Run: `dotnet run -c Release`