using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Sep3Blazor.Model;

namespace Sep3Blazor.Data
{
    public class AdultService : IAdultService
    {
        public IList<String> AdultsList { get; set; }
        private string productsFile = "adults.json";
        private TcpClient tcpClient;
        private NetworkStream stream;

        public AdultService()
        {
            tcpClient = new TcpClient("127.0.0.1", 2910);
            stream = tcpClient.GetStream();
        }


        public void Save()
        {
            string productsAsJson = JsonSerializer.Serialize(AdultsList);
            File.WriteAllText(productsFile, productsAsJson);
        }

        public void Remove(int adultId)
        {
        }

        public Task<IList<string>> Connect(string s)
        {
            Console.WriteLine("Hello");
            // send to server
            Message message = new Message(s, "Get");
            string request = JsonSerializer.Serialize(message);
            byte[] dataToServer = Encoding.ASCII.GetBytes(request);
            stream.Write(dataToServer, 0, dataToServer.Length);

            // read response
            try
            {
                byte[] fromServer = new byte[8192];
                int bytesRead = stream.Read(fromServer, 0, fromServer.Length);
                string response = Encoding.ASCII.GetString(fromServer, 0, bytesRead);
                AdultsList = JsonSerializer.Deserialize<List<String>>(response);
                Console.WriteLine("hi"+response);
                return Task.FromResult(AdultsList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            //tcpClient.Close();
        }
        
        public Task<IList<string>> Post(string s)
        {
            Message message = new Message(s, "Post");
            string request = JsonSerializer.Serialize(message);
            byte[] dataToServer = Encoding.ASCII.GetBytes(request);
            stream.Write(dataToServer, 0, dataToServer.Length);

            // read response
            try
            {
                byte[] fromServer = new byte[8192];
                int bytesRead = stream.Read(fromServer, 0, fromServer.Length);
                string response = Encoding.ASCII.GetString(fromServer, 0, bytesRead);
                AdultsList = JsonSerializer.Deserialize<List<String>>(response);
                Console.WriteLine("hi"+response);
                return Task.FromResult(AdultsList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            //tcpClient.Close();
        }
    }
}