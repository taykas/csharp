// Interface que simula o funcionamento de um elevador

public class Controlador
{
    public List<Elevador> Elevadores { get; set; } = [];
}

public interface IPainel
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