using System.Collections.Generic;
using System.Linq;

namespace treinamento.problemas
{
    // path representa o caminho => pra cima (U), ou pra baixo (D)
    // o caminhante parte da posição 0 (zero). U = ++, D = --
    // retornar quantas vezes a posição esteve a baixo de 0(zero) depois de retornar pra ele ou subir a cima dele.
    public class problema06
    {
        string path;
        public problema06()
        {
            path = "UDDDUDUUDD";
        }
        public int countingValleys()
        {
            int valleys = 0;
            int mark = 0;

            for (int i = 0; i < path.Length; i++)
            {
                var action = path.Substring(i, 1);

                if (action == "U")
                    mark++;
                else if (action == "D")
                {
                    if (mark == 0)
                        valleys++;

                    mark--;
                }
            }

            return valleys;
        }

        public int countingValleys2()
        {
            int valleys = 0;
            int mark = 0;

            for (int i = 0; i < path.Length; i++)
            {
                var action = path.Substring(i, 1);

                switch (action)
                {
                    case "U":
                        mark++;
                        break;
                    case "D":
                        if (mark == 0)
                            valleys++;
                        mark--;
                        break;
                }
            }

            return valleys;
        }


    }
}