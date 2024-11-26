namespace DotNetFeatureImplementation
{
    internal class UpdatedClassForPrivateGeneric<T>
    {
        private T? _field;
        private void M<U>(T t, U u) { }
    }
}
