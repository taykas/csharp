using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Tarefas> tarefas = [];

app.MapGet("tarefas", () => tarefas);

app.MapPost("Cadastrar", ([FromBody] Tarefas tarefa) =>
{
    if (tarefa.Titulo is null || tarefa.Titulo.Length < 1)
        return Results.BadRequest("O título da tarefa deve ser maior");
    tarefas.Add(tarefa);
    return Results.Ok("Tarefa cadastrada com sucesso");
});

app.MapPatch("Editar/{id}/{Concluido}", (int id, bool Concluido) => tarefas);

app.Run();

public record Tarefas(int ID, string Titulo, bool Concluido);