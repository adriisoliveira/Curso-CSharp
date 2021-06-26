using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Funcionario
    {
        public int Id {get; set;}
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario() { }
        public Funcionario(int id, string nome, double salario)
        {
            this.Id = id;
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}
