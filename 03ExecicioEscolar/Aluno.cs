using System;
class Aluno
{
    // Atributos

    public string nome;
    public double nota1, nota2;

    // Média
    public double media()
    {
        return (nota1 + nota2) / 2;
    }
    //Situação
    public string situacao(double media)
    {
      return media >= 7 ? "Aprovado" : "Reprovado";   
    }
    //Mensagem

    public void mensagem()
    {
        // Obter média
        double obterMedia = media();
        // Obter situação
        string obterSituacao = situacao(obterMedia);
        Console.WriteLine(nome + " sua média é " + obterMedia + " e você está " + obterSituacao + ".");
    }
}