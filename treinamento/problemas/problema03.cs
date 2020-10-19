using System;
using System.Collections.Generic;
using System.Linq;

namespace treinamento.problemas
{
    // Converte duas strings em array list de inteiro 
    // Compara item de uma lista com da outra lista na mesma posição
    // O item maior de uma determinada posição entre as duas lista ganha um ponto para a sua lista    
    public class problema03
    {
        public string stringLIstA;
        public string stringLIstB;
        public problema03()
        {
            stringLIstA = "5 6 7 5";
            stringLIstB = "3 6 10 4";
        }
        public List<int> simpleArraySum()
        {
            List<int> Alice = stringLIstA.Split(' ')
                                    .ToList() // até aqui pega uma List<string>
                                    .Select(x => Convert.ToInt32(x)) // até aqui pega um IEnumerable<int>
                                    .ToList(); // até aqui um List<int>

            List<int> Bob = stringLIstB.Split(' ')
                                    .ToList()
                                    .Select(x => Convert.ToInt32(x))
                                    .ToList();

            int pontosAline = 0;
            int pontosBob = 0;

            for (int i = 0; i < Alice.Count; i++)
            {
                if (Alice[i] > Bob[i])
                    pontosAline++;
                else if (Alice[i] < Bob[i])
                    pontosBob++;
            }

            return new List<int>() { pontosAline, pontosBob };
        }
    }
}