using System.Collections.Generic;
using System.Linq;

namespace treinamento.problemas
{
    // steps são o número de passos dados;
    // path representa o caminho => pra cima (U), ou pra baixo (D)
    // o caminhante parte da posição 0 (zero). U = ++, D = --
    // retornar quantas vezes a posição esteve a baixo de 0(zero) depois de retornar pra ele ou subir a cima dele.
    public class problema06
    {
        int steps;
        string path;
        public problema06()
        {
            steps = 8;
            path = "UDDDUDUU";
        }
        public int countingValleys()
        {
            int valleys = 0;
            int mark = 0;

            for (int i = 0; i < path.Length; i++)
            {
                if (path.Substring(i, 1) == "U")
                {
                    mark++;
                }
                else if (path.Substring(i, 1) == "D")
                {
                    if (mark == 0)
                    {
                        valleys++;
                    }
                    mark--;
                }
            }

            return valleys;
        }
    }
}