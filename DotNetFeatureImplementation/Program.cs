using System.Diagnostics.CodeAnalysis;

AppContext.SetSwitch("Feature.IsSupported", true);

if (Feature.IsSupported)
{
    Feature.Implementation();
}
else Console.WriteLine("Feature is not supported");


public static class Feature
{
    [FeatureSwitchDefinition("Feature.IsSupported")]
    internal static bool IsSupported => AppContext.TryGetSwitch("Feature.IsSupported", out bool isEnable) ? isEnable : true;

    internal static void Implementation()
    {
        Console.WriteLine("Feature is enable and running");
    }
}