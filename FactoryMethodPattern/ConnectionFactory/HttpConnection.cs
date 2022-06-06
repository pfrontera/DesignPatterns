namespace FactoryMethodPattern.ConnectionFactory;

public class HttpConnection : IConnection
{
    public async Task LogIn()
    {
        var client = new HttpClient();
        var response =  await client.GetAsync("https://api.chucknorris.io/jokes/random");
        var result = await response.Content.ReadAsStringAsync();
        Console.WriteLine(result);
    }
}