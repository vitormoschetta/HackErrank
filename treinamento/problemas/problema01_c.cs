using System.Linq;

namespace treinamento.problemas
{
    // Sem converter para List<int>
    public class problema01_c
    {
        public int[] array;
        public problema01_c()
        {
            array = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20, 20, 10 };
        }
        public int PairsQuantity()
        {
            int pairs = 0;

            while (array.Length > 1)
            {
                var initial = array[0];
                var items = array.Where(x => x == initial).ToList();

                if (items.Count() > 1)
                    pairs = pairs + items.Count / 2;

                array = array.Where(x => x != items[0]).ToArray();
            }

            return pairs;
        }
    }
}