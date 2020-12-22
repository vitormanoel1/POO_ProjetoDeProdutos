using System;
using System.Collections.Generic;

namespace POO_ProjetoDeProdutos.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public Usuario Usuario = new Usuario();
        
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"digite o nome do produto ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"digite o codigo do produto ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"digite o Preço do produto ");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            
            // chamamos um metodo do objeto/propriedade "Marca"
            novoProduto.Marca = Marca.Cadastrar();

            // utilizamos o propio metedo construtor  para atribuir um objeto completo de "usuario"
            novoProduto.Usuario = new Usuario();

            ListaDeProdutos.Add(novoProduto);
        } 
        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Produto item in ListaDeProdutos)
            {
                Console.WriteLine($"codigo do produto: {item.Codigo}");
                Console.WriteLine($"nome do produto: {item.NomeProduto}");
                Console.WriteLine($"preço do produto: {item.Preco}");
                Console.WriteLine($"data de cadastro do produto: {item.DataCadastro}");
                Console.WriteLine($"marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"marca: {item.Usuario.Nome}");
            }
            Console.ResetColor();
        }
        public void Deletar(int cod)
        {
            Produto produtoDeletar = ListaDeProdutos.Find(x => x.Codigo == cod);
            ListaDeProdutos.Remove(produtoDeletar);
        }
    }
}