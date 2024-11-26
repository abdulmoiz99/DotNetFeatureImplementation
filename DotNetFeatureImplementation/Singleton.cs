using System.Numerics;

namespace DotNetFeatureImplementation
{
    internal class Singleton
    {
        private static Singleton instance;
        public BigInteger BigInteger;
        public int Integer;
        private Singleton()
        {
            BigInteger = new BigInteger(10000000000);
            Integer = 10000;
        }

        public static Singleton Instance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
