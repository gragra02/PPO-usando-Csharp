class Pessoa
{
    public double peso, altura;
    public double calculo()
    {
        // Calcular IMC
        return peso / (altura * altura);

    }

    //Variavel
    string retorno;

    //Situação
    public string situacao(double imc)

    {

        //Variavel retorno
        string retorno;

        //Condicional

        if (imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }

        else if (imc >= 18.5 && imc < 24.9)
        {
            retorno = "Peso normal";
        }
        else if (imc >= 25 && imc < 29.9)
        {
            retorno = "Sobrepeso";
        }
        else if (imc >= 30 && imc < 34.9)
        {
            retorno = "Obesidade grau I";
        }
        else if (imc >= 35 && imc < 39.9)
        {
            retorno = "Obesidade grau II";
        }
        else
        {
            retorno = "Obesidade grau III";
        }

        return retorno;
    }

    //Mensagem

    public void mensagem()
    {
        // Exibir resultado
        double obeterCalculo = calculo();
        string oberterSituacao = situacao(obeterCalculo);

        Console.WriteLine("Seu IMC é: " + obeterCalculo);
        Console.WriteLine("Sua situação é: " + oberterSituacao);
    }
}