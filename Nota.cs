
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace UNIP
{
    class Nota
    {
      public string nome{ get; set; }
      public double valor{ get; set; }

      public Nota(){}

      public Nota(string nome, double valor)
      {
        this.nome = nome;
        this.valor = valor;
      }
    }
}