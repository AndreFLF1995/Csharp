using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        public class ContaBancaria
        {
            private string titular;
            private int numConta;
            private double saldo;

            public void setTitular(string titular)
            {
                this.titular = titular;
            }

            public string getTitular()
            {
                return titular;
            }

            public void setNumConta(int numConta)
            {
                this.numConta = numConta;
            }

            public int getNumConta()
            {
                return numConta;
            }

            public void setSaldo(double saldo)
            {
                this.saldo = saldo;
            }

            public double getSaldo()
            {
                return saldo;
            }

            public ContaBancaria()
            {
                this.numConta = 0;
                this.saldo = 0;
                this.titular = "";
            }

            public void Depositar(double valor)
            {
                double saldo = getSaldo();
                saldo += valor;
                setSaldo(saldo);
            }

            public void Levantar(double valor)
            {
                double saldo = getSaldo();
                if (saldo >= valor)
                {
                    saldo -= valor;
                    setSaldo(saldo);
                }
                else
                {
                    Console.WriteLine("Não tem saldo suficiente para levantar esse montante.");
                }
            }
        }

        static void Main(string[] args)
        {
            ContaBancaria contaBancaria = new ContaBancaria();

            Console.WriteLine("Bem-Vindo ao seu sistema bancário. Patrocinado pela SIBS.");

            Console.WriteLine("\nVamos criar a sua conta bancária:\n");

            Console.Write("Insira o seu nome: ");
            contaBancaria.setTitular(Console.ReadLine());

            Console.Write("Insira o seu numero de conta: ");
            contaBancaria.setNumConta(int.Parse(Console.ReadLine()));

            Console.Write("Insira o seu saldo: ");
            contaBancaria.setSaldo(double.Parse(Console.ReadLine()));

            char escolha = '\0';
            bool sair = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Titular: " + contaBancaria.getTitular());
                Console.WriteLine("Nº     : " + contaBancaria.getNumConta());
                Console.WriteLine("Saldo  : " + contaBancaria.getSaldo());
                Console.WriteLine("\n\nInsira o movimento que quer fazer (L = Levantamento; D = Depósito; S = Saír):");
                escolha = char.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 'l': case 'L':
                    {
                        Console.Write("\nInsira o montante a levantar:");
                        double valor = double.Parse(Console.ReadLine());
                        contaBancaria.Levantar(valor);
                        Console.WriteLine("\nPressione uma tecla para continuar...");
                        Console.ReadKey();
                        break;
                    }
                    case 'd': case 'D':
                    {
                        Console.Write("\nInsira o montante a depositar:");
                        double valor = double.Parse(Console.ReadLine());
                        contaBancaria.Depositar(valor);
                        Console.WriteLine("\nPressione uma tecla para continuar...");
                        Console.ReadKey();
                        break;
                    }
                    case 's': case 'S':
                    {
                        Console.Write("\nObrigado por usar o programa!\n");
                        sair = true;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("\nInsira uma escolha válida!");
                        Console.WriteLine("\nPressione uma tecla para continuar...");
                        Console.ReadKey();
                        break;
                    }
                }
            }while(!sair);
        }
    }
}
