ContaBancaria conta01 = new()
{

    Titular = "Julio Gomes Pena",
    Saldo = 1000000000.56m,
    Senha = "980021",

};

ProdutosDeInvestimento produtoDeInvestimento01 = new()
{

    NomeProduto = "Goldman sachs early inflation + 0.25%",
    QuantidadeDisponivel = "25"

};

conta01.ExibirInformacoes();

Console.WriteLine("\n\n");

Console.WriteLine($"Produto: {produtoDeInvestimento01.NomeProduto} || ID: {produtoDeInvestimento01.Id} || Emissor: {produtoDeInvestimento01.Emissor} || Quantidade disponível: {produtoDeInvestimento01.QuantidadeDisponivel}");

Console.WriteLine("\n\n");