using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entities
{
     class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }




        public override string ToString()
        {
            return Nome + ", " + Email + ", " + Salario;
        }
    }
}
