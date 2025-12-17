using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //    char genero = 'F';
        //    int idade = 32;
        //    double saldo = 10.35784;
        //    String nome = "Maria";

        //    Console.Write("Bom dia!"); // Print without newline
        //    Console.WriteLine("Boa tarde!"); // Print with newline
        //    Console.WriteLine("Boa noite!");
        //    Console.WriteLine("------------------------");
        //    Console.WriteLine(genero); // Print char variable 
        //    Console.WriteLine(idade);
        //    Console.WriteLine(saldo);
        //    Console.WriteLine(nome);
        //    Console.WriteLine(saldo.ToString("F2")); // Print with 2 decimal places
        //    Console.WriteLine(saldo.ToString("F4"));
        //    Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); // Print with dot as decimal separator porque mantem o padrão internacional, em vez de usar o padrao da maquina

        //int idade = 32;
        //double saldo = 10.35784;
        //String nome = "Maria";

        //Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} euros", nome, idade, saldo);
        //// Usando formatação composta
        //Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} euros");
        //// Usando interpolação
        //Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a "
        //+ saldo.ToString("F2", CultureInfo.InvariantCulture) + "euros");
        //// Usando concatenação
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";
        byte idade = 30;
        int cc = 529066789;
        char genero = 'M';
        double preco1 = 2100.52;
        double preco2 = 650.54;
        double medida = 53.234567;

        Console.WriteLine("Produtos:");
        Console.WriteLine($"{produto1}, cujo preço é € {preco1:F0}.00");
        Console.WriteLine($"{produto2}, cujo preço é € {preco2:F0}.50");
        Console.WriteLine();
        Console.WriteLine($"Registro: {idade} anos de idade, o cc é {cc} e gênero: {genero}");
        Console.WriteLine();
        Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
        Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
        Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));


    }

}

