﻿﻿using Microsoft.AspNetCore.SignalR.Client;
using TaskManager.Shared.Events;

var connection = new HubConnectionBuilder()
    .WithUrl("http://localhost:5242/taskEvents")
    .Build();

connection.On<TaskEvent>("TaskEvent", ev =>
{
    Console.WriteLine($"{ev.EventName}: {ev.Payload.Title}");
});

await connection.StartAsync();
Console.WriteLine("Observando eventos...");
await Task.Delay(Timeout.Infinite);