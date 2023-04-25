using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIP
{
    class Secretaria : ISecretaria
    {

    private List<Aluno> alunos = new List<Aluno>();
      public void Add(Aluno a)
      {
        alunos.Add(a);
      }
      public void Remove(Aluno a)
      {
        alunos.Remove(a);
      }
      public void Edit(Aluno a, string nome, string matricula, Curso c, List<Nota> n)
      {
        a.nome = nome;
        a.matricula = matricula;
        a.curso = c;
        a.nota = n;
      }
      public List<Aluno> List()
      {
        return alunos;
      }
      
    }
}