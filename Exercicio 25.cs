using System;

class Program {
    static void Main(string[] args) {
        int a;

        Console.WriteLine("Digite um Valor: ");
        a = int.Parse(Console.ReadLine());
        tabuada(a);
        Console.ReadKey();
    }
  
  static void tabuada(int a) 
  {
    for (int i = 0; i<=10; i++)
    {
      Console.WriteLine("{0}x{1}={2}",a, i, a*i);
    }
  }
}