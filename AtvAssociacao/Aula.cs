namespace  AtvAssociacao;

public class Aula
{
    public DateTime dateStart { get; set; }
    public DateTime dateEnd { get; set; }
    public Sala sala { get; set; }
    public Turma turma { get; set; }
    public Professor professor { get; set; }

    public Aula(DateTime dateStart, DateTime dateEnd, Sala sala, Turma turma, Professor professor)
    {
        this.dateStart = dateStart;
        this.dateEnd = dateEnd;
        this.sala = sala;
        this.turma = turma;
        this.professor = professor;
    }

    public string mostrarDados()
    {
        return $"\nData Inicio: {this.dateStart.ToString()};" +
               $"\nData Fim: {this.dateEnd.ToString()};" +
               $"\nSala: {this.sala.nome};" +
               $"\nTurma: {this.turma.nome};" +
               $"\nProfessor: {this.professor.nome};";
    }
}