using System;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            exercicios diagnostica = new exercicios();

            // Lista de estrutura sequencial
            diagnostica.lista1.Ex1();
            diagnostica.lista1.Ex2();

            // Lista de estrutura condicional
            diagnostica.lista2.Ex1();
            diagnostica.lista2.Ex2();

            // Lista de estrutura repetitiva
            diagnostica.lista3.Ex1();
            diagnostica.lista3.Ex2();
        }
    }
}
