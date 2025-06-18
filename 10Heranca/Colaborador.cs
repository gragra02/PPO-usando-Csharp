using System;

class Colaborador : Pessoa
{
    // Atributos
    private double salario;

    //Contrutor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    // Métodos
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: " + salario);
        Console.WriteLine("Colaborador criado com sucesso!");
    }

}