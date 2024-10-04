using System;

public class Pessoa
{
    private string nome;
    private int idade;
    private string telefone;
    private string endereco;
    private string email;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O nome não pode ser vazio");
            }
            nome = value;
        }
    }

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0)
            {
              Console.WriteLine("a idade não pode ser negativa");
            }
            idade = value;
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
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine("O email não pode ser vazio");
            }
            email = value;
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Diego";
            pessoa.Idade = -2;
            pessoa.Telefone = "38928091";
            pessoa.Endereco = "Rua 86, casa 90 B";
            pessoa.Email = "diegomarcello@gmail.com";

            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine($"Telefone: {pessoa.Telefone}");
            Console.WriteLine($"Endereço: {pessoa.Endereco}");
            Console.WriteLine($"Email: {pessoa.Email}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}
