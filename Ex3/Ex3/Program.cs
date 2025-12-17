using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        //string frase = Console.ReadLine();
        //string x = Console.ReadLine();
        //string y = Console.ReadLine();
        //string z = Console.ReadLine();
        //string[] v = Console.ReadLine().Split(' ');
        //string a = v[0];
        //string b = v[1];
        //string c = v[2];
        //Console.WriteLine("Você escreveu: ");
        //Console.WriteLine(frase);
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        //Console.WriteLine(z);
        //Console.WriteLine(a);
        //Console.WriteLine(b);
        //Console.WriteLine(c);

        //int n1 = int.Parse(Console.ReadLine()); //obriga leitura de um número inteiro
        //char ch = char.Parse(Console.ReadLine()); //obriga leitura de um caractere
        //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //obriga leitura de um número com ponto
        //string[] vet = Console.ReadLine().Split(' '); //obriga leitura de vários dados em uma única linha
        //string nome = vet[0]; //primeiro dado lido
        //char sexo = char.Parse(vet[1]); //segundo dado lido
        //int idade = int.Parse(vet[2]); //terceiro dado lido
        //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture); //quarto dado lido
        //Console.WriteLine("Você escreveu:"); //exibe os dados lidos
        //Console.WriteLine(n1); //exibe o número inteiro
        //Console.WriteLine(ch); //exibe o caractere
        //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture)); //exibe o número com ponto
        //Console.WriteLine(nome); //exibe o primeiro dado lido
        //Console.WriteLine(sexo); //exibe o segundo dado lido
        //Console.WriteLine(idade); //exibe o terceiro dado lido
        //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture)); //exibe o quarto dado lido
        
        Console.Write("Digite seu nome completo: ");
        string[] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        string sobrenome = vet[vet.Length - 1];
        Console.Write("Indique o número de quartos tem a sua casa: ");
        int quartos = int.Parse(Console.ReadLine());
        Console.Write("Indique o preço de um produto: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Indique a sua altura: ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Seu primeiro nome é: " + nome);
        Console.WriteLine("Seu último nome é: " + sobrenome);
        Console.WriteLine($"Sua casa tem {quartos} quartos.");
        Console.WriteLine("O preço do produto é: " + preco.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Sua altura é: " + altura.ToString("F2", CultureInfo.InvariantCulture));
        Console.ReadLine();


    }

}