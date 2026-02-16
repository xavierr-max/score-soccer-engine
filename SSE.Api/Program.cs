using SSE.Application.PlayerContext.UserCases.Create;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<Handler>();

var app = builder.Build();

app.MapPost("/v1/teste", async (
        Handler handler,
        Command command)
    => await handler.Handle(command));

app.Run();