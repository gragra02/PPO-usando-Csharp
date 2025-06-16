class Pessoa
{
    // Atributo
    private string name = "Default Name";

    public Pessoa(string name)
    {
        // Usando this para referenciar o atributo da classe
        Console.WriteLine(name);
        Console.WriteLine(this.name);
        this.name = name;
        Console.WriteLine(this.name);
    }
}
