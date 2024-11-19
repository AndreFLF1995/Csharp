using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        public class Pessoa
        {
            private string nome;
            private int idade;
            private double altura;

            void setNome (string nome)
            {
                this.nome = nome;
            }

            string getNome()
            {
                return nome;
            }

            void setIdade(int idade)
            {
                this.idade = idade;
            }

            int getIdade()
            {
                return idade;
            }

            void setAltura(double altura)
            {
                this.altura = altura;
            }

            double getAltura()
            {
                return altura;
            }

            public Pessoa(string nome, int idade, double altura)
            {
                this.nome=nome;
                this.idade=idade;
                this.altura=altura;
            }

            public void Cumprimento()
            {
                Console.WriteLine("Olá! O meu nome é " + getNome() + ", tenho " + getIdade() + " anos e meço " + getAltura() +  " metros!");
            }
        }

        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;
            double altura = 0;

            Console.WriteLine("Vamos criar uma pessoa!");

            Console.WriteLine("\nInsira o nome dessa pessoa: ");
            nome = Console.ReadLine();

            Console.WriteLine("\nInsira a idade dessa pessoa: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInsira a altura dessa pessoa em metros: ");
            altura = double.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, idade, altura);

            pessoa.Cumprimento();
        }
    }
}
