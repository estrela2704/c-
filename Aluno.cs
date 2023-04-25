using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIP
{
    class Aluno : IComparable<Aluno>
    {
      public string nome{ get; set; }
      public string matricula{ get; set; }
      public Curso curso{ get; set; }
      public List<Nota>? nota { get; set; }

      public Aluno(){}
      public Aluno(string nome, string matricula, Curso c)
      {
        this.nome = nome;
        this.matricula = matricula;
        this.curso = c;
      }
      public double CalculaMedia()
      {
        double np1 = nota.Find(n => n.nome == "NP1").valor;
        double np2 = nota.Find(n => n.nome == "NP2").valor;
        double pim = nota.Find(n => n.nome == "PIM").valor;

        return (np1 * 4 + pim * 2 + np1 * 4) /10;
      }
      public int CompareTo(Aluno? aluno)
      {
        return nome.CompareTo(aluno.nome);
      }
    }
}