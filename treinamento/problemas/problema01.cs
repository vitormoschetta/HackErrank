using System.Collections.Generic;
using System.Linq;

namespace treinamento.problemas
{
    // retornar quantos PARES de números iguais é possível formar com uma lista de inteiro
    public class problem01
    {
        public List<int> ar;
        public problem01()
        {
            ar = new List<int>() { 10, 20, 20, 10, 10, 30, 50, 10, 20, 20, 10 };
        }
        public int PairsQuantity()
        {
            int pairs = 0;
            while (ar.Count() > 1)
            {
                var initial = ar[0];
                var items = ar.Where(x => x == initial).ToList();

                if (items.Count() > 1)
                    pairs = pairs + items.Count / 2;

                foreach (var item in items)
                    ar.Remove(item);
            }

            return pairs;
        }

        // Precisamos fazer a tarefa acima, porém manter a lista inicial:
        public int PairsQuantity2()
        {
            //List<int> arCopy = ar;    // <-- Isso não adianta, pois arCopy aqui não seria uma lista real. Apenas apontaria para ar.

            List<int> arCopy = new List<int>();
            foreach (var item in ar)
            {
                arCopy.Add(item);
            }

            int pairs = 0;

            while (ar.Count() > 1)
            {
                var color = ar[0];
                var items = ar.Where(x => x == color).ToList();

                if (items.Count() > 1)
                    pairs = pairs + items.Count / 2;

                foreach (var item in items)
                {
                    ar.Remove(item);
                }
            }

            var teste = arCopy;

            return pairs;
        }
    }
}