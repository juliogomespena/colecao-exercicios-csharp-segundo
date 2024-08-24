class ProdutosDeInvestimento
{

    private string nomeProduto;
    public string NomeProduto
    {

        get => nomeProduto;

        set
        {

            //Teste de manipulação, inserindo um banco proibido e ao detectar produto do mesmo
            //retorna a mensagem: Banco não permitido!
            value = value.ToUpper();

            if (value.Contains("JP MORGAN"))
            {

                nomeProduto = "Banco não permitido!";

            }
            else
            {

                nomeProduto = value;

            }

        }

    }

    public string Emissor => GerarEmissor();
    private string GerarEmissor()
    {

        //Simulacao de Emissor vindo de algum servidor
        //Teste de manipulação, caso o número do emissor seja menor que 1, o que no 
        //caso seria inválido, retorna a mensagem: Erro!
        int numeroEmissor;
        string emissor;

        Random random = new Random();
        numeroEmissor = random.Next(-10, 100);

        if (numeroEmissor < 1)
        {

            emissor = "Erro!";
            return emissor;

        }
        else
        {

            emissor = numeroEmissor.ToString();

            return emissor;

        }

    }

    public int Id => GerarId();
    private int GerarId()
    {

        //simulação de id vindo de algum servidor.
        Random random = new Random();
        return random.Next(1, 1000);

    }

    private string quantidadeDisponivel;
    public string QuantidadeDisponivel 
    {

        //teste de manipulacao, caso o valor em quantidade seja negativo
        //retorna a mensagem: Erro!

        get => quantidadeDisponivel;
        
        set
        {

            int numeroQuantidade;

            numeroQuantidade = int.Parse(value);

            if(numeroQuantidade > 0)
            {

                quantidadeDisponivel = numeroQuantidade.ToString();

            }
            else
            {

                quantidadeDisponivel = "Erro!";

            }

        }
    
    }

}