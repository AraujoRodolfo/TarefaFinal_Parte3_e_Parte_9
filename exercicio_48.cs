using System;

namespace exercicio_48
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int erase;
            Carro[] estac = new Carro[500];
            string opcao = "0";
            string ano = "";

            do {
                opcao = menu();
                if (opcao == "1")
                {
                    Console.Clear();
                    cadastrar(estac, total);
                    total++;
                }

                else if (opcao == "2")
                {
                    Console.Clear();
                    consultarAno(estac, ano, total);
                    Console.ReadKey();
                }

                else if (opcao == "3")
                {
                    Console.Clear();
                    consultarModelo(estac, ano, total);
                    Console.ReadKey();
                }

                else if (opcao == "4")
                {
                    Console.Clear();
                    consultarCor(estac, ano, total);
                    Console.ReadKey();
                }

                else if (opcao == "5")
                {
                    Console.Clear();
                    consultar(estac, total);
                    Console.ReadKey();
                }

                else if (opcao == "6")
                {
                    Console.Clear();
                    consultar(estac, total);
                    alterar(estac, total);
                    Console.ReadKey();
                }

                else if (opcao == "7")
                {
                    Console.Clear();
                    consultar(estac, total);
                    Console.Write("Digite a vaga em que o veículo se encontra para excluí-lo: ");
                    erase = int.Parse(Console.ReadLine());
                    excluir(estac, erase, total);
                    total--;
                    Console.ReadKey();
                }
            } while (opcao != "0");
            Console.ReadKey();
        }

        static string menu()
        {
            string opcao;
            Console.WriteLine("Menu:\n1- Cadastrar carro\n2- Consultar carro por ano de fabricação\n3- Consultar carro por modelo\n4- Consultar carro por cor\n5- Carros cadastrados \n6- Alterar dados de um carro\n7- Excluir um carro \n0- Sair");
            opcao = Console.ReadLine();
            Console.Clear();
            return opcao;
        }

        struct Carro
        {
            public string cor;
            public string modelo;
            public string ano;
        }

        static void cadastrar(Carro[] estac, int total)
        {
            string cor, modelo, ano;
            Console.WriteLine("Cadastre seu carro");

            Console.Write("Modelo do carro: ");
            estac[total].modelo = Console.ReadLine();
            modelo = estac[total].modelo;

            Console.Write("Cor do carro: ");
            estac[total].cor = Console.ReadLine();
            cor = estac[total].cor;

            Console.Write("Ano do carro: ");
            estac[total].ano = Console.ReadLine();
            ano = estac[total].ano;

            Console.WriteLine("Carro cadastrado!");
            Console.WriteLine("");
            total++;
        }

        static void consultarAno(Carro[] estac, string ano, int total)
        {
            string carroano;
            Console.Write("Ano: ");
            carroano = Console.ReadLine();

            for (int i = 0; i < total; i++)
            {
                if (carroano == estac[i].ano)
                {
                    Console.WriteLine("{0}- {1}  {2}  {3}", i + 1, estac[i].modelo, estac[i].cor, carroano);
                }
            }
            Console.WriteLine("");
        }

        static void consultarModelo(Carro[] estac, string modelo, int total)
        {
            string carromodelo;
            Console.Write("Modelo: ");
            carromodelo = Console.ReadLine();

            for (int i = 0; i < total; i++)
            {
                if (carromodelo == estac[i].modelo)
                {
                    Console.WriteLine("{0}- {1}  {2}  {3}", i + 1, carromodelo, estac[i].cor, estac[i].ano);
                }
            }
            Console.WriteLine("");
        }

        static void consultarCor(Carro[] estac, string cor, int total)
        {
            string carrocor;
            Console.Write("Cor: ");
            carrocor = Console.ReadLine();

            for (int i = 0; i < total; i++)
            {
                if (carrocor == estac[i].cor)
                {
                    Console.WriteLine("{0}- {1}  {2}  {3}", i + 1, estac[i].modelo, carrocor, estac[i].ano);
                }
            }
            Console.WriteLine("");
        }

        static void consultar(Carro[] estac, int total)
        {
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("{0}- {1}  {2}  {3}", i + 1, estac[i].modelo, estac[i].cor, estac[i].ano);
            }
            Console.WriteLine("");
        }

        static void alterar(Carro[] estac, int total)
        {
            int x;
            string alterar = "";
            string a = "";

            Console.Write("Digite a vaga em que seu carro se encontra: ");
            x = int.Parse(Console.ReadLine());

            for (int i = x; i == x; i++)
            {
                if (x <= total)
                {
                    Console.Write("Deseja alterar modelo, cor ou ano? ");
                    alterar = Console.ReadLine();

                    if (alterar == "ano")
                    {
                        estac[i - 1].ano = a;
                        Console.Write("Novo ano: ");
                        estac[i - 1].ano = Console.ReadLine();
                        Console.WriteLine("Ano alterado!");
                        Console.WriteLine("");
                    }

                    else if (alterar == "cor")
                    {
                        estac[i - 1].cor = a;
                        Console.Write("Nova cor: ");
                        estac[i - 1].cor = Console.ReadLine();
                        Console.WriteLine("Cor alterada!");
                        Console.WriteLine("");
                    }

                    else if (alterar == "modelo")
                    {
                        estac[i - 1].modelo = a;
                        Console.Write("Novo modelo: ");
                        estac[i - 1].modelo = Console.ReadLine();
                        Console.WriteLine("Modelo alterado!");
                        Console.WriteLine("");
                    }
                }
            }
        }

        static void excluir(Carro[] estac, int erase, int total)
        {
            for (int i = erase - 1; i < total; i++)
            {
                estac[i] = estac[i + 1];
            }
            Console.WriteLine("Carro excluído!");
            Console.WriteLine("");
        }
    }
}