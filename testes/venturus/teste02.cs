using System.Collections.Generic;

namespace testes.venturus
{
    // Dado duas listas de inteiro, e um inteiro (q):
    // Respondidas: as questões já respondidas
    // Necessário: quantidade mínima que o aluno deve responder para passar
    // q => quantidade de questões que ainda pode responder.
    // Retornar em quantas disciplinas o aluno pode passar ao distribuir bem as questões ainda
    // disponíveis.
    public class teste02
    {
        public List<int> respondidas;
        public List<int> necessario;
        public int q;
        public teste02()
        {
            respondidas = new List<int>() { 24, 27, 0 };
            necessario = new List<int>() { 51, 52, 100 };
            q = 100;
        }
        public int QuestoesDisciplinas()
        {
            var a = 0;
            var b = 0;
            var c = 0;

            for (int i = 0; i < respondidas.Count; i++)
            {
                if (i == 0)
                {
                    if (respondidas[i] < necessario[i])
                        a = necessario[i] - respondidas[i];
                }
                if (i == 1)
                {
                    if (respondidas[i] < necessario[i])
                        b = necessario[i] - respondidas[i];
                }
                if (i == 2)
                {
                    if (respondidas[i] < necessario[i])
                        c = necessario[i] - respondidas[i];
                }
            }

            return 1;
        }
    }
}