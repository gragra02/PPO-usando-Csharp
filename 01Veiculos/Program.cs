using System;

class Program
{
    static void Main(string[] args)
    {
        Carro carro = new Carro { Marca = "Ford", Ano = 2020, Portas = 4 };

        carro.Ligar(); 
    }
}
