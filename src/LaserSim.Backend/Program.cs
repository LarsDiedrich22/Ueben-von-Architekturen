var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Laser-Sim Backend läuft!");
app.MapGet("/health",() => Results.Ok("Laser-Sim Backend läuft!"));


app.Run();
