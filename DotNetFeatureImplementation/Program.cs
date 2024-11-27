
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Benchy>();


[MemoryDiagnoser]
public class Benchy
{
    private static readonly string _dataAsText = "11 27 2024";

    [Benchmark]
    public (int month, int day, int year) DateWithStringAndSubstring()
    {
        var monthAsText = _dataAsText.Substring(0, 2);
        var dayAsText = _dataAsText.Substring(3, 2);
        var yearAsText = _dataAsText.Substring(6);

        int month = int.Parse(monthAsText);
        int day = int.Parse(dayAsText);
        int year = int.Parse(yearAsText);

        return (month, day, year);
    }
    [Benchmark]
    public (int month, int day, int year) DateWithStringAndSpan()
    {
        ReadOnlySpan<char> dateAsSpan = _dataAsText;
        var monthAsText = dateAsSpan.Slice(0, 2);
        var dayAsText = dateAsSpan.Slice(3, 2);
        var yearAsText = dateAsSpan.Slice(6);

        int month = int.Parse(monthAsText);
        int day = int.Parse(dayAsText);
        int year = int.Parse(yearAsText);

        return (month, day, year);
    }
}