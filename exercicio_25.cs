Exercício 25

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Digite um número para saber sua tabuada: ");
            num = int.Parse(Console.ReadLine());

            for (int a = 0; a < 11; a++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, a, num * a);
            }

            Console.ReadKey();
        }
    }
}
