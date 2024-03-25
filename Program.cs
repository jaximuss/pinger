using System.Net.NetworkInformation;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Welcome to PING2!!!!");
        Console.WriteLine("type in the website you would like to ping ...");
        var result = Console.ReadLine();
        Console.WriteLine($"pinging {result} ...");
        await Task.Delay(1000);

        //instantiate the ping
        Ping pingClient = new Ping();

        //get response from what you want to ping with a try BLOCK

        try
        {
            while (true)
            {
                PingReply response = await pingClient.SendPingAsync($"{result}");
                if (response.Status == IPStatus.Success)
                {
                    //since this is an asyncronouse thread we use this method which is called a task not thread.sleep
                    Console.WriteLine($"ping successfull your connection to the target is : {response.RoundtripTime} ms");
                    await Task.Delay(1000);
                }
                else
                {
                    Console.WriteLine("connection lost or invalid website");
                    break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"failed reason : {ex.Message}");
            throw;
        }

    }
}