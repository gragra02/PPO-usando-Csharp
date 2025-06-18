using System;

class Programa
{
    static void Main(string[] args)
    {
        // Chamada do método soma
        Exemplo.soma(10, 20);

        // Chamada do método soma com valores diferentes
        Exemplo.soma(5, 15);
        
        Console.WriteLine("O nome é: " + Exemplo.nome);
    }
}