using System;
using System.Collections.Generic;
using System.Text;

namespace listaProgramacaoEstruturada
{
    class Exercicio
    {
        public int Ex2()
        {
            const float pi = 3.14159F;

            float raio = float.Parse(Console.ReadLine());
            float area = pi * (raio * raio);

            Console.WriteLine("A = {0:F4}", area);
            return 0;
        }
    }
}