using System;

namespace POO_ProjetoDeProdutos.Classes
{
    public class Login
    {
        public Login(bool logado) 
        {
            this.Logado = logado;
               
        }
                public bool Logado { get; set; }
        public Login()
        {
            Logar();
            if(Logado == true)
            {
                GerarMenu();
            }
        }
        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao = "o";
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Escolha a opção desejada: ");
                Console.WriteLine("1 - Cadastrar Marca");
                Console.WriteLine("2 - Listar Marcas");
                Console.WriteLine("3 - Excluir Marca");
                Console.WriteLine("4 - Cadastrar Produto");
                Console.WriteLine("5 - Listar Produtos");
                Console.WriteLine("6 - Excluir Produtos");
                Console.WriteLine("0 - Sair");

                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                opcao = Console.ReadLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;

                switch (opcao)
                {
                    case "1":
                        marca.Cadastrar();
                    break;
                    case "2":
                        marca.Listar();
                    break;
                    case "3":
                        Console.WriteLine("digite o codigo da marca para excluir");
                        int codigo = int.Parse(Console.ReadLine());
                        marca.Deletar(codigo);
                    break;
                            
                    case "4":
                        produto.Cadastrar();
                    break;

                    case "5":
                        produto.Listar();
                    break;

                    case "6":
                        Console.WriteLine("digite o codigo do produto para excluir");
                        int codigoProduto = int.Parse(Console.ReadLine());
                        produto.Deletar(codigoProduto);
                    break;

                    default:
                        break;
                }
                Console.ResetColor();
                

            } while (opcao != "0");
        }
        public void Logar()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Usuario user = new Usuario();

            Console.WriteLine("digite seu email: ");
            string emailLogin = Console.ReadLine();
            
            Console.WriteLine("digite sua senha: ");
            string senhaLogin = Console.ReadLine();
            
            if (emailLogin == user.Email && senhaLogin == user.Senha)
            {
                Logado = true;
                Console.WriteLine("login efetuado com sucesso!");
            }
            else
            {
                Console.WriteLine("falha ao efetuar login, tente novamente!");
            }
            Console.ResetColor();
        }  
        public void Deslogar()
        {
            Logado = false;
        }  
    }
}