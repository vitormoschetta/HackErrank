using System.Collections.Generic;
using System.Linq;

namespace treinamento.problemas
{
    // retornar soma dos inteiros de uma lista
    public class problema02
    {
        public int[] ar;
        public problema02()
        {
            ar = new int[] { 5, 2 };
        }
        public int simpleArraySum()
        {
            return ar.Sum();
        }
    }
}