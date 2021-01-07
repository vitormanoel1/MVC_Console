using System;
using MVC_Console.Controller;
using MVC_Console.Models;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.Cadastrar();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("lista atualizada de produtos cadastrados");
            Console.ResetColor();
            
            prod.ListarProdutos();
        }
    }
}
