var builder = WebApplication.CreateBuilder(args); // criação da aplicação web
var app = builder.Build();

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

app.Run();