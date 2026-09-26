using System; // Importa a biblioteca para usar o Console.

class Program // A classe Program onde o código será executado.
{
    static void Main() // Início da execução no método Main.
    {
        int a = 10, b = 5; // Declara duas variáveis 'a' e 'b' e atribui os valores 10 e 5, respectivamente.
        int soma = a + b; // A variável 'soma' armazena o resultado da soma de 'a' e 'b'.
        int produto = a * b; // A variável 'produto' armazena o resultado da multiplicação de 'a' e 'b'.

        Console.WriteLine("Soma: " + soma); // Exibe o resultado da soma no terminal.
        Console.WriteLine("Produto: " + produto); // Exibe o resultado do produto no terminal.
        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar o terminal.
    }
}
