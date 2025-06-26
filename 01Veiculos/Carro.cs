using System;

// Carro herda de Veiculo
public class Carro : Veiculo
{
    public int Portas;

    public override void Ligar()
    {
        Console.WriteLine("Carro ligado");
    }
}
