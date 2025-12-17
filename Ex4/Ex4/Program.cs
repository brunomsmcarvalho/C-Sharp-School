using System.Drawing;
using System.Globalization;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Quantos números inteiros vai inserir? ");
        int N = int.Parse(Console.ReadLine()); // Lê a quantidade de números a serem inseridos
        int soma = 0; // Variável para armazenar a soma dos valores
        for (int i = 1; i <= N; i++) // i começa em 1 para exibir "Valor #1", "Valor #2", etc.
        {
            Console.Write("Valor #{0}: ", i); // Solicita o valor ao usuário
            int valor = int.Parse(Console.ReadLine()); // Lê o valor inserido
            soma += valor; // Adiciona o valor à soma
        }
        Console.WriteLine("Soma = " + soma);// Exibe a soma dos valores inseridos

        //-----------// Exemplo de uso da struct Point do namespace System.Drawing

        Console.Write("Digite um número: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê o número inserido pelo usuário
        while (x >= 0.0)// enquanto o número for não negativo
        {
            double raiz = Math.Sqrt(x);// calcula a raiz quadrada
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture)); // exibe a raiz quadrada formatada com 3 casas decimais
            Console.Write("Digite outro número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Lê o próximo número inserido pelo usuário
        }
        Console.WriteLine("Número negativo!");



    }
}