namespace DotNetFeatureImplementation
{
    public class Class
    {
        private static void StaticPrivateMethod()
        {
            Console.WriteLine("Private Method Has been called");
        }
        private void PrivateMethod()
        {
            Console.WriteLine("This is private");
        }
        static int StaticPrivateField;
        Class(int i) { PrivateField = i; }
        int PrivateField;
        int PrivateProperty { get => PrivateField; }
    }
}
