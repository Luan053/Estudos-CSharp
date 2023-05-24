using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar() {
            string nome = "Notebook";
            string marca = "Lenovo";
            double preco = 2300.00;

            Console.WriteLine("O " + nome + " da marca "
                              + marca + " custa " + preco + ".");
            Console.WriteLine("O {0} da marca {1} custa {2}.",
                nome, marca, preco);
            Console.WriteLine($"O notebook da {marca} é bom!");
            Console.WriteLine($"2 + 5 = {2 + 5}!");
        }
    }
}
