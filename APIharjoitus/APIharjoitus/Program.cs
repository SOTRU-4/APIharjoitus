using APIharjoitus;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<QuestDB>(opt => opt.UseInMemoryDatabase("QuestList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

app.MapPost("/quest", async (Quest quest, QuestDB db) =>
{
    db.Quests.Add(quest);
    await db.SaveChangesAsync();

    return Results.Created($"/quest/{quest.Id}", quest);
});

app.MapGet("/", () => "Hello World!");

app.Run();
