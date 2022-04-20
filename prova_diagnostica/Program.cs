using System;

namespace prova_diagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            exercicios diagnostica = new exercicios();

            // Lista de estrutura sequencial
            Console.WriteLine("Lista de estrutura sequencial:  \n");
            diagnostica.lista1.Ex1();
            diagnostica.lista1.Ex2();

            // Lista de estrutura condicional
            Console.WriteLine("\n\n\n\n\nLista de estrutura condicional:  \n");
            diagnostica.lista2.Ex1();
            diagnostica.lista2.Ex2();

            // Lista de estrutura repetitiva
            Console.WriteLine("\n\n\n\n\nLista de estrutura repetitiva:  \n");
            diagnostica.lista3.Ex1();
            diagnostica.lista3.Ex2();
        }
    }
}
