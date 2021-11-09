using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using Grpc.Net.Client;



namespace Sep3Blazor.Data
{
    public class GroupService : IGroupService
    {
        private String URL = "https://localhost:5004";
        public IList<String> AdultsList { get; set; }
        private string productsFile = "adults.json";
        private TcpClient tcpClient;
        private NetworkStream stream;

        public async Task<IList<string>> Connect(string s)
        {
            using var channel = GrpcChannel.ForAddress(URL);
            var client = new BusinessServer.BusinessServerClient(channel);
            var reply = await client.GetGroupAsync(
                new GroupRequest {Name = "1"});
            Console.WriteLine("Greeting: " + reply.Message);
            AdultsList = JsonSerializer.Deserialize<List<String>>(reply.Message);
            return AdultsList;
        }

        public async Task<IList<string>> Post(string s)
        {
            using var channel = GrpcChannel.ForAddress(URL);
            var client = new BusinessServer.BusinessServerClient(channel);

            var reply = await client.PostGroupAsync(
                new GroupRequest {Name = s});
            Console.WriteLine("Greeting: " + reply.Message);
            AdultsList = JsonSerializer.Deserialize<List<String>>(reply.Message);
            Console.WriteLine(AdultsList[0]);
            return AdultsList;
            // Message message = new Message(s, "Post");
            // string request = JsonSerializer.Serialize(message);
            // byte[] dataToServer = Encoding.ASCII.GetBytes(request);
            // stream.Write(dataToServer, 0, dataToServer.Length);
            //
            // // read response
            // try
            // {
            //     byte[] fromServer = new byte[8192];
            //     int bytesRead = stream.Read(fromServer, 0, fromServer.Length);
            //     string response = Encoding.ASCII.GetString(fromServer, 0, bytesRead);
            //     AdultsList = JsonSerializer.Deserialize<List<String>>(response);
            //     Console.WriteLine("hi"+response);
            //     return Task.FromResult(AdultsList);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            //     throw;
            // }

            //tcpClient.Close();
        }
    }
}