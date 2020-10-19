using System;
using System.Collections.Generic;
using System.Linq;

namespace treinamento.problemas
{
    // retornar soma dos inteiros separados por espaço em uma string
    public class problema04
    {
        public string stringLIstA;
        public problema04()
        {
            stringLIstA = "1000000001 1000000002 1000000003 1000000004 1000000005";
        }
        public long aVeryBigSum()
        {
            List<long> lista = stringLIstA.Split(' ')
                                    .ToList() // até aqui pega uma List<string>
                                    .Select(x => Convert.ToInt64(x)) // até aqui pega um IEnumerable<long>
                                    .ToList(); // até aqui um List<long>

            return lista.Sum();

        }
    }
}