using FactoryMethodPattern.AnimalFactory;
using FactoryMethodPattern.ConnectionFactory;

var tiger = new TigerFactory().MakeAnimal(false);
var bear = new BearFactory().MakeAnimal(true);


var ftpConnection = new FtpConnectionFactory().CreateConnection();
await ftpConnection.LogIn();

var httpConnection = new HttpConnectionFactory().CreateConnection();
await httpConnection.LogIn();