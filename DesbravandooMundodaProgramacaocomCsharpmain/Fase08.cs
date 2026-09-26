using System; // Importa a biblioteca necessária para usar o Console.

class Program // Define a classe "Program".
{
    static void Main() // O método Main é o ponto de entrada do código.
    {
        Saudacao(); // Chama a função Saudacao, que será definida abaixo.
        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar o terminal.
    }

    static void Saudacao() // Define o método "Saudacao", que exibe uma mensagem de boas-vindas.
    {
        Console.WriteLine("Bem-vindo ao programa!"); // Exibe a mensagem de boas-vindas no terminal.
    }
}
