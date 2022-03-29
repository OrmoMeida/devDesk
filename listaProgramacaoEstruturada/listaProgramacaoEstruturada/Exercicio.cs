using System;
using System.Collections.Generic;
using System.Text;

namespace listaProgramacaoEstruturada
{
    class Exercicio
    {
        public int Ex3()
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int diferenca = ((a * b) - (c * d));
            Console.WriteLine("DIFERENÇA = " + diferenca);

            return 0;
        }
    }
}