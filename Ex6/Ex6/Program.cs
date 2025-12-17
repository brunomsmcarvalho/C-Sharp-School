using Ex6;

internal class Program //classe principal
{
    public static void fpessoa(string nome, int idade) //função que cria duas pessoas e compara suas idades
    {

        Pessoa pessoa1 = new Pessoa(); //cria a primeira pessoa
        Pessoa pessoa2 = new Pessoa(); //cria a segunda pessoa

        pessoa1.nome = nome; //atribui o nome e idade passados como parâmetros à primeira pessoa
        pessoa1.idade = idade;
        pessoa2.nome = "Maria"; //atribui um nome e idade fixos à segunda pessoa
        pessoa2.idade = 30;

        if (pessoa1.idade > pessoa2.idade)//compara as idades
        {
            Console.WriteLine($"{pessoa1.nome} é mais velho(a) que {pessoa2.nome}");
        }
        else if (pessoa1.idade < pessoa2.idade)
        {
            Console.WriteLine($"{pessoa2.nome} é mais velho(a) que {pessoa1.nome}"); //compara as idades e imprime quem é mais velho
        }
        else
        {
            Console.WriteLine($"{pessoa1.nome} e {pessoa2.nome} têm a mesma idade");
        }
    }
    private static void Main(string[] args) //função principal que lê o nome e idade da pessoa
    {
    Console.WriteLine("Digite o nome da pessoa:");
        string nome = Console.ReadLine(); //lê o nome da pessoa
        Console.WriteLine("Digite a idade da pessoa:");
        int idade = int.Parse(Console.ReadLine()); //lê a idade da pessoa
        fpessoa(nome, idade); //chama a função que compara as idades
    }
       
}

