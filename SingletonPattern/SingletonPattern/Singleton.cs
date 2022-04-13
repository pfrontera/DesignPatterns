namespace SingletonPattern.SingletonPattern
{
    // With sealed class we prevent possible derivation of the class.
    public sealed class Singleton
    {
        // readonly ensures that the field can't be assigned once you exit the constructor. 
        private static readonly Singleton Instance = new Singleton();
        
        public static int TotalInstances { get; private set; }
        
        //Just for geting "MyVar" our application will have created an instance,
        //so, TotalInstances will be 1. 
        public static int MyVar = 300;

        private Singleton()
        {
            TotalInstances++;
        }

        public static Singleton GetInstance() => Instance;
        
        // Alternative using static constructor
        // If we use a Static Constructor it must be parameterless.
        // static Singleton() => new Singleton();
    }
}