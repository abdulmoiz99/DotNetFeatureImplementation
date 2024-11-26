using DotNetFeatureImplementation;

GC.Collect();
GC.WaitForPendingFinalizers();
GC.Collect();
long memoryBefore = GC.GetTotalMemory(false);
var singleton = Singleton.Instance();
long memoryAfter = GC.GetTotalMemory(false);
Console.WriteLine($"Memory before: {memoryBefore} bytes");
Console.WriteLine($"Memory after: {memoryAfter} bytes");
Console.WriteLine($"Memory used by singleton: {memoryAfter - memoryBefore} bytes");
