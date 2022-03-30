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
            const float pi = 3.14159F;

            string[] input = Console.ReadLine().Split(' ');

            a = float.Parse(input[0]);
            b = float.Parse(input[1]);
            c = float.Parse(input[2]);

            // mais sofrimento pq era pra cada polígono ser uma função

            float areaTriangulo = (a * c) / 2;
            float areaCirculo = pi * (c * c);
            float areaTrapezio = (((a + b) + 2) * c) / 2;
            float areaQuadrado = b * b;
            float areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: {0:F3}", areaTriangulo);
            Console.WriteLine("CIRCULO:  {0:F3}", areaCirculo);
            Console.WriteLine("TRAPEZIO:  {0:F3}", areaTrapezio);
            Console.WriteLine("QUADRADO:  {0:F3}", areaQuadrado);
            Console.WriteLine("RETANGULO:  {0:F3}", areaRetangulo);

            return 0;
        }
    }
}
