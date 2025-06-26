using System;

public class Pessoa
{
    // Atributos privados
    private string nome;
    private int idade;
    private string cpf;

    // Propriedades públicas com get e set
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public string CPF
    {
        get { return cpf; }
        set { cpf = value; }
    }

    // Método para apresentar os dados
    public void Apresentar()
    {
        Console.WriteLine("Nome: " + Nome + ", Idade: " + Idade + ", CPF: " + CPF);
    }

    // Método que verifica se o CPF tem 11 dígitos
    public bool ValidarCPF()
    {
        if (CPF != null && CPF.Length == 11)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
