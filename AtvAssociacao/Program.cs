namespace AtvAssociacao
{
    public class Program
    {
        static void Main(string[] args)
        {
            InstituicaoEnsino escola = new InstituicaoEnsino("Senac Blumenau");
            
            Aluno a1 = new Aluno("Amanda", "Feminino", 1111111111);
            Aluno a2 = new Aluno("Nicolas", "Masculino", 22222222222);
            Aluno a3 = new Aluno("Gustavo", "Masculino", 333333333333);


            Cidade cidade = new Cidade("Blumenau", "SC");
            
            Endereco end = new Endereco("Rua Senac", 57, cidade, 37128931);

            Sala sala1 = new Sala("S101", 32);
            Turma turma1 = new Turma("T101", "Matutino");
            Turma turma2 = new Turma("T102", "Vespertino");
            Turma turma3 = new Turma("T103", "Matutino");
            Turma turma4 = new Turma("T104", "Vespertino"); 
            
            

            Professor p1 = new Professor("Alana", "Masculino", 123);
            Professor p2 = new Professor("Pessoa1", "Feminino", 123);
            Professor p3 = new Professor("Pessoa2", "Masculino", 123);
            Professor p4 = new Professor("Pessoa3", "Feminino", 123);
            
            escola.addProfessor(p1);
            escola.addProfessor(p2);
            escola.addProfessor(p3);
            
            p1.cadastrarEndereço(end);

            DateTime dataStart = new DateTime(2023, 10, 17, 19, 30, 0);
            DateTime dataEnd = new DateTime(2023, 10, 17, 20, 15, 0);
            Aula aula = new Aula(dataStart, dataEnd, sala1, turma1, p1);


            Console.WriteLine(aula.mostrarDados());

            InstituicaoEnsino minhaInstituicao = new InstituicaoEnsino("Minha Instituição");

            Receita receita1 = new Receita("Taxa de matrícula", 1000.00f);
            Receita receita2 = new Receita("Doação", 500.00f);

            Despesa despesa1 = new Despesa("Material de escritório", 200.00f);
            Despesa despesa2 = new Despesa("Energia elétrica", 300.00f);

            minhaInstituicao.adicionarReceita(receita1);
            minhaInstituicao.adicionarReceita(receita2);
            minhaInstituicao.adicionarDespesa(despesa1);
            minhaInstituicao.adicionarDespesa(despesa2);



        }
    }
}