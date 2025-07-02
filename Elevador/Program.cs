// Interface que simula o funcionamento de um elevador

public class Controlador
{
    public Predio predio { get; set; }
    public List<Pedido> Pedido { get; set; } = [];
    public IAlgoritimo Algoritimo { get; set; }
}

public class Pedido
{
    public IPainel Painel { get; set; }
    public Andar? Andar { get; set; }
    public Elevador? Elevador { get; set; }
    public string Tag { get; set; }
}

public interface IPainel
{

}

public interface IAlgoritimo
{

}

public class Andar
{
    public int Numero { get; set; }
    public IPainel Painel { get; set; }
}

public class Predio
{
    public List<Andar> Andares { get; set; } = [];
    public List<Elevador> Elevadores { get; set; } = [];
}

public class Elevador
{
    public Andar Andar { get; set; }
    public IPainel Painel { get; set; }
    public Controlador Controlador { get; set; }
    public int Capacidade { get; set; }

}