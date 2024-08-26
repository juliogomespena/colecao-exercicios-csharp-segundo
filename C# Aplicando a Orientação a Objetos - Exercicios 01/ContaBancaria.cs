class ContaBancaria
{

    public int Id 
    {

        get
        {

            Random random = new();
            
            return random.Next(1, 1001);

        }
    
    }
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    
    private decimal saldo;
    public decimal Saldo 
    {

        get => saldo;
        
        set
        {

            if (value > 5000000)
            {
     
                saldo = value;
                titulo = "Sr./Sra. ";
            }
            else
            {

                saldo = value;
                titulo = "";
                
            }

        }

    }
    public decimal Limite { get; set; }
    public string Senha { get; set; }
    public string Credenciais => $"{Titular.Nome}: ID: {Id} || Senha: {Senha}";

    private string titulo;
    public string ExibirCliente => $"{titulo}{Titular.Nome}";


    public void ExibirInformacoes()
    {

        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Titular: {ExibirCliente}");
        Console.WriteLine($"Endereço: {Titular.Endereco}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");

    }

}