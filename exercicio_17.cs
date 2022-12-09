using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            if(idade < 18)
            {
                Console.WriteLine("Você é menor de idade.");
            }
            else
            {
                Console.WriteLine("Você é maior de idade.");
            }
            Console.ReadKey();
        }
    }
}
