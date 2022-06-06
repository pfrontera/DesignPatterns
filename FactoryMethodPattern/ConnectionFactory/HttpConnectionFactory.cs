namespace FactoryMethodPattern.ConnectionFactory;

public class HttpConnectionFactory : ConnectionFactory
{
    public override IConnection CreateConnection() => new HttpConnection();
}