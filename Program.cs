using System;

namespace Calculator{

  class Program {

    static void Main(string[] args)
    { 
        Console.Clear();

        Console.WriteLine("Digite o Primeiro Valor:");
        float v1 = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());
       float resultado = v1 + v2;
        Console.WriteLine("");  
        Console.WriteLine("O resultado da Soma é: " + resultado);
        
    }
  }
}
