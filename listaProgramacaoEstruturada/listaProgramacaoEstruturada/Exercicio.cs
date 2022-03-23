using System;
using System.Collections.Generic;
using System.Text;

namespace listaProgramacaoEstruturada
{
    class Exercicio
    {
        public int Ex1()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("SOMA = " + sum);
            return 0;
        }

        public int Ex2()
        {
            const float pi = 3.14159F;

            float raio = float.Parse(Console.ReadLine());
            float area = pi * (raio * raio);

            Console.WriteLine("A = " + area);
            return 0;
        }

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

        public int Ex4()
        {
            int funcNum, funcHoras;
            float funcSalario, funcSalarioHora;

            funcNum = int.Parse(Console.ReadLine());
            funcHoras = int.Parse(Console.ReadLine());
            funcSalarioHora = float.Parse(Console.ReadLine());

            funcSalario = funcHoras * funcSalarioHora;

            Console.WriteLine("NÚMERO = " + funcNum);
            Console.WriteLine("SALÁRIO = " + funcSalario);

            return 0;
        }

        public int Ex5()
        {
            // Eu só queria estar em C e usar uma struct pra isso, mas não posso.
            // Enfim, me recuso a criar tudo duas vezes
            // (acho que não tem)
            int pecaCod1, pecaQnt1;
            float pecaValor1, pecaValorTotal1;

            int pecaCod2, pecaQnt2;
            float pecaValor2, pecaValorTotal2;

            string[] peca1 = Console.ReadLine().Split(' ');
            string[] peca2 = Console.ReadLine().Split(' ');

            pecaCod1 = int.Parse(peca1[0]);
            pecaQnt1 = int.Parse(peca1[1]);
            pecaValor1 = float.Parse(peca1[2]);

            pecaCod2 = int.Parse(peca2[0]);
            pecaQnt2 = int.Parse(peca2[1]);
            pecaValor2 = float.Parse(peca2[2]);
            // cada segundo em que eu não posso usar um monte de array e struct minha alma apodrece

            pecaValorTotal1 = pecaQnt1 * pecaValor1;
            pecaValorTotal2 = pecaQnt2 * pecaValor2;

            Console.WriteLine("VALOR A PAGAR: R$ {.2F}", pecaValorTotal1);
            Console.WriteLine("VALOR A PAGAR: R$ {.2F}", pecaValorTotal2);

            return 0;
        }

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

            return 0;
        }
    }
}