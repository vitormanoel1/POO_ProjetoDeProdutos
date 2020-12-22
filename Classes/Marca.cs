using System;
using System.Collections.Generic;

namespace POO_ProjetoDeProdutos.Classes
{
    public class Marca
    {
        public string NomeMarca { get; set; }
        public int Codigo { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Marca> ListaDeMarcas = new List<Marca>();
        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();
            Console.WriteLine("digite o nome da marca");
            novaMarca.NomeMarca = Console.ReadLine();

            Console.WriteLine("digite o codigo do produto");
            novaMarca.Codigo = int.Parse(Console.ReadLine());

            DataCadastro = DateTime.Today;

            ListaDeMarcas.Add(novaMarca);

            return novaMarca;
        }
        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (Marca item in ListaDeMarcas)
            {
                Console.WriteLine($"codigo do produto {item.Codigo}");
                Console.WriteLine($"nome do produto {item.NomeMarca}");
                Console.WriteLine($"data de cadastro do produto {item.DataCadastro}");
            }
            Console.ResetColor();
        }
        public void Deletar(int cod)
        {
            Marca marcaDeletar = ListaDeMarcas.Find(x => x.Codigo == cod);
            ListaDeMarcas.Remove(marcaDeletar);
        }
    }
}