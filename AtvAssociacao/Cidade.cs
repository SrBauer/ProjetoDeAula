namespace AtvAssociacao;

public class Cidade : ILocalizacao
{
    public string nome { get; private set; }
    public string siglaUF { get; private set; }

    public Cidade(string nome, string siglaUf)
    {
        this.nome = nome;
        this.siglaUF = siglaUf;

    }

    public string Mapabase64(float latitude, float longitude)
    {
        throw new NotImplementedException();
    }
}