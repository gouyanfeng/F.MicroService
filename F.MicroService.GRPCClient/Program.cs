
using Grpc.Net.Client;
using System;

namespace F.MicroService.GRPCClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");

            var client = new Greeter.GreeterClient(channel);
            var reply = client.SayHello(new HelloRequest { Name = "yf" });
            Console.WriteLine(reply.Message);
            Console.ReadKey();
        }
    }

}
