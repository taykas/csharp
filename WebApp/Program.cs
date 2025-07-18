
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

// cadastrar tarefas com bool
// tarefas feitas e nao feitas
// poder amrcar que ja existe como tarefa feita

var builder = WebApplication.CreateBuilder(args); // criação da aplicação web
var app = builder.Build();

List<Produto> produtos = [
    new Produto("Bomba", 10),
    new Produto("Bico Injetor", 230)
];

app.MapGet("produtos", () => produtos);

app.MapPost("produtos", ([FromBody]Produto produto) =>
{
    if (produto.Nome is null || produto.Nome.Length < 5)
        return Results.BadRequest("O nome do produto deve ter ao menos 5 letras");
    produtos.Add(produto);
    return Results.Ok("Produto criado com sucesso");
});

int valor = 0;
app.MapPut("valor/add", () =>
{
    valor++;
    return $"Valor incrementado! valor atual: {valor}";
});

app.MapPut("valor/sub", () =>
{
    valor--;
    return $"Valor decrementado! valor atual: {valor}";
});

// formas de pedir parametros

app.MapPut("valor/input", (int newValor = 0) =>
{
    valor += newValor;
    return $"Valor incrementado! valor atual: {valor}";
});

// ao colocar entre chaves na url, o numero precisa ser colocado obrigatoriamente
app.MapPut("valor/oto/{newValor}", (int newValor) =>
{
    valor += newValor;
    return $"Valor incrementado! valor atual: {valor}";
});

app.Run();

public record Produto(string Nome, decimal Preco);
