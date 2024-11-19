using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        class Empresa
        {
            private string nome;
            private string local;
            private int numFuncionarios;
            private List<Funcionario> funcionarios;

            public void setNome(string nome)
            {
                this.nome = nome;
            }

            public string getNome()
            {
                return nome;
            }

            public void setNumFuncionarios(int numFuncionarios)
            {
                this.numFuncionarios = numFuncionarios;
            }

            public int getNumFuncionarios()
            {
                return numFuncionarios;
            }

            public void setLocal(string local)
            {
                this.local = local;
            }

            public string getLocal()
            {
                return local;
            }

            public void setFuncionarios(List<Funcionario> funcionarios)
            {
                this.funcionarios = funcionarios;
            }

            public List<Funcionario> getFuncionarios()
            {
                return funcionarios;
            }

            public Empresa()
            {
                nome = "";
                local = "";
                numFuncionarios = 0;
                funcionarios = new List<Funcionario>();
            }
        }

        class Funcionario
        {
            private string nome;
            private string departamento;
            private double salario;

            public void setNome(string nome)
            {
                this.nome = nome;
            }

            public string getNome()
            {
                return nome;
            }

            public void setSalario(double salario)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return salario;
            }

            public void setDepartamento(string departamento)
            {
                this.departamento = departamento;
            }

            public string getDepartamento()
            {
                return departamento;
            }

            public Funcionario()
            {
                nome = "";
                departamento = "";
                salario = 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vamos criar uma empresa e inserir funcionarios!\n");

            ArrayList listaEmpresa = new ArrayList();
            bool sair = false;
            int contador = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Empresas: " + contador++);

                Empresa empresa = new Empresa();

                Console.Write("Insira o nome da Empresa: ");
                empresa.setNome(Console.ReadLine());

                Console.Write("Insira o numero de funcionários: ");
                empresa.setNumFuncionarios(int.Parse(Console.ReadLine()));

                Console.Write("Insira o local da Empresa: ");
                empresa.setLocal(Console.ReadLine());

                List<Funcionario> listaFuncionarios = new List<Funcionario>();

                Console.WriteLine("\n\nVamos inserir os funcionarios!\n");

                for(int i = 0; i < empresa.getNumFuncionarios(); i++)
                {
                    Funcionario funcionario = new Funcionario();
                    Console.Write("Insira o nome do funcionário " + (i+1) + " de " + empresa.getNumFuncionarios() + ": ");
                    funcionario.setNome(Console.ReadLine());

                    Console.Write("Insira o salario do funcionário " + (i+1) + " de " + empresa.getNumFuncionarios() + ": ");
                    funcionario.setSalario(double.Parse(Console.ReadLine()));

                    Console.Write("Insira o departamento do funcinário " +(i + 1) + " de " + empresa.getNumFuncionarios() + ": ");
                    funcionario.setDepartamento(Console.ReadLine());

                    listaFuncionarios.Add(funcionario);
                }

                empresa.setFuncionarios(listaFuncionarios);

                listaEmpresa.Add(empresa);

                Console.WriteLine("Quer inserir outra empresa? s/n");
                char escolha = char.Parse(Console.ReadLine());

                if (escolha == 'n' || escolha == 'N')
                {
                    sair = true;
                }

                for (int i = 0; i < listaEmpresa.Count; i++)
                {
                    Empresa empresa2 = (Empresa)listaEmpresa[i]; // Cast to Empresa
                    Console.WriteLine("Empresa: " + empresa2.getNome());
                    Console.WriteLine("Local: " + empresa2.getLocal());
                    Console.WriteLine("Número de Funcionários: " + empresa2.getNumFuncionarios());
                    List<Funcionario> listaFuncionarios2 = empresa2.getFuncionarios();  // Get the employee list from the company

                    for (int j = 0; j < listaFuncionarios2.Count; j++)
                    {
                        Funcionario funcionario = listaFuncionarios2[j];  // Access each employee
                        Console.WriteLine("Funcionário " + (j + 1) + ": " + funcionario.getNome());
                        Console.WriteLine("Salário: " + funcionario.getSalario());
                        Console.WriteLine("Departamento: " + funcionario.getDepartamento());
                    }

                    Console.WriteLine("-----------------------------------\n");
                }

            } while (!sair);
            Console.WriteLine("Obrigado por usar o programa, pressione em algo para sair!");
            Console.ReadLine();
        }
    }
}
