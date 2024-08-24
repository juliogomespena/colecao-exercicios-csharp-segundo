using System.Security.Cryptography;
using System.Text.RegularExpressions;

ContaBancaria conta01 = new();

conta01.id = 1;
conta01.titular = "Julio Gomes Pena";
conta01.saldo = 9521312.12m;
conta01.senha = "980021";

conta01.ExibirInformacoes();