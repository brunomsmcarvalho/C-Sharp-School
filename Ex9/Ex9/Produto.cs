using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9 // Definição do namespace Ex9
{
    public class Produto // Definição da classe Produto
    {
        public string nome; // Parametro da classe com a sua definição
        public double preco;
        public int quantidade; 

        public Produto(string nome, double preco, int quantidade) // Construtor da classe
        {
            this.nome = nome; // Uso do this para referenciar os parametros da classe
            this.preco = preco; // em vez de usar nomes diferentes
            this.quantidade = quantidade; // para os parametros do construtor
        }
    }
}
