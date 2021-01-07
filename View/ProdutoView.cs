using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos) 
        {
            foreach (var item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Produto: {item.Nome}");
                Console.WriteLine($"Preço: R${item.Preco}");
                Console.WriteLine();
                
                Console.ResetColor();
            }
        }

        //
        public Produto CadastrarProduto()
        {
            Produto produto = new Produto();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"digite o còdigo do produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"digite o nome do produto: ");
            produto.Nome = Console.ReadLine();
            
            Console.WriteLine($"digite o preço do produto: ");
            produto.Preco = float.Parse(Console.ReadLine());

            Console.ResetColor();
            return produto;
        }
    }
}