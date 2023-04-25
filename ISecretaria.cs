using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIP
{
    interface ISecretaria
    {
      public void Add(Aluno a);
      public void Remove(Aluno a);
      public List<Aluno> List();
      public void Edit(Aluno a, string nome, string matricula, Curso c, List<Nota> n);
    }
}