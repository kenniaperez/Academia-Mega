using ChatServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddSingleton<ChatHub>();



var app = builder.Build();
app.MapGrpcService<ChatServiceImp>();
app.MapGet("/", () => "Use a gRPC client to connect to this server.");


app.Run();
