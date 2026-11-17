var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// HTTPS и перенаправление с http на https делает прокси платформы

app.MapGet("/", () =>
{
    return "Hello world";
});

app.Run();
