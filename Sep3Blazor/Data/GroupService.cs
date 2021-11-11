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
        private readonly String URL = "https://localhost:5004";
        public IList<String> AdultsList { get; set; }
       

        public async Task<IList<string>> GetGroup(string s)
        {
            using var channel = GrpcChannel.ForAddress(URL);
            var client = new BusinessServer.BusinessServerClient(channel);
            var reply = await client.GetGroupAsync(
                new GroupRequest {Name = "1"});
            Console.WriteLine("Greeting: " + reply.Message);
            AdultsList = JsonSerializer.Deserialize<List<String>>(reply.Message);
            return AdultsList;
        }

        public async Task<IList<string>> PostGroup(string s)
        {
            using var channel = GrpcChannel.ForAddress(URL);
            var client = new BusinessServer.BusinessServerClient(channel);

            var reply = await client.PostGroupAsync(
                new GroupRequest {Name = s});
            Console.WriteLine("Greeting: " + reply.Message);
            AdultsList = JsonSerializer.Deserialize<List<String>>(reply.Message);
            Console.WriteLine(AdultsList[0]);
            return AdultsList;
        }
    }
}