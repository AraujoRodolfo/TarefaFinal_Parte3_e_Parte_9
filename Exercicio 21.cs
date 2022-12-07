using System;

class Program {
    static void Main(string[] args) {
        int a, b;

        Console.WriteLine("Digite um Valor: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro Valor: ");
        b = int.Parse(Console.ReadLine());
        trocar(a,b);
        Console.ReadKey();
    }
  
  static void trocar(int a, int b) 
  {
        int troca;
        troca = a;
        a = b;
        b = troca;
        Console.WriteLine("{0} e {1}", a, b);
  }
}