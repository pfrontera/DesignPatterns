namespace FactoryMethodPattern.ConnectionFactory;

public interface IConnection
{
    public Task LogIn();
}