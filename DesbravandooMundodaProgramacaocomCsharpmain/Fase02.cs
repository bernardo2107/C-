using System; // Importa a biblioteca necessária para o uso do Console.

class Program // Define a classe "Program" que contém o código a ser executado.
{
    static void Main() // O método "Main", que é o ponto de entrada do programa.
    {
        int idade = 25; // A variável 'idade' é declarada e recebe o valor 25.
        string nome = "João"; // A variável 'nome' armazena uma string com o valor "João".
        double altura = 1.75; // A variável 'altura' armazena um número decimal (tipo double).

        Console.WriteLine("Nome: " + nome); // Exibe o nome na tela.
        Console.WriteLine("Idade: " + idade); // Exibe a idade na tela.
        Console.WriteLine("Altura: " + altura); // Exibe a altura na tela.
        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar o terminal.
    }
}
