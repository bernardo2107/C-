using System; // Importa a biblioteca para usar o Console.

class Program // A classe "Program" onde o código será executado.
{
    static void Main() // Ponto de entrada no método Main.
    {
        for (int i = 1; i <= 5; i++) // Laço que começa em 1 e vai até 5.
        {
            Console.WriteLine("Contagem: " + i); // Exibe o valor de i a cada iteração.
        }

        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar o terminal.
    }
}
