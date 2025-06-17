using Grpc.Net.Client;
using Grpc.Core;
using GrpcChat;

//setup del chat
Console.WriteLine("Connecting to the chat server... Cual es tu nombre?");
var user = Console.ReadLine() ?? "Anonymous";


using var channer = GrpcChannel.ForAddress("https://localhost:5155", 
      new GrpcChannelOptions{UnsafeUseInsecureChannelCallCredentials = true });

var client = new ChatService.ChatServiceClient(channer);

//1 Abrir el stream
using var call = client.Chat();
//2 Enviar el primer mensaje o tarea para escuchar los mensajes
var readTask = Task.Run(async () =>
{
    await foreach (var incoming in call.ResponseStream.ReadAllAsync())
    {
        var timeSend = DateTimeOffset.FromUnixTimeMilliseconds(incoming.Timestamp).ToLocalTime().ToString("HH:mm:ss");

        Console.ForegroundColor = incoming.User == user ? ConsoleColor.Cyan : ConsoleColor.Green;
        Console.WriteLine($"[{timeSend}] [{incoming.User}]: {incoming.Text}");
        Console.ResetColor();
    }
});


//Hacer el join
await call.RequestStream.WriteAsync(new ChatMessage
{
    User = user,
    Text = "Se ha unido al chat",
    Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
});


// 3 Enviar el primer mensaje
string? line;

while ((line = Console.ReadLine()) != null)
{
    if (string.IsNullOrWhiteSpace(line))
        continue;

    //4 Enviar el mensaje
    await call.RequestStream.WriteAsync(new ChatMessage
    {
        User = user,
        Text = line,
        Timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()
    });
}