using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando um objeto da classe Pessoa
            Pessoa obj = new Pessoa();
            obj.nome = "João";
            obj.idade = 30; 
            obj.mensagem();
        }
    }
}