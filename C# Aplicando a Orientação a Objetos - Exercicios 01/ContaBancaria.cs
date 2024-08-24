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
    public string Titular { get; set; }

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
    public string Senha { get; set; }
    public string Credenciais => $"{Titular}: ID: {Id} || Senha: {Senha}";

    private string titulo;
    public string ExibirCliente => $"{titulo}{Titular}";


    public void ExibirInformacoes()
    {

        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Titular: {ExibirCliente}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");

    }

}