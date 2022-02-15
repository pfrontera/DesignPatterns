namespace SingletonPattern.SingletonPattern
{
    public class BadSingleton
    {
        private static  BadSingleton Instance;
        public static int TotalInstances;

        private BadSingleton()
        {
            TotalInstances++;
        }
        
        public static BadSingleton GetInstance => Instance ??= new BadSingleton();
    }
}