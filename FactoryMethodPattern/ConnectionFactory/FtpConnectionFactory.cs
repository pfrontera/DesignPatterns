namespace FactoryMethodPattern.ConnectionFactory;

public class FtpConnectionFactory : ConnectionFactory
{
    public override IConnection CreateConnection() => new FtpConnection();
}