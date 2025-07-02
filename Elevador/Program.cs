// Interface que simula o funcionamento de um elevador
// o metodo é sempre quem esta recebendo a mensagem

var predio = new Predio();
var controlador = new Controlador();

var AndarUm = new Andar
{
    Numero = 1,
};
predio.Andares.Add(AndarUm);
var painelUm = new PainelSimples(controlador, AndarUm);
AndarUm.Painel = painelUm;

var AndarDois = new Andar
{
    Numero = 2,
};
predio.Andares.Add(AndarDois);
var painelDois = new PainelSimples(controlador, AndarDois);
AndarDois.Painel = painelDois;

public class Controlador
{
    public Predio predio { get; set; }
    public List<Pedido> Pedido { get; set; } = [];
    public IAlgoritimo Algoritimo { get; set; }
    public void Solicitar(Pedido pedido)
    {
        Pedidos.Add(pedido);

        var rotas = Algoritimo.CalcularRota(pedido, Predio);
        foreach (var (elevador, andar) in rotas)
        {
            elevador.MovimentarPara(andar);
        }
    }
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

public class PainelSimples(Controlador controlador) : IPainel
{
    public void Apertar(string botao)
    {
        if(botao == "chamar")
        {
            controlador.Pedido.Add(new Pedido
            {
                
            });
        }
    }
}

public interface IAlgoritimo
{
    Dictionary<Elevador, Andar> CalcularRota(List<Pedido> pedidos, List<Elevador> elevadores);
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
    public Queue<Pedido> Blabla = [];
    public Andar Andar { get; set; }
    public IPainel Painel { get; set; }
    public Controlador Controlador { get; set; }
    public int Capacidade { get; set; }
    public bool MovimentarPara(Andar alvo)
    {
        proximos.Enqueue(alvo);
        return true;
    }
}