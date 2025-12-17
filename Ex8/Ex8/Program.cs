//using System; // Added to suppress CS8019 warning

//class Program
//{
//    static void Main()
//    {
//        int numero = 42;
//        double valor = 123.456;

//        //Usando Tostring com tipos básicos
//        Console.WriteLine("Número inteiro como string: " + numero.ToString());
//        Console.WriteLine("Número decimal como string: " + valor.ToString());

//        //Sem ToString C# infere automaticamente a conversão para string
//        Console.WriteLine("Número inteiro como string (sem ToString): " + numero);
//    }
//}

//Sem o ToString
//using System;   

//class Pessoa
//{
//    public string Nome { get; set; }
//    public int Idade { get; set; }
//    // Sobrescrevendo o método ToString para fornecer uma representação personalizada
//    public override string ToString()
//    {
//        return $"Nome: {Nome}, Idade: {Idade}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Pessoa pessoa = new Pessoa { Nome = "João", Idade = 30 };

//        //Usando ToString sobrescrito
//        Console.WriteLine("Pessoa como string: " + pessoa.ToString());

//        //Sem ToString C# infere automaticamente a conversão para string
//        Console.WriteLine("Pessoa como string (sem ToString): " + pessoa);
//    }

//}

//Personalizar ToString em uma classe complexa

using System;
class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }
    // Sobrescrevendo o método ToString para fornecer uma representação personalizada
    public override string ToString()
    {
        return $"Produto: {Nome}, Preço: {Preco:C2}, Quantidade: {Quantidade}";
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto { Nome = "Notebook", Preco = 2500.75, Quantidade = 5 };
        //Usando ToString sobrescrito
        Console.WriteLine("Produto como string: " + produto.ToString());
        //Sem ToString C# infere automaticamente a conversão para string
        Console.WriteLine("Produto como string (sem ToString): " + produto);
    }
}