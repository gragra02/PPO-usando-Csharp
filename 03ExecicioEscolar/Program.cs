
using System;
class Program
{

    static void Main(string[] args)
    {
        // Criação de um objeto do tipo Aluno
        Aluno a = new Aluno();

        // Atribuição de valores aos atributos
        a.nome = "Lara";
        a.nota1 = 8.5;
        a.nota2 = 10;

        // Chamada do método mensagem para exibir os resultados
        a.mensagem();
    }
}