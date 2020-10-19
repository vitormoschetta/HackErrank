using System.Collections.Generic;
using System.Linq;

namespace treinamento.problemas
{
    // Convertender array para List
    public class problema01_b
    {
        public int[] array;
        public problema01_b()
        {
            array = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20, 20, 10 };
        }
        public int PairsQuantity()
        {
            int pairs = 0;
            List<int> ar = new List<int>(array);

            while (ar.Count > 1)
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


    }
}