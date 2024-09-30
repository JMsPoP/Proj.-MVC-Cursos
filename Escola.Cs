using System;
using System.Collections.Generic;

namespace EscolaDeTecnologia
{
    internal class Escola
    {
        private List<Curso> cursos;

        public Escola()
        {
            cursos = new List<Curso>();
        }

        public bool AdicionarCurso(Curso curso)
        {
            if (cursos.Count < 5)
            {
                cursos.Add(curso);
                return true;
            }
            else
            {
                Console.WriteLine("Máximo de cursos atingido.");
                return false;
            }
        }

        public Curso PesquisarCurso(Curso curso)
        {
            return cursos.Find(c => c.Id == curso.Id);
        }

        public bool RemoverCurso(Curso curso)
        {
            if (curso.Disciplinas.Count == 0)
            {
                return cursos.Remove(curso);
            }
            else
            {
                Console.WriteLine("O curso ainda possui disciplinas associadas.");
                return false;
            }
        }

        public List<Curso> Cursos
        {
            get { return cursos; }
        }
    }
}
