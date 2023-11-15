namespace AtvAssociacao;

public class Professor : Pessoa
{
    public int numeroMatricula { get; private set; }
    public Endereco? endereco { get; private set; }

    public Professor(string nome, string sexo, int numeroMatricula)
    {
        this.nome = nome;
        this.sexo = sexo;
        this.numeroMatricula = numeroMatricula;
        this.endereco = null;
    }
    
    public Professor(string nome, string sexo, int numeroMatricula, Endereco endereco)
    {
        this.nome = nome;
        this.sexo = sexo;
        this.numeroMatricula = numeroMatricula;
        this.endereco = endereco;
    }

    public bool cadastrarEndereço(Endereco endereco)
    {
        if (endereco == null)
        {
            return false; 
        }

        return true;
    }

    public string mostrarDados()
    {
        string msgEnd = endereco != null ? (endereco.rua + ", " + endereco.numero) : "Não existe endereço associado ";
        
        return $"\nNome: {this.nome};" +
               $"\nSexo: {this.sexo};" +
               $"\nMatricula: {this.numeroMatricula};" +
               $"\nEndereco: {msgEnd};\n";

    }
    
}
