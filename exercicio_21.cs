using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;

            Console.Write("Digite um número para A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite um número para B: ");
            b = int.Parse(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Valor de A: {0}\nValor de B: {1}", a, b);

            Console.ReadKey();
        }
    }
}
