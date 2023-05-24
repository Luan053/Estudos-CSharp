using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 2.5;
            const double PI = 3.14;

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            bool testeBool = true;
            Console.WriteLine(testeBool);

            int idade = 19;
            Console.WriteLine("Tenho" + idade + "anos");

            
        }
    }
}
