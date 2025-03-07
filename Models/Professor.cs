using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor (string nome) : base(nome){

        }
        public decimal Salario {get; set;}

        public override void Apresentar()
        {
            Console.WriteLine($"olá, meu nome é {Nome} tenho {Idade} anos e ganho {Salario} de salário mensal.");
        }
    }
}