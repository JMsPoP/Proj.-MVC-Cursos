using System;

namespace EscolaDeTecnologia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();
            int opcao;

            do
            {
                Console.WriteLine("0. Sair\n1. Adicionar curso\n2. Pesquisar curso\n3. Remover curso\n4. Adicionar disciplina no curso\n5. Pesquisar disciplina\n6. Remover disciplina do curso\n7. Matricular aluno na disciplina\n8. Remover aluno da disciplina\n9. Pesquisar aluno");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o ID do curso: ");
                        int idCurso = int.Parse(Console.ReadLine());
                        Console.Write("Digite a descrição do curso: ");
                        string descricaoCurso = Console.ReadLine();
                        Curso novoCurso = new Curso(idCurso, descricaoCurso);
                        escola.AdicionarCurso(novoCurso);
                        break;

                    case 2:
                        Console.Write("Digite o ID do curso a pesquisar: ");
                        idCurso = int.Parse(Console.ReadLine());
                        Curso cursoEncontrado = escola.PesquisarCurso(new Curso(idCurso, ""));
                        if (cursoEncontrado != null)
                        {
                            Console.WriteLine(cursoEncontrado);
                            foreach (var disciplina in cursoEncontrado.Disciplinas)
                            {
                                Console.WriteLine(disciplina);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Curso não encontrado.");
                        }
                        break;

                    case 3:
                        Console.Write("Digite o ID do curso a remover: ");
                        idCurso = int.Parse(Console.ReadLine());
                        cursoEncontrado = escola.PesquisarCurso(new Curso(idCurso, ""));
                        if (cursoEncontrado != null && escola.RemoverCurso(cursoEncontrado))
                        {
                            Console.WriteLine("Curso removido com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível remover o curso.");
                        }
                        break;


                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 0);
        }
    }
}
