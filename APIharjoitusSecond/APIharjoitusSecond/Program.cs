using APIharjoitusSecond;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


builder.Services.AddDbContext<QuestDB>(opt => opt.UseInMemoryDatabase("QuestList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

app.MapPost("/quest", async (Quest quest, QuestDB db) =>
{
    db.Quests.Add(quest);
    await db.SaveChangesAsync();

    return Results.Created($"/quest/{quest.Id}", quest);
});
app.MapGet("/quest", () => "Hello quest!");

app.MapGet("/todoitems/{id}", async (int id, QuestDB db) =>
    await db.Quests.FindAsync(id)
        is Quest quest
            ? Results.Ok(quest)
            : Results.NotFound());

app.Run();
