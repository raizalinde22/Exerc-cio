using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeEncapsulamento;
class Pessoa
{
    private string nome; private int idade;
    private string telefone; private string endereco;
    private string email;
    public string Nome
    {
        get { return nome; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nome = value;
            else
                Console.WriteLine("Nome inválido!");
        }
    }
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value >= 0)
                idade = value;
            else
                Console.WriteLine("Idade inválida!");
        }
    }
    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }
    public string Endereco
    {
        get { return endereco; }
        set { endereco = value; }
    }

    public string Email
    {
        get { return email; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                email = value;
            else
                Console.WriteLine("E-mail inválido!");
        }
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine("\nInformações:"); Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Telefone: {Telefone}"); Console.WriteLine($"Endereço: {Endereco}");
        Console.WriteLine($"E-mail: {Email}");
    }
}
