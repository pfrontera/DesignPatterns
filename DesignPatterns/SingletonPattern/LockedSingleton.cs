namespace DesignPatterns.SingletonPattern
{
    public sealed class LockedSingleton
    {
        private static volatile LockedSingleton Instance;
        private static object lockObject = new object();
        public static int TotalInstances;

        private LockedSingleton()
        {
            TotalInstances++;
        }

        public static LockedSingleton GetInstance
        {
            get
            {
                lock (lockObject)
                {
                    if (Instance is null)
                    {
                        Instance = new LockedSingleton();
                    }
                }
                return Instance;
            }
        }
    }
}