using TaskManager.Repositories;
using TaskManager.Services;
using TaskManager.Shared.PubSub;
using TaskManager.Hubs;

;
var builder = WebApplication.CreateBuilder(args);

var AllowedOrigin = "BlazorClient";
builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowedOrigin, policy =>
    {
        policy.WithOrigins("http://localhost:5064")
            .AllowAnyHeader()
            .AllowAnyMethod();
           // .AllowCredentials();
    });
});

builder.Services.AddControllers();

builder.Services.AddScoped<INotificationService, EmailNotificationService>();
builder.Services.AddScoped<INotificationService, SmsNotificationService>();
builder.Services.AddSingleton<ITaskRepository, InMemoryTaskRepository>();
builder.Services.AddSingleton<EventBus>();
builder.Services.AddSignalR();
// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

// Add Swagger/OpenAPI services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

//var AllowedOrigin = "BlazorClient";
app.UseCors(AllowedOrigin);

app.UseHttpsRedirection();
app.MapControllers();
app.MapHub<TaskEventHub>("/taskEvents");
app.UseSwagger();
app.UseSwaggerUI();

app.Run();
