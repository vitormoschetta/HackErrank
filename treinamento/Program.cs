using System;
using System.Collections.Generic;
using treinamento.problemas;

namespace treinamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new problema01_c().PairsQuantity());

            //Console.WriteLine(new problema02().simpleArraySum());

            //Console.WriteLine(string.Join(" Aline x Bob ", new problema03().simpleArraySum()));
            // Obs: string.Join concatena os elementos de uma lista, onde o primeiro parâmetro
            // é um separador, no nosso caso " x ", e o segundo parâmetro é a lista.

            //Console.WriteLine(string.Join(" x ", new problema04().aVeryBigSum()));

            //Console.WriteLine(string.Join(" ", new problema05().ImprimeMultiplos()));




        }
    }
}
