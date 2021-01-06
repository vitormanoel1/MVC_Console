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
    }
}