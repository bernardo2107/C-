using System; // Importa a biblioteca necessária.

class Program // Define a classe "Program".
{
    static void Main() // Ponto de entrada do código.
    {
        Console.Write("Digite seu nome: "); // Solicita que o usuário digite seu nome.
        string nome = Console.ReadLine(); // Lê o nome digitado pelo usuário e armazena na variável 'nome'.

        Console.WriteLine("Olá, " + nome + "!"); // Exibe a saudação personalizada para o nome informado.
        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar o terminal.
    }
}
