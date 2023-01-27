using System;

namespace Calculator{

  class Program {

    static void Main(string[] args){
      Console.WriteLine("Bem Vindo ao Calculator!");
      Subtracao();
    }
    static void Soma(){
       Console.Clear();

       Console.WriteLine("Digite o Primeiro Valor:");
        float v1 = float.Parse(Console.ReadLine());
          
       Console.WriteLine("Digite o Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 + v2;

      // Console vazio apenas para pular Linha
      Console.WriteLine("");  

      Console.WriteLine("O resultado da Soma é: " + resultado);
      Console.ReadKey();
    }

    static void Subtracao(){
      Console.Clear();

      Console.WriteLine("Digite o Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());

       Console.WriteLine("Digite o Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 - v2;

      // Console vazio apenas para pular Linha
      Console.WriteLine("");  

      Console.WriteLine("O resultado da subtração é: " + resultado);
      Console.ReadKey();
    }
     static void divisao(){
      Console.Clear();

      Console.WriteLine("Digite o Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());

       Console.WriteLine("Digite o Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 / v2;

      // Console vazio apenas para pular Linha
      Console.WriteLine("");  

      Console.WriteLine("O resultado da divisao é: " + resultado);
      Console.ReadKey();
     }
  }
  
}
