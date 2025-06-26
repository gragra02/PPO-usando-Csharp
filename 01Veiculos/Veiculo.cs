using System;

public class Veiculo
{
    public string Marca;
    public int Ano;

    public virtual void Ligar()
    {
        Console.WriteLine("Veículo ligado");
    }
}
