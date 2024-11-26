using DotNetFeatureImplementation;
using System.Runtime.CompilerServices;

var example = new UnsafeAccessorExample();

example.AccessGenericType(new UpdatedClassForPrivateGeneric<int>());

class Accessors<V>
{
    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_field")]
    public extern static ref V GetSetPrivateField(UpdatedClassForPrivateGeneric<V> c);

    [UnsafeAccessor(UnsafeAccessorKind.Method, Name = "M")]
    public extern static void CallM<W>(UpdatedClassForPrivateGeneric<V> c, V v, W w);
}

internal class UnsafeAccessorExample
{
    public void AccessGenericType(UpdatedClassForPrivateGeneric<int> c)
    {
        ref int f = ref Accessors<int>.GetSetPrivateField(c);

        Accessors<int>.CallM<string>(c, 1, string.Empty);
    }
}