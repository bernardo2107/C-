using System; // Importa a biblioteca necessária para usar o Console.

class Program // Define a classe "Program" onde o código é executado.
{
    static void Main() // Ponto de entrada do programa.
    {
        Console.Write("Digite sua idade: "); // Solicita ao usuário que informe a idade.
        int idade = int.Parse(Console.ReadLine()); // Lê a idade informada e converte para inteiro.

        if (idade >= 18) // Se a idade for maior ou igual a 18, o código dentro do if será executado.
        {
            Console.WriteLine("Você é maior de idade."); // Exibe se a pessoa é maior de idade.
        }
        else // Caso a condição não seja verdadeira (idade < 18), executa o código abaixo.
        {
            Console.WriteLine("Você é menor de idade."); // Exibe se a pessoa é menor de idade.
        }

        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar o terminal.
    }
}
