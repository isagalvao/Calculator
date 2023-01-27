using System;

namespace Calculator{

  class Program {

    static void Main(string[] args){
    Menu();
    }

    static void Menu(){
      Console.Clear();

      Console.WriteLine("Bem Vindo ao Calculator, qual operação deseja utilizar?");
      Console.WriteLine("(1) - Soma");
      Console.WriteLine("(2) - Subtração");
      Console.WriteLine("(3) - Divisão");
      Console.WriteLine("(4) - Multiplicação");
      Console.WriteLine("(5) - Finalizar sessão");
      Console.WriteLine("-------------------");
      short res = short.Parse(Console.ReadLine());

      switch (res){
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
      }

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
      Menu();
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
      Menu();
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
      Menu();
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
      Menu();
     }
  }
  
}
