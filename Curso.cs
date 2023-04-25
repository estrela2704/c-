using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIP
{
    class Curso
    {
      public string nome{ get; set; }
      public string codigo{ get; set; }

      public Curso(){}

      public Curso(string nome, string codigo)
      {
        this.nome = nome;
        this.codigo = codigo;
      }

    }
}