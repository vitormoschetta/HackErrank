using System.Collections.Generic;
using System.Linq;
using testes.venturus.testeLivre.SupportFiles;

namespace testes.venturus.testeLivre
{
    public class Task3
    {
        /*
          Para os exercicios abaixo, considere a classe Repository como uma DataBase.
       */


        /* Tarefa 3.1: Crie uma função que retorne a lista do nome dos itens com o estoque zerado.*/
        public static List<string> GetItemsOutOfStock()
        {
            var repository = new Repository();

            var componentsList = (from stock in repository.Stocks
                                  join component in repository.Components
                                  on stock.ComponentId equals component.Id
                                  where stock.Quantity == 0
                                  select component.Name).ToList();

            return componentsList;
        }


        /* Tarefa 3.2: Crie uma função que retorne o a soma do total de itens no stock.*/
        public static int GetStockSum()
        {
            var repository = new Repository();
            int totalItems = repository.Stocks.Sum(item => item.Quantity);
            return totalItems;
        }

        /* Tarefa 3.3: Considere o seguinte pedido:
         * 
         * 200 Items do Produto A
         * 
         * Considerando a lista de materiais necessários para o Produto A:
         * 1. 2 Unidades do Component 2
         * 2. 1 Unidades do Component 3
         * 3. 3 Unidades do Component 4
         * 
         * Crie uma função que receba a quantidade de itens em um pedido, a lista de materiais necessários para a briação de uma unidade e retorne se é possível ou não atender o pedido        
         * .*/
        public bool IsPossibleManufacturer(int OrderQuantity, MaterialEntry[] MaterialList)
        {
            var repository = new Repository();
            var possibility = true;

            foreach (var material in MaterialList)
            {
                var totalItems = material.Quantity * OrderQuantity;

                foreach (var stock in repository.Stocks)
                {
                    if (stock.ComponentId == material.ComponetId)
                    {
                        if (stock.Quantity < totalItems)
                            possibility = false;
                    }
                }
            }

            return possibility;
        }
    }
}