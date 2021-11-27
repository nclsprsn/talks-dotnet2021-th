var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async () => await Task.FromResult("Hello World!"));

app.Run();
