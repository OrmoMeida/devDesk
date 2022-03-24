using System;
using System.Collections.Generic;
using System.Text;

namespace listaProgramacaoEstruturada
{
    class Exercicio
    {
        public int Ex6()
        {
            float a, b, c; // eu vou chorar só queria um array
            float pi = 3.14159F;

            string[] input = new string[3];
            input = Console.ReadLine().Split(' ');

            a = float.Parse(input[0]);
            b = float.Parse(input[1]);
            c = float.Parse(input[2]);

            // mais sofrimento pq era pra cada polígono ser uma função

            float areaTriangulo = (a * c) / 2;
            float areaCirculo = pi * (c * c);
            float areaTrapezio = (((a + b) + 2) * c) / 2;
            float areaQuadrado = b * b;
            float areaRetangulo = a * b;

            return 0;
        }
    }
}