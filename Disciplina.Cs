using System;
using System.Collections.Generic;

namespace EscolaDeTecnologia
{
    internal class Disciplina
    {
        private List<Aluno> alunos;
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }

        public Disciplina(int id, string descricao, Curso curso)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Curso = curso;
            this.alunos = new List<Aluno>();
        }

        public bool MatricularAluno(Aluno aluno)
        {
            if (alunos.Count < 15)
            {
                alunos.Add(aluno);
                aluno.MatricularEmDisciplina(this);
                return true;
            }
            else
            {
                Console.WriteLine("Máximo de alunos atingido para a disciplina.");
                return false;
            }
        }

        public bool DesmatricularAluno(Aluno aluno)
        {
            return alunos.Remove(aluno);
        }

        public List<Aluno> Alunos
        {
            get { return alunos; }
        }

        public override string ToString()
        {
            return $"Disciplina {Id}: {Descricao} ({alunos.Count} alunos matriculados)";
        }
    }
}
