while (true)
{
    var op = Console.ReadLine();
    switch (op)
    {
        case "vernome":
            int id = int.Parse(Console.ReadLine());
            System.Console.WriteLine(pegarNomeUsuarioAsync(id));
            break;
        case "sair":
            return;
    }
}

string pegarNomeUsuarioAsync(int IdUsuario)
{
    string[] nomes = ["Don", "Cristian", "Queila"];
    Thread.Sleep(1000);
    return nomes[IdUsuario];
}