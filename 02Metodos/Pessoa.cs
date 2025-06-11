using System;
class Pessoa
{
    // Métodos 01
    public void apresentar()
    {
        Console.WriteLine("Olá!!");
    }
    // Métodos 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá " + nome + "!!");
    }

    // Métodoos 03
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá " + nome + " Você tem " + idade + " anos.");
    }   
    
}