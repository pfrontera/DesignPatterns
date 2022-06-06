namespace FactoryMethodPattern.ConnectionFactory;

public abstract class ConnectionFactory
{
    public abstract IConnection CreateConnection();

    public IConnection Connect()
    {
        return CreateConnection();
    }
}