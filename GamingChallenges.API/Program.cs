using GamingChallenges.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// SERVIÇOS
builder.Services.AddOpenApi();
builder.Services.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();


app.Run();
