using System.Net;

namespace FactoryMethodPattern.ConnectionFactory;

public class FtpConnection : IConnection
{
    public Task LogIn()
    {
        //  For projects that target .NET 6 and later versions, FTP is no longer supported.
        
        var request = (FtpWebRequest)WebRequest.Create("ftp://ftp.dlptest.com/");
        request.Method = WebRequestMethods.Ftp.ListDirectory;  
        request.Credentials = new NetworkCredential("dlpuser","rNrKYTX9g7z3RgJRmxWuGHbeu");

        var response = (FtpWebResponse)request.GetResponse();  
        var responseStream = response.GetResponseStream();  
        var reader = new StreamReader(responseStream);  
        var names = reader.ReadToEnd();  
  
        reader.Close();  
        response.Close();
        
        Console.WriteLine(names);

        return Task.CompletedTask;
    }
}