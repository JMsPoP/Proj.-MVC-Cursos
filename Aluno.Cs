using System;
using System.Collections.Generic;

namespace EscolaDeTecnologia
{
    internal class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        private List<Disciplina> disciplinas = new List<Disciplina>();

        public Aluno(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public bool podeMatricular(Curso curso)
        {
            return this.disciplinas.Count < 6;
        }

        public void MatricularEmDisciplina(Disciplina disciplina)
        {
            if (this.podeMatricular(disciplina.Curso))
            {
                this.disciplinas.Add(disciplina);
            }
            else
            {
                Console.WriteLine("O aluno já está matriculado no número máximo de disciplinas.");
            }
        }

        public List<Disciplina> Disciplinas
        {
            get { return disciplinas; }
        }

        public override string ToString()
        {
            return $"Aluno {Id}: {Nome}";
        }
    }
}
