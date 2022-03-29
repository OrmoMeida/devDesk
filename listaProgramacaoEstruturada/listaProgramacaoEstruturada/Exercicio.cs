using System;
using System.Collections.Generic;
using System.Text;

namespace listaProgramacaoEstruturada
{
    class Exercicio
    {
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
    }
}