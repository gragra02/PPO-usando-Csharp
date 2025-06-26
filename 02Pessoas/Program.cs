using System;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();

        pessoa.Nome = "Grazi";
        pessoa.Idade = 45;
        pessoa.CPF = "12345678901";

        pessoa.Apresentar();

        Console.WriteLine(pessoa.ValidarCPF()); 
    }
}
