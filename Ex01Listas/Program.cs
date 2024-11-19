using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
/*
 * Classe Pessso com as propriedades Nome, genero, salario
 * Classe ListaPessoas
 * Menu 1 Inserir
 * 2 Listar
 * 3 Editar
 * 4 Apagar
 * 0 Sair
  */
namespace Classses_Listas
{
    public class pessoa
    {
        public string nome { set; get; }
        public char genero { set; get; }
        public double salario { set; get; }

    }
    public class lista_pessoas
    {

        private static List<pessoa> lpessoas = new List<pessoa>();
        public void insere_pessoa()
        {
            pessoa novaPessoa = new pessoa();

            Console.WriteLine("Insira o nome da pessoa: ");
            novaPessoa.nome = Console.ReadLine();

            Console.WriteLine("Insira o género da pessoa (M/F/O): ");
            novaPessoa.genero = char.Parse(Console.ReadLine());

            Console.WriteLine("Insira o salário: ");
            novaPessoa.salario = double.Parse(Console.ReadLine());

            lpessoas.Add(novaPessoa);
        }
        public void lista_de_pessoas()
        {
            for (int i = 0; i < lpessoas.Count; i++)
            {
                Console.WriteLine("Nome    : " + lpessoas[i].nome);
                Console.WriteLine("Género  : " + lpessoas[i].genero);
                Console.WriteLine("Salário : " + lpessoas[i].salario);
                Console.WriteLine("----------------------------------");
                
            }
            Console.Write("Prima para continuar...");
            Console.ReadKey();
        }

        public void editar_pessoas()
        {
            Console.Write("Insira o nome da pessoa que deseja editar: ");
            string nomeEditar = Console.ReadLine();

            pessoa pessoaEdit = lpessoas.Find(p => p.nome == nomeEditar);

            Console.Write("Novo nome: ");
            string novoNome = Console.ReadLine();
            pessoaEdit.nome = novoNome;

            Console.Write("Novo gênero (M/F/O): ");
            string novoGenero = Console.ReadLine();
            pessoaEdit.genero = char.Parse(novoGenero);

            Console.Write("Novo salário: ");
            string novoSalario = Console.ReadLine();
            pessoaEdit.salario = double.Parse(novoSalario);

            Console.WriteLine("Pessoa editada com sucesso!");
        }

        public void apagar_pessoa()
        {
            Console.Write("Insira o nome da pessoa que deseja apagar: ");
            string nomeApagar = Console.ReadLine();

            pessoa pessoaApagar = lpessoas.Find(p => p.nome == nomeApagar);
            lpessoas.Remove(pessoaApagar);
            Console.WriteLine("Pessoa não encontrada.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            do
            {
                Console.Clear();
                Console.WriteLine("\n Menu de Gestão de Pessoas");
                Console.WriteLine("\n 1 - Inserir Pessoas");
                Console.WriteLine("\n 2 - Listar Pessoas");
                Console.WriteLine("\n 3 - Editar Pessoas");
                Console.WriteLine("\n 4 - Apagar Pessoas");
                Console.WriteLine("\n 0 - Sair\n");
                int opcao = int.Parse(Console.ReadLine());
                lista_pessoas lp = new lista_pessoas();

                switch (opcao)
                {
                    case 0: 
                        { 
                            Console.WriteLine("Adeus"); sair = true; break;
                        }

                    case 1: 
                        { 
                            Console.WriteLine("Inserir Pessoas");
                            lp.insere_pessoa();
                            break; 
                        };
                    case 2: 
                        { 
                            Console.WriteLine("Listar Pessoas");
                            lp.lista_de_pessoas();
                            break; 
                        };
                    case 3: 
                        { 
                            Console.WriteLine("Editar Pessoas");
                            lp.editar_pessoas();
                            break; 
                        };
                    case 4: 
                        { 
                            Console.WriteLine("Apagar Pessoas");
                            lp.apagar_pessoa();
                            break; 
                        };
                    default: 
                        { 
                            Console.WriteLine("Insira um numero correto");
                            break; 
                        };
                }
            } while (!sair);
        }
    }
}