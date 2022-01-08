using Grpc.Net.Client;
using gRPC_example;

var channel = GrpcChannel.ForAddress("http://localhost:5052");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(
        new HelloRequest { Name = "Chashtag" }
    );


Console.WriteLine(reply.Message);