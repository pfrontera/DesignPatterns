namespace DesignPatterns.SingletonPattern
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance = new Singleton();
        public static int TotalInstances;

        private Singleton()
        {
            TotalInstances++;
        }

        public static Singleton GetInstance => Instance;
    }
}