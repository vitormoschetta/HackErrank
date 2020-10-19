using System.Collections.Generic;

namespace treinamento.problemas
{
    // Dado um número (n) verificar se ele é multiplo de 3 e de 5
    // se for múltiplo de 3 e 5, imprimir 'FizzBuzz'
    // se for múltiplo de 3 apenas, imprimir 'Fizz'
    // se múltiplo de 5 apenas, imprimir 'Buzz'
    // se não for múltiplo nem de 3, nem de 5, imprimir o próprio número.
    public class problema05
    {
        public int n;
        public problema05()
        {
            n = 15;
        }

        public List<string> ImprimeMultiplos()
        {
            var lista = new List<string>();

            for (var i = 1; i <= n; i++)
            {
                if ((i % 3) == 0)
                {
                    if ((i % 5) == 0)
                        lista.Add("FizzBuzz");
                    else
                        lista.Add("Fizz");
                }
                else if ((i % 5) == 0)
                    lista.Add("Buzz");
                else
                    lista.Add(i.ToString());
            }

            return lista;
        }
    }
}