namespace AtvAssociacao;

public class Endereco: ILocalizacao
{
    public string rua { get; private set; }
    public int numero { get; private set; }
    public Cidade cidade { get; private set; }
    public long cep { get; private set; }

    public Endereco()
    {
    }

    public Endereco(string rua, int numero, Cidade cidade, long cep)
    {
        this.rua = rua;
        this.numero = numero;
        this.cidade = cidade;
        this.cep = cep;
    }

    public string Mapabase64(float latitude, float longitude)
    {
        throw new NotImplementedException();
    }
}