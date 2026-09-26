using System; // Importa a biblioteca necessária.

class Program // A classe "Program" contém o código a ser executado.
{
    static void Main() // Ponto de entrada no método Main.
    {
        int i = 1; // Inicializa a variável 'i' com valor 1.

        while (i <= 5) // O laço irá se repetir enquanto 'i' for menor ou igual a 5.
        {
            Console.WriteLine("Contagem: " + i); // Exibe o valor de 'i'.
            i++; // Incrementa o valor de 'i' a cada repetição.
        }

        Console.ReadLine(); // Aguarda o usuário pressionar Enter antes de fechar o terminal.
    }
}
