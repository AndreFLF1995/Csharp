using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        class Livro
        {
            private string titulo;
            private string autor;
            private int ano;

            public void setTitulo(string titulo)
            {
                this.titulo = titulo;
            }

            public string getTitulo()
            {
                return titulo;
            }

            public void setAutor(string autor)
            {
                this.autor = autor;
            }

            public string getAutor()
            {
                return autor;
            }

            public void setAno(int ano)
            {
                this.ano = ano;
            }

            public int getAno()
            {
                return ano;
            }

            public Livro()
            {
                titulo = "";
                autor = "";
                ano = 0;
            }

            public void exibirInformacao()
            {
                Console.WriteLine("Titulo: " + getTitulo());
                Console.WriteLine("Autor : " + getAutor());
                Console.WriteLine("Ano   : " + getAno());
            }
        }

        static void Main(string[] args)
        {
            ArrayList biblioteca = new ArrayList();

            bool sair = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Bem vindo à sua biblioteca: ");
                Livro livro = new Livro();

                Console.Write("Insira o titulo do livro: ");
                livro.setTitulo(Console.ReadLine());

                Console.Write("Insira o nome do autor: ");
                livro.setAutor(Console.ReadLine());

                Console.Write("Insira o ano de lançamento: ");
                livro.setAno(int.Parse(Console.ReadLine()));

                biblioteca.Add(livro);

                for (int i = 0; i < biblioteca.Count; i++)
                {
                    Console.WriteLine("\nLivro " + (i+1));
                    ((Livro)biblioteca[i]).exibirInformacao();
                }

                Console.WriteLine("Quer inserir mais livros? s = continuar; n = sair;");
                char escolha = char.Parse(Console.ReadLine());

                if (escolha == 'n' || escolha == 'N')
                {
                    sair = true;
                }
            } while (!sair);
        }
    }
}
