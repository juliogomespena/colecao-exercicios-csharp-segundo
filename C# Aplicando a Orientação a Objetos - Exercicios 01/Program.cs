Titular titular01 = new()
{

    Nome = "Julio Gomes Pena",
    Endereco = "Rua Hacib Kalaf, 255 - Jardim Paulista II - Jundiaí/SP - Brasil"

};

ContaBancaria conta01 = new()
{

    Titular = titular01,
    Agencia = 10,
    NumeroDaConta = 2928495,
    Limite = 9999999999999,
    Saldo = 1000000000.56m,
    Senha = "980021",


};

ProdutosDeInvestimento produtoDeInvestimento01 = new()
{

    NomeProduto = "Goldman sachs early inflation + 0.25%",
    QuantidadeDisponivel = "25"

};



conta01.ExibirInformacoes();

//Console.WriteLine("\n\n");

//Console.WriteLine($"Produto: {produtoDeInvestimento01.NomeProduto} || ID: {produtoDeInvestimento01.Id} || Emissor: {produtoDeInvestimento01.Emissor} || Quantidade disponível: {produtoDeInvestimento01.QuantidadeDisponivel}");

//Console.WriteLine("\n\n");