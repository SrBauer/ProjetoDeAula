namespace AtvAssociacao;

public class Matricula
{
    public long numero { get; private set; }
    public DateTime dataCriacao { get; private set; }

    public Matricula(long numero)
    {
        this.numero = numero;
        this.dataCriacao = DateTime.Now;
    }
}