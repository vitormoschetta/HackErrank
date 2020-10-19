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
            ar = new int[] { 5, 2, 3 };
        }


        // Tres formas de resolver:

        public int simpleArraySum()
        {
            return ar.Sum();
        }

        public int simpleArraySum2()
        {
            int sum = 0;
            foreach (var item in ar)
                sum += item;

            return sum;
        }

        public int simpleArraySum3()
        {
            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
                sum += ar[i];

            return sum;
        }
    }
}