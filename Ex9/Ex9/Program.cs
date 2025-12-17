using System;
using System.Collections.Generic; // Necessário para usar List<>
using System.Diagnostics.CodeAnalysis; // Necessário para atributos de supressão de avisos
using System.Runtime.CompilerServices;// Necessário para atributos de compilação
using System.Runtime.Serialization;// Necessário para serialização
using Ex9; // Importa o namespace Ex9 para usar a classe Produto

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("          === Cadastro de Produto ===");
        Console.WriteLine(" ");
        List<Produto> lista = new List<Produto>(); // Mover para fora do loop
        double sumPrice = 0; // Variável para somar os preços
        int sum = 0;

        while (true)
        {
            Console.Write("Deseja introduzir um novo produto? [S] ou [N]: ");
            string resposta = Console.ReadLine().ToUpper();
            
            if (resposta == "N")
            {
                break;
            }
            else if (resposta != "S")
            {
                Console.WriteLine("Valor Introduzido errado.");
                continue;
            }

            Console.Write("Introduza um produto: ");
            string nome = Console.ReadLine();

            Console.Write("Introduza o preço: ");
            double preco = double.Parse(Console.ReadLine());
            sumPrice += preco;// Adiciona o preço à soma total

            Console.Write("Introduza a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            sum += quantidade;

            Produto novoProduto = new Produto(nome, preco, quantidade);
            lista.Add(novoProduto);
        
            Console.WriteLine("Produto adicionado com sucesso!\n");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
        Console.WriteLine("\nProdutos cadastrados:");
        Console.WriteLine("------------------------------------------------------------");
        foreach (var produto in lista) //Vai mostrar todos os produtos cadastrados
        {
            Console.WriteLine("Nome: {0,-15} | Preço: {1,7:F2}E | Quantidade: {2,5}", produto.nome, produto.preco, produto.quantidade);            
        }
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine($"Total de qauntidades em stock: {sum}");
        Console.WriteLine($"Preço total dos produtos: {sumPrice:F2}E");
        Console.WriteLine("Total valor em stock: {0:F2}E", sumPrice * sum); // Valor total em stock
    }
}