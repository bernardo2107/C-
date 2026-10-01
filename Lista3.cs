using System;

class Program
{
    // ---------- Funções auxiliares de leitura ----------
    static int LerInteiro(string mensagem)
    {
        int valor;
        Console.Write(mensagem);
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.Write("Valor inválido. Digite um número inteiro: ");
        }
        return valor;
    }

    static double LerDouble(string mensagem)
    {
        double valor;
        Console.Write(mensagem);
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.Write("Valor inválido. Digite um número (ex: 3,5): ");
        }
        return valor;
    }

    // ---------- Exercícios ----------

    // a) O primeiro número é maior que o segundo?
    static void ExercicioA()
    {
        int n1 = LerInteiro("Digite o primeiro número inteiro: ");
        int n2 = LerInteiro("Digite o segundo número inteiro: ");

        Console.WriteLine(n1 > n2
            ? $"{n1} é maior que {n2}."
            : $"{n1} NÃO é maior que {n2}.");
    }

    // b) O primeiro número é menor que o segundo?
    static void ExercicioB()
    {
        int n1 = LerInteiro("Digite o primeiro número inteiro: ");
        int n2 = LerInteiro("Digite o segundo número inteiro: ");

        Console.WriteLine(n1 < n2
            ? $"{n1} é menor que {n2}."
            : $"{n1} NÃO é menor que {n2}.");
    }

    // c) Os números são iguais?
    static void ExercicioC()
    {
        int n1 = LerInteiro("Digite o primeiro número inteiro: ");
        int n2 = LerInteiro("Digite o segundo número inteiro: ");

        Console.WriteLine(n1 == n2
            ? "Os números são iguais."
            : "Os números são diferentes.");
    }

    // d) O primeiro é menor que o segundo E maior que o terceiro?
    static void ExercicioD()
    {
        int n1 = LerInteiro("Digite o primeiro número inteiro: ");
        int n2 = LerInteiro("Digite o segundo número inteiro: ");
        int n3 = LerInteiro("Digite o terceiro número inteiro: ");

        if (n1 < n2 && n1 > n3)
            Console.WriteLine($"{n1} é menor que {n2} e maior que {n3}.");
        else
            Console.WriteLine($"{n1} NÃO é menor que {n2} e maior que {n3} ao mesmo tempo.");
    }

    // e) O primeiro é maior ou igual ao segundo? (ponto flutuante)
    static void ExercicioE()
    {
        double n1 = LerDouble("Digite o primeiro número: ");
        double n2 = LerDouble("Digite o segundo número: ");

        Console.WriteLine(n1 >= n2
            ? $"{n1} é maior ou igual a {n2}."
            : $"{n1} NÃO é maior ou igual a {n2}.");
    }

    // f) Par ou ímpar
    static void ExercicioF()
    {
        int n = LerInteiro("Digite um número inteiro: ");

        Console.WriteLine(n % 2 == 0
            ? $"{n} é par."
            : $"{n} é ímpar.");
    }

    // g) O primeiro é menor ou igual ao segundo? (ponto flutuante)
    static void ExercicioG()
    {
        double n1 = LerDouble("Digite o primeiro número: ");
        double n2 = LerDouble("Digite o segundo número: ");

        Console.WriteLine(n1 <= n2
            ? $"{n1} é menor ou igual a {n2}."
            : $"{n1} NÃO é menor ou igual a {n2}.");
    }

    // h) Positivo ou negativo
    static void ExercicioH()
    {
        int n = LerInteiro("Digite um número inteiro: ");

        if (n > 0)
            Console.WriteLine($"{n} é positivo.");
        else if (n < 0)
            Console.WriteLine($"{n} é negativo.");
        else
            Console.WriteLine("O número é zero (nem positivo, nem negativo).");
    }

    // i) A diferença entre eles é menor ou igual a 10?
    static void ExercicioI()
    {
        int n1 = LerInteiro("Digite o primeiro número inteiro: ");
        int n2 = LerInteiro("Digite o segundo número inteiro: ");

        int diferenca = Math.Abs(n1 - n2); // diferença em valor absoluto

        Console.WriteLine(diferenca <= 10
            ? $"A diferença ({diferenca}) é menor ou igual a 10."
            : $"A diferença ({diferenca}) é maior que 10.");
    }

    // j) O número é igual a zero? (ponto flutuante)
    static void ExercicioJ()
    {
        double n = LerDouble("Digite um número: ");

        Console.WriteLine(n == 0
            ? "O número é igual a zero."
            : "O número é diferente de zero.");
    }

    // ---------- Menu principal ----------
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== EXERCÍCIOS C# =====");
            Console.WriteLine("a) Primeiro > segundo");
            Console.WriteLine("b) Primeiro < segundo");
            Console.WriteLine("c) Números iguais");
            Console.WriteLine("d) Primeiro < segundo e > terceiro");
            Console.WriteLine("e) Primeiro >= segundo (float)");
            Console.WriteLine("f) Par ou ímpar");
            Console.WriteLine("g) Primeiro <= segundo (float)");
            Console.WriteLine("h) Positivo ou negativo");
            Console.WriteLine("i) Diferença <= 10");
            Console.WriteLine("j) Igual a zero (float)");
            Console.WriteLine("s) Sair");
            Console.Write("Escolha: ");

            string opcao = (Console.ReadLine() ?? "").Trim().ToLower();
            Console.WriteLine();

            switch (opcao)
            {
                case "a": ExercicioA(); break;
                case "b": ExercicioB(); break;
                case "c": ExercicioC(); break;
                case "d": ExercicioD(); break;
                case "e": ExercicioE(); break;
                case "f": ExercicioF(); break;
                case "g": ExercicioG(); break;
                case "h": ExercicioH(); break;
                case "i": ExercicioI(); break;
                case "j": ExercicioJ(); break;
                case "s": return;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }
    }
}
