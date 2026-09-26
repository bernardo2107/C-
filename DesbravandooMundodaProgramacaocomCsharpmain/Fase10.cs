using System; // Importa a biblioteca necessária.

class Program // A classe "Program" onde o código é executado.
{
    static void Main() // Ponto de entrada do programa.
    {
        string senhaCorreta = "senha123"; // A senha correta que será comparada.

        Console.Write("Digite a senha: "); // Solicita a senha ao usuário.
        string senha = Console.ReadLine(); // Lê a senha digitada.

        if (senha == senhaCorreta) // Verifica se a senha digitada é a correta.
        {
            Console.WriteLine("Senha correta! Acesso permitido."); // Exibe mensagem de acesso permitido.
        }
        else // Se a senha não for correta, exibe a mensagem de erro.
        {
            Console.WriteLine("Senha incorreta! Acesso negado.");
        }

        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar o terminal.
    }
}
