class ContaBancaria
{

    public int id;
    public string titular;
    public decimal saldo;
    public string senha;

    public void ExibirInformacoes()
    {

        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"Senha: {senha}");

    }

}