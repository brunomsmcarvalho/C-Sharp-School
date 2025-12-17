using System.Globalization; //importando o namespace System.Globalization para usar CultureInfo
using Ex7; //importando o namespace Ex7 para usar a classe Colaborador
internal class Program //definindo a classe principal
{
    private static void Main(string[] args) //ponto de entrada do programa
    {
        Colaborador c1, c2;//instanciando as classes

        c1 = new Colaborador(); //criando o objeto c1
        c2 = new Colaborador();

        Console.WriteLine("Digite os dados do primeiro colaborador:");
        c1.nome = Console.ReadLine();//lendo o nome do colaborador
        Console.WriteLine("Digite o salário do primeiro colaborador:");
        c1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite os dados do segundo colaborador:");
        c2.nome = Console.ReadLine();
        Console.WriteLine("Digite o salário do segundo colaborador:");
        c2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = (c1.salario + c2.salario) / 2.0;//calculando a média salarial

        Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
    }
}