namespace AtvAssociacao;

public class Sala
{
    public string nome { get; set; }
    public int capacidade { get; set; }

    public Sala(string nome, int capacidade)
    {
        this.nome = nome;
        this.capacidade = capacidade;
    }

    public string mostrarDados()
    {
        return $"\nSala: {this.nome};" +
                         $"\nCapacidade: {this.capacidade}";
        
    }
}