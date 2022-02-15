namespace SingletonPattern.SingletonPattern
{
    public sealed class LazySingleton
    {
        static Func<LazySingleton> myFuncDelegate = MakeSingletonInstance;
        private static readonly Lazy<LazySingleton> Instance = new Lazy<LazySingleton>(myFuncDelegate);
        public static int TotalInstances;

        private static LazySingleton MakeSingletonInstance()
        {
            return new LazySingleton();
        }

        private LazySingleton()
        {
            TotalInstances++;
        }

        public static LazySingleton GetInstance => Instance.Value;
    }
}