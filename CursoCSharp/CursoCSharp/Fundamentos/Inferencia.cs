using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
      public static void Executar()
      {
        var nome = "Lucas";
        nome = "Luan";
        Console.WriteLine(nome);

        int a;
        a = 3;

        int b = 2;

        Console.WriteLine(a + b);
      }
    }
}
