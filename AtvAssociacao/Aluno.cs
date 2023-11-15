using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvAssociacao
{
    public class Aluno : Pessoa
    {
        public Aluno? colegaAtividade { get; set; }
        public Matricula matricula { get; private set; }
        
        public Aluno(string nome, string sexo, long numero) 
        {
            this.nome = nome;
            this.sexo = sexo;
            this.matricula = new Matricula(numero);
        }

        public void realizarProvaCom(Aluno aluno2)
        {
            if (this.colegaAtividade == null && aluno2.colegaAtividade == null)
            {
                this.colegaAtividade = aluno2;
                aluno2.colegaAtividade = this;
            }
            else 
            {
                Console.WriteLine("Aluno já associado à uma dupla");
            }
        }

        public void Mostrar()
        {
            Console.WriteLine($"\nNome: {this.nome}; " +
                              $"\nSexo: {this.sexo};" +
                              $"\nDupla: {this.colegaAtividade?.nome};");
        }
    }
}
