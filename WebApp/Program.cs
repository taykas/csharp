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

// ao colocar entre chaves na url, o numero precisa ser colocado obrigatoriamente
app.MapPut("valor/oto/{newValor}", (int newValor) =>
{
    valor += newValor;
    return $"Valor incrementado! valor atual: {valor}";
});

app.Run();