namespace AtvAssociacao;

public class Turma
{
    public string nome { get; set; }
    public string periodo { get; set; }

    public Turma(string nome, string periodo)
    {
        this.nome = nome;
        this.periodo = periodo;
    }

    
    public string mostrarDados()
    {
        return $"\nTurma {this.nome}" +
                 $"\nPeríodo: {this.periodo}";
    }
}