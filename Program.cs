using System.Formats.Asn1;
using System.Runtime.Intrinsics.X86;
using heranca.Models;

// Aluno a1 = new Aluno();
// a1.Nome = "Andrew";
// a1.Email = "teste@teste.com";
// a1.Idade = 20;
// a1.Nota = 10;
// a1.Apresentar();


// Professor p1 = new Professor();
// p1.Nome = "Eduardo";
// p1.Idade = 30;
// p1.Salario = 3000;
// p1.Email = "profssoreduardo@teste.com";
// p1.Apresentar();


// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();

// Pessoa p1 = new Pessoa("Andrew");
// Aluno a1 = new Aluno("Suzan");
// a1.Apresentar();

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));