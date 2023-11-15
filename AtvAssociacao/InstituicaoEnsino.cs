
namespace AtvAssociacao;

public class InstituicaoEnsino
{
    public string nome { get; set; }
    public List<Professor> professores { get; private set; }
    public List<Receita> receitas { get; private set; }
    public List<Despesa> despesas { get; private set; }

    public InstituicaoEnsino(string nome)
    {
        this.nome = nome;
        professores = new List<Professor>();
        receitas = new List<Receita>();
        despesas = new List<Despesa>();

    }

    public void addProfessor(Professor professor)
    {
        professores.Add(professor);
    }
    
    public void removeProfessor(Professor professor)
    {
        professores.Remove(professor);
    }
    public void adicionarReceita(Receita receita)
    {
        receitas.Add(receita);
    }

    public void adicionarDespesa(Despesa despesa)
    {
        despesas.Add(despesa);
    }


    public string mostrarLista()
    {
        string message = "";
        
        if (professores.Count > 0)
        {
            message += $"\nInstituição {this.nome}\n";
            
            foreach (var item in professores)
            {
                message += item.mostrarDados();
            }

            return message;
        }
        else
        {
            return $"A instituição {this.nome} não existe professores associados.";
        }
    }
    

}