public class MaquinaCafe
{
    Queue<Pedido> proximos = [];
    public ISabores sabores { get; set; }
    public Painel painel { get; set; }

}

public class Comando
{
    public List<Pedido> Pedidos { get; set; } = [];
}

public class Compartimento
{
    public int Numero { get; set; }
}

public interface ISabores
{
    public string Ingrediente { get; set; }
}

public class Cafe : ISabores
{
    public string Ingrediente
        => "Café";
}

public class Painel
{
    public int TamanhoCopo { get; set; }
}

public class Pedido
{
    public MaquinaCafe Maquina { get; set; }
    public ISabores Sabor { get; set; }
    public Comando Comando { get; set; }
}