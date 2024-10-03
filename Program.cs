// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");//

using TesteDeEncapsulamento;
class Programa
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        Console.Write("Digite o nome: ");
        pessoa.Nome = Console.ReadLine();
        Console.Write("Digite a idade: "); int.TryParse(Console.ReadLine(), out int idade);
        pessoa.Idade = idade;
        Console.Write("Digite o telefone: "); pessoa.Telefone = Console.ReadLine();
        Console.Write("Digite o endereço: ");
        pessoa.Endereco = Console.ReadLine();
        Console.Write("Digite o e-mail: "); pessoa.Email = Console.ReadLine();
        pessoa.ExibirInformacoes();
    }
}

