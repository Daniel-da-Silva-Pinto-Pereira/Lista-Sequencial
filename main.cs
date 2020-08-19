using System;

class MainClass {
  //3.Faça um Programa que peça dois números e imprima a soma.
  public static void Exercicio03() 
  {
   float n1, n2, resultado;

    Console.Write("Digite o Primeiro Numero ->");
    n1 = float.Parse(Console.ReadLine());

    Console.Write ("Digite o Segundo Numero ->");
    n2 = float.Parse(Console.ReadLine());
    
    resultado = n1 + n2;

    Console.WriteLine("Resultado ->{0}", resultado);
  }
 //4.Faça um Programa que peça as 4 notas bimestrais e mostre a média.
  public static void Exercicio04() 
  {
    float nota1, nota2, nota3, nota4, média;

    Console.Write("Digite a Sua Prmeira Nota ->");
    nota1 = float.Parse(Console.ReadLine());

    Console.Write("Digite a Sua Segunda Nota ->");
    nota2 = float.Parse(Console.ReadLine());

    Console.Write("Digite a Sua Terceira Nota ->");
    nota3 = float.Parse(Console.ReadLine());

    Console.Write("Digite a Sua Quarta Nota ->");
    nota4 = float.Parse(Console.ReadLine());

    média = nota1+nota2+nota3+nota4/2;

    Console.Write("Sua Média é ->{0}", média);
  }
  public static void Main () {
    Exercicio03();
    Exercicio04();
  
  }
}