using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Grazi";
            Console.WriteLine(p.Nome);
        }
    }

    class Pessoa
    {
        //Atributos
        private string nome;

        //Get e Set
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }
}