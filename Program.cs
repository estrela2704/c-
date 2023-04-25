using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UNIP
{
    class Program
    {
        static void Main(string[] args)
        {
          Secretaria secretaria = new Secretaria();

          //Criacao do aluno 1
          Aluno a1 = new Aluno{
            nome = "Felipe",
            matricula = "12345",
            curso = new Curso {nome = "Analise e Desenvolvimento de Sistemas", codigo = "ADS"},
            nota = new List<Nota> {
              new Nota { nome = "NP1", valor = 10.0},
              new Nota { nome = "NP2", valor = 8.5},
              new Nota { nome = "PIM", valor = 6.9}
            }
          };

          //Criacao do aluno 2
          Aluno a2 = new Aluno{
            nome = "Johnatan",
            matricula = "123456",
            curso = new Curso {nome = "Sistemas da Informação", codigo = "SI"},
            nota = new List<Nota> {
              new Nota { nome = "NP1", valor = 5.0},
              new Nota { nome = "NP2", valor = 7.5},
              new Nota { nome = "PIM", valor = 4.9}
            }
          };

          //Adicionando o aluno a secretaria
          secretaria.Add(a1);
          secretaria.Add(a2);

          double media = a1.CalculaMedia();

          List<Aluno> alunos = secretaria.List();
          foreach (Aluno aluno in alunos)
          {
            Console.WriteLine("Aluno:" + aluno.nome + " Matricula: " + aluno.matricula);
          }
        }
    }
}