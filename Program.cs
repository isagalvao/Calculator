using System;

namespace Calculator{

  class Program {

    static void Main(string[] args){
    Menu();
    }

    static void Menu(){
      Console.Clear();

      Console.WriteLine("Bem Vindo ao Calculator!");
      Console.WriteLine("(1) - Soma");
      Console.WriteLine("(2) - Subtração");
      Console.WriteLine("(3) - Divisão");
      Console.WriteLine("(4) - Multiplicação");

      Console.WriteLine("-------------------");
      Console.WriteLine("Qual operação deseja utilizar?");
      short res = short.Parse(Console.ReadLine());

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
     static void Divisao(){
      Console.Clear();

      Console.WriteLine("Digite o Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());

       Console.WriteLine("Digite o Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 / v2;

      // Console vazio apenas para pular Linha
      Console.WriteLine("");  

      Console.WriteLine("O resultado da divisão é: " + resultado);
      Console.ReadKey();
     }
      static void Multiplicacao(){
      Console.Clear();

      Console.WriteLine("Digite o Primeiro Valor:");
      float v1 = float.Parse(Console.ReadLine());

       Console.WriteLine("Digite o Segundo Valor:");
        float v2 = float.Parse(Console.ReadLine());

        float resultado = v1 * v2;

      // Console vazio apenas para pular Linha
      Console.WriteLine("");  

      Console.WriteLine("O resultado da Multiplicação é: " + resultado);
      Console.ReadKey();
     }
  }
  
}
