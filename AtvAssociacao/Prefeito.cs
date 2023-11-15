namespace AtvAssociacao;

public class Prefeito : Pessoa
{
    public string partido { get; private set; }
    
    public Cidade cidade { get; private set; }

    public Prefeito(string partido, Cidade cidade)
    {
        this.partido = partido;
        this.cidade = cidade;
    }
}