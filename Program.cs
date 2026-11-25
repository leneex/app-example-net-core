var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// The platform proxy handles HTTPS and the redirect from http to https

app.MapGet("/", () =>
{
    return "Hello world";
});

app.Run();
