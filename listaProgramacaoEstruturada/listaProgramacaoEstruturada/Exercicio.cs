using System;
using System.Collections.Generic;
using System.Text;

namespace listaProgramacaoEstruturada
{
    class Exercicio
    {
        public int Ex5()
        {
            // Eu só queria estar em C e usar uma struct pra isso, mas não posso.
            // Enfim, me recuso a criar tudo duas vezes
            // (acho que não tem)
            int pecaCod1, pecaQnt1;
            float pecaValor1, pecaValorTotal1, pecaValorTotal;

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

            pecaValorTotal = pecaValorTotal1 + pecaValorTotal2;

            Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", pecaValorTotal);

            return 0;
        }
    }
}