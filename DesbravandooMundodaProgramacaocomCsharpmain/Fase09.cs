using System; // Importa a biblioteca necessária para o uso do Console.

class Program // Define a classe "Program".
{
    static void Main() // Ponto de entrada do programa.
    {
        Console.Write("Digite o primeiro número: "); // Solicita o primeiro número.
        double num1 = double.Parse(Console.ReadLine()); // Lê o primeiro número e converte para double.

        Console.Write("Digite o segundo número: "); // Solicita o segundo número.
        double num2 = double.Parse(Console.ReadLine()); // Lê o segundo número e converte para double.

        double soma = num1 + num2; // Realiza a soma dos dois números.
        double subtracao = num1 - num2; // Realiza a subtração.
        double multiplicacao = num1 * num2; // Realiza a multiplicação.
        double divisao = num1 / num2; // Realiza a divisão.

        Console.WriteLine("Soma: " + soma + ", Subtração: " + subtracao + ", Multiplicação: " + multiplicacao + ", Divisão: " + divisao); // Exibe os resultados das operações.
        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar o terminal.
    }
}
