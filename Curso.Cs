using System;
using System.Collections.Generic;

namespace EscolaDeTecnologia
{
    internal class Curso
    {
        private List<Disciplina> disciplinas;
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Curso(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.disciplinas = new List<Disciplina>();
        }

        public bool AdicionarDisciplina(Disciplina disciplina)
        {
            if (disciplinas.Count < 12)
            {
                disciplinas.Add(disciplina);
                return true;
            }
            else
            {
                Console.WriteLine("Máximo de disciplinas atingido para o curso.");
                return false;
            }
        }

        public Disciplina PesquisarDisciplina(Disciplina disciplina)
        {
            return disciplinas.Find(d => d.Id == disciplina.Id);
        }

        public bool RemoverDisciplina(Disciplina disciplina)
        {
            if (disciplina.Alunos.Count == 0)
            {
                return disciplinas.Remove(disciplina);
            }
            else
            {
                Console.WriteLine("A disciplina ainda possui alunos matriculados.");
                return false;
            }
        }

        public List<Disciplina> Disciplinas
        {
            get { return disciplinas; }
        }

        public override string ToString()
        {
            return $"Curso {Id}: {Descricao}";
        }
    }
}
