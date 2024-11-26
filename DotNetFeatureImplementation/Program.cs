using DotNetFeatureImplementation;
using System.Runtime.CompilerServices;


CallStaticPrivateMethod();
CallPrivateConstructor();
GetSetStaticPrivateField();

static void CallStaticPrivateMethod()
{
    StaticPrivateMethod(null);

    [UnsafeAccessor(UnsafeAccessorKind.StaticMethod, Name = nameof(StaticPrivateMethod))]
    extern static void StaticPrivateMethod(Class c);
}
static void CallPrivateConstructor()
{
    Class c1 = PrivateConstructor(1);
    CallPrivateMethod(c1);


    [UnsafeAccessor(UnsafeAccessorKind.Constructor)]
    extern static Class PrivateConstructor(int i);
}

static void CallPrivateMethod(Class c)
{
    PrivateMethod(c);

    [UnsafeAccessor(UnsafeAccessorKind.Method, Name = nameof(PrivateMethod))]
    extern static void PrivateMethod(Class c);
}
static void GetSetStaticPrivateField()
{
    ref int f = ref GetSetStaticPrivateField(null);

    [UnsafeAccessor(UnsafeAccessorKind.StaticField, Name = "StaticPrivateField")]
    extern static ref int GetSetStaticPrivateField(Class c);
}

