using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        private const string PATH = "Database/Produto.csv"; 
        
        public Produto() 
        {
            // verificar se a pasta exixte
            string pasta = PATH.Split("/")[0];
            //[0] dataBase
            //[1] produto.csv

            if(!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }
            //verificar se o arquivo existe
            if(!File.Exists(PATH)) {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler() 
        {
            //crio uma lista para armazenar os produtos
            List<Produto> produtos = new List<Produto>();

            // lemos as linhas do csv
            string[] linhas = File.ReadAllLines(PATH);

            // percoremos as linhas do csv
            foreach (string item in linhas)
            {
                //separamos os elementos para cada linha
                string[] atributos = item.Split(";");
                // 1;JBL;5000,00
                //[0] 1
                //[1] JBL
                //[2] 5000,00

                //passamos para um objeto do tipo rpoduto
                Produto prod = new Produto();
                prod.Codigo = int.Parse(atributos[0]);
                prod.Nome = atributos[1];
                prod.Preco = float.Parse(atributos[2]);

                produtos.Add(prod);
            }
                return produtos;
        }

        // criamos um metodo para inserir produtos
        public void Inserir(Produto produto)
        {
        // criamos um array de linhas para inserir no csv 
        string[] linhas = {PrepararLinhasCSV(produto)};
        // metodo responsavel por inserir linha em um aqrquivo
        File.AppendAllLines(PATH,linhas);
        }

        public string PrepararLinhasCSV(Produto prod)
        {
            return $"{prod.Codigo};{prod.Nome};{prod.Preco}";
        }
    }
}