using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        struct Infocars
        {
            public string modelo;
            public string placa;
            public string cor;
            public string ano;
        }

        static void Cadastro(Infocars[] estac, int total)
        {

            string cor, modelo, placa, ano;
            Console.WriteLine("Olá! - Cadastre seu Carro Abaixo: ");

            Console.WriteLine("");

            Console.WriteLine("Qual o Modelo de seu Carro?: ");
            estac[total].modelo = Console.ReadLine();
            modelo = estac[total].modelo;

            Console.WriteLine("Qual a Placa de seu Carro?: ");
            estac[total].placa = Console.ReadLine();
            placa = estac[total].placa;

            Console.WriteLine("Qual a Cor de seu Carro?: ");
            estac[total].cor = Console.ReadLine();
            cor = estac[total].cor;

            Console.WriteLine("Qual o Ano de seu Carro?: ");
            estac[total].ano = Console.ReadLine();
            ano = estac[total].ano;

            Console.WriteLine("Cadastrado.");
            Console.WriteLine("");
            total++;
        }

        static void ConsultarPorAno(Infocars[] estac, string ano, int total)
        {
            string anocarro;
            Console.WriteLine("Digite um ano:");
            anocarro = Console.ReadLine();


                for (int i = 0; i<total; i++)
                {
                    if (anocarro == estac[i].ano)
                    {
                        Console.WriteLine("{0}   {1}   {2}   {3}   {4}",i+1, estac[i].modelo, estac[i].placa, estac[i].cor, anocarro);
                    }
                }
            
        }

        static void ConsultarPorModelo(Infocars[] estac, string modelo, int total)
        {
            string modelocarro;
            Console.WriteLine("Digite um modelo de carro: ");
            modelocarro = Console.ReadLine();


            for (int i = 0; i < total; i++)
            {
                if (modelocarro == estac[i].modelo)
                {
                    Console.WriteLine("{0}   {1}   {2}   {3}   {4}", i + 1, modelocarro, estac[i].placa, estac[i].cor, estac[i].ano);
                }
            }

        }

        static void ConsultarPorCor(Infocars[] estac, string cor, int total)
        {
            string corcarro;
            Console.WriteLine("Digite uma cor:");
            corcarro = Console.ReadLine();


            for (int i = 0; i < total; i++)
            {
                if (corcarro == estac[i].cor)
                {
                    Console.WriteLine("{0}   {1}   {2}   {3}   {4}",i+1, estac[i].modelo, estac[i].placa, corcarro, estac[i].ano);
                }
            }

        }

        static void Consultar(Infocars[] estac, int total)

        {

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("{0}   {1}   {2}   {3}   {4}", i + 1, estac[i].modelo, estac[i].placa, estac[i].cor, estac[i].ano);
            }
        }

        static void AlterarCarro(Infocars[] estac, int total)
        {
            int faketotal;
            string alterar = "";
            string a = "";

            Console.WriteLine("Qual vaga seu carro está? (até 500)");
            faketotal = int.Parse(Console.ReadLine());

            for (int i = faketotal; i == faketotal; i++)
            {
                if (faketotal <= total)
                {
                    Console.WriteLine("O que você deseja alterar? (Entre Modelo, Placa, Cor e Ano)");
                    alterar = Console.ReadLine();

                    if (alterar == "Ano" || alterar == "ano" )
                    {
                            
                            estac[i-1].ano = a;
                            Console.WriteLine("Digite o novo Ano: ");
                            estac[i-1].ano = Console.ReadLine();

                        Console.WriteLine("Dado Alterado.");
                        Console.WriteLine("");
                    }

                    if (alterar == "Placa" || alterar == "placa")
                    {

                            
                            estac[i-1].placa = a;
                            Console.WriteLine("Digite a nova Placa: ");
                            estac[i-1].placa = Console.ReadLine();


                        Console.WriteLine("Dado Alterado.");
                        Console.WriteLine("");
                    }

                    if (alterar == "Cor" || alterar == "cor")
                    {

                            
                            estac[i - 1].cor = a;
                            Console.WriteLine("Digite a nova cor: ");
                            estac[i-1].cor = Console.ReadLine();

                        Console.WriteLine("Dado Alterado.");
                        Console.WriteLine("");
                    }
                    if (alterar == "Modelo" || alterar == "modelo")
                    {

                            
                            estac[i - 1].modelo = a;
                            Console.WriteLine("Digite o novo Modelo: ");
                            estac[i - 1].modelo = Console.ReadLine();

                        Console.WriteLine("Dado Alterado.");
                        Console.WriteLine("");
                    }
                }
            }
        }

        static void Excluir(Infocars[] estac, int total)
        {
            var a = "";
            int i;
            Console.WriteLine("Qual vaga seu carro está? (até 20)");
            total = int.Parse(Console.ReadLine());

            for (i = total - 1; i < total; i++)
            {
                estac[i].ano = a;
                estac[i].cor = a;
                estac[i].modelo = a;
                estac[i].placa = a;

            }
            Console.WriteLine("Carro Saiu!");
        }


        static string menu()
        {
            string opcao;
            Console.WriteLine("");
            Console.WriteLine("Menu do Sistema:\n1 - Cadastrar Carro\n2 - Consultar Carros por Ano\n3 - Consultar Carros por Modelo\n4 - Consultar Carros por Cor\n5 - Consultar Carros \n6 - Alterar dados de um Carro\n7 - Excluir Carro \n0 - Sair");

            opcao = Console.ReadLine();
            return opcao;
        }

        static void Main(string[] args)
        {
            int total = 0;
            Infocars[] estac = new Infocars[500];
            string opcao = "0";
            string ano = "";
            string modelo = "";
            string cor = "";

            do
            {
                opcao = menu();

                if (opcao == "1")
                {
                    Console.Clear();
                    Cadastro(estac, total);
                    total++;
                }

                else if (opcao == "2")
                {
                    Console.Clear();
                    ConsultarPorAno(estac, ano, total);
                    Console.ReadKey();
                }

                else if(opcao == "3")
                {
                    Console.Clear();
                    ConsultarPorModelo(estac, ano, total);
                    Console.ReadKey();
                }

                else if (opcao == "4")
                {
                    Console.Clear();
                    ConsultarPorCor(estac, ano, total);
                    Console.ReadKey();
                }

                else if (opcao == "5")
                {
                    Console.Clear();
                    Consultar(estac, total);
                    Console.ReadKey();
                }

                else if (opcao == "6")
                {
                    Console.WriteLine("");
                    AlterarCarro(estac, total);
                    Console.ReadKey();
                }

                else if (opcao == "7")
                {
                    Console.WriteLine("");
                    Excluir(estac, total);
                    Console.ReadKey();
                }

            } while (opcao != "0");
            Console.ReadKey();
        }
    }
}
