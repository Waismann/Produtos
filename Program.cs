using System;
using System.Globalization;
using System.Collections.Generic;
using EtiquetaProdutos.Entities;

namespace EtiquetaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Produto> produtos = new List<Produto>();

            Console.WriteLine("Quantos produtos irá cadastrar ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Para o #{i} Produto digite: ");
                Console.WriteLine("c para cadastrar um produto Comum.");
                Console.WriteLine("i para cadastrar um produto Importado.");
                Console.WriteLine("u para cadastrar um produto Usado");
                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine("Nome do produto: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (ch == 'c')
                {
                    produtos.Add(new Produto(nome, preco));
                }

                else if (ch == 'i')
                {
                    Console.WriteLine("Taxa da importação: ");
                    double taxaImportacao = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
                    produtos.Add(new ProdutoImportado (nome, preco, taxaImportacao));   
                }

                else // U para produto Usado
                {
                    Console.WriteLine("Data de fabricação do produto: DD/MM/AAAA");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(nome, preco, dataFabricacao));    
                }

            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Preço dos produtos: ");
            foreach (Produto p in produtos)
            {
                Console.WriteLine(p.PrecoEtiqueta());
            }
        }
    }
}